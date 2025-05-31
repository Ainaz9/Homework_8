using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TaskLibrary;

namespace Homework_8
{
    public partial class AddTaskForm : Form
    {
        private readonly TaskLib dbLib;

        private readonly ILogger<AddTaskForm> log;

        private readonly IServiceProvider serviceProvider;

        public AddTaskForm(TaskLib DbLib, ILogger<AddTaskForm> Logger, IServiceProvider ServiceProvider)
        {
            InitializeComponent();
            log = Logger;
            dbLib = DbLib;
            serviceProvider = ServiceProvider;

            textBoxTitleTask.Text = "������� ������";
            textBoxTitleTask.ForeColor = Color.Gray;
            textBoxAssigneeTask.Text ="������� �����������";
            textBoxAssigneeTask.ForeColor = Color.Gray;

            LoadTasks();

            dataGridViewTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // ������������
            dataGridViewTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // ��������� ������

            log.LogInformation("������� � ���� ��� ���������� �����");
        }

        private async void buttonAddTask_Click(object sender, EventArgs e)
        {
            log.LogInformation("������� �������� ������");

            if (string.IsNullOrWhiteSpace(textBoxAssigneeTask.Text) || textBoxAssigneeTask.Text == "������� �����������")
            {
                MessageBox.Show("������� ����������� ������!");
                log.LogWarning("������� ������� ������ ��� ��������");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxTitleTask.Text) || textBoxTitleTask.Text == "������� ������")
            {
                MessageBox.Show("������� �������� ������!");
                log.LogWarning("������� ������� ������ ��� ��������");
                return;
            }

            var status = await dbLib.SearchStatusAsync(StatusForTask.Queue);

            var task = await dbLib.CreateTaskAsync(textBoxTitleTask.Text, textBoxAssigneeTask.Text, status);

            log.LogInformation("�������� ���������� ������");
            textBoxTitleTask.Text = "������� ������";
            textBoxTitleTask.ForeColor = Color.Gray;
            textBoxAssigneeTask.Text = "������� �����������";
            textBoxAssigneeTask.ForeColor = Color.Gray;

            log.LogInformation("������� �������� ������ �� ��");
            LoadTasks();
        }

        private async void buttonEditTask_Click(object sender, EventArgs e)
        {
            log.LogInformation("������� �������� ������");

            var row = dataGridViewTasks.SelectedRows[0];
            var idValue = row.Cells["Id"].Value;
            if (Guid.TryParse(idValue.ToString(), out Guid taskId))
            {
                var selectedTask = await dbLib.SearchTaskForIdAsync(taskId);
                var editForm = ActivatorUtilities.CreateInstance<CheckAndEditTaskForm>(serviceProvider, selectedTask);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    log.LogInformation("������� �������� ������ �� ��");
                    LoadTasks();
                }
            }
        }

        private void textBoxTitleTask_Leave(object sender, EventArgs e)
        {
            if (textBoxTitleTask.Text == string.Empty)
            {
                textBoxTitleTask.Text = "������� ������";
                textBoxTitleTask.ForeColor = Color.Gray;
            }
        }

        private void textBoxTitleTask_Enter(object sender, EventArgs e)
        {
            if (textBoxTitleTask.Text == "������� ������")
            {
                textBoxTitleTask.Text = string.Empty;
                textBoxTitleTask.ForeColor = Color.Black;
            }
        }

        private void LoadTasks()
        {
            var tasks = dbLib.LoadTasks();

            dataGridViewTasks.DataSource = null;
            dataGridViewTasks.DataSource = tasks;

            dataGridViewTasks.Columns["Id"].Visible = false;
            dataGridViewTasks.Columns["StatusId"].Visible = false;
            dataGridViewTasks.Columns["Text"].HeaderText = "�����";
            dataGridViewTasks.Columns["Text"].ReadOnly = true;
            dataGridViewTasks.Columns["Assignee"].HeaderText = "�����������";
            dataGridViewTasks.Columns["Assignee"].ReadOnly = true;
            dataGridViewTasks.Columns["Data"].HeaderText = "����";
            dataGridViewTasks.Columns["Data"].ReadOnly = true;
            dataGridViewTasks.Columns["Status"].HeaderText = "������";
            dataGridViewTasks.Columns["Status"].ReadOnly = true;

            dataGridViewTasks.CellFormatting += DataGridViewTasks_CellFormatting;

            log.LogInformation("�������� �������� ������ �� ��");
        }

        private void DataGridViewTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewTasks.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value is StatusModel statusModel)
                {
                    e.Value = RusStatus(statusModel.Status);
                }
            }
        }

        private static string RusStatus(StatusForTask status)
        {
            return status switch
            {
                StatusForTask.Queue => "�������",
                StatusForTask.InProgress => "� ������",
                StatusForTask.Completed => "���������",
                _ => "����������"
            };
        }

        private void textBoxAssigneeTask_Enter(object sender, EventArgs e)
        {
            if (textBoxAssigneeTask.Text == "������� �����������")
            {
                textBoxAssigneeTask.Text = string.Empty;
                textBoxAssigneeTask.ForeColor = Color.Black;
            }
        }

        private void textBoxAssigneeTask_Leave(object sender, EventArgs e)
        {
            if(textBoxAssigneeTask.Text == string.Empty)
            {
                textBoxAssigneeTask.Text = "������� �����������";
                textBoxAssigneeTask.ForeColor = Color.Gray;
            }
        }
    }
}
