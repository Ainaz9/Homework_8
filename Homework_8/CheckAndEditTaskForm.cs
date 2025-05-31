using Microsoft.Extensions.Logging;
using TaskLibrary;

namespace Homework_8
{
    public partial class CheckAndEditTaskForm : Form
    {
        private readonly TaskLib dbLib;
        private readonly ILogger<CheckAndEditTaskForm> log;
        private readonly TaskModel task;

        public CheckAndEditTaskForm(TaskModel Task, TaskLib DbLib, ILogger<CheckAndEditTaskForm> Logger)
        {
            InitializeComponent();
            log = Logger;
            dbLib = DbLib;

            task = dbLib.SearchTask(Task);
            textBoxTitleTask.Text = task.Text;
            textBoxAssigneeTask.Text = task.Assignee;

            switch (task.Status.Status)
            {
                case StatusForTask.Queue:
                    radioButtonQueue.Checked = true;
                    break;
                case StatusForTask.InProgress:
                    radioButtonInProgress.Checked = true;
                    break;
                case StatusForTask.Completed:
                    radioButtonCompleted.Checked = true;
                    break;
            }

            log.LogInformation("Переход в окно для изменения задачи");
        }

        private async void buttonEditTask_Click(object sender, EventArgs e)
        {
            var values = new List<RadioButton>
            { radioButtonQueue, radioButtonInProgress, radioButtonCompleted };

            StatusForTask? selectedStatus = null;
            foreach (var radio in values)
            {
                if (radio.Checked)
                {
                    selectedStatus = (StatusForTask?)radio.Tag;
                }
            }
            if (string.IsNullOrWhiteSpace(textBoxAssigneeTask.Text))
            {
                MessageBox.Show("Вы не ввели исполнителя задачи!");
                log.LogWarning("Попытка изменить задачу без исполнителя");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxTitleTask.Text))
            {
                MessageBox.Show("Вы не ввели текст задачи!");
                log.LogWarning("Попытка изменить задачу без текста");
                return;
            }
            if (textBoxTitleTask.Text == task.Text && textBoxAssigneeTask.Text == task.Assignee && task.Status.Status == selectedStatus)
            {
                MessageBox.Show("Вы не изменили задачу!");
                log.LogWarning("Попытка сохранить изменения задачи без измененнии");
                return;
            }
            if (selectedStatus == null)
            {
                MessageBox.Show("Вы не выбрали статус задачи!");
                log.LogWarning("Попытка изменить задачу без выбора статуса");
                return;
            }

            var selectedTask = await dbLib.SearchTaskForIdAsync(task.Id);
            if (selectedTask != null)
            {
                selectedTask.Text = textBoxTitleTask.Text;
                selectedTask.StatusId = (await dbLib.SearchStatusAsync(selectedStatus)).Id;

                await dbLib.SaveChangesAsync();

                log.LogInformation("Успешное изменение и сохранение данных задачи");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private async void buttonRemoveTask_Click(object sender, EventArgs e)
        {
            log.LogInformation("Попытка удаления задачи");

            var taskToDelete = await dbLib.SearchTaskForIdAsync(task.Id);
            if (taskToDelete != null)
            {
                await dbLib.RemoveTask(taskToDelete);

                log.LogInformation($"Успешное удаление задачи: {task.Text}");
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }
    }
}
