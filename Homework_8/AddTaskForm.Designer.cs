using TaskLibrary;

namespace Homework_8
{
    partial class AddTaskForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonAddTask = new Button();
            dataGridViewTasks = new DataGridView();
            initialBindingSource = new BindingSource(components);
            taskModelBindingSource = new BindingSource(components);
            labelToTask = new Label();
            panelAddTask = new Panel();
            textBoxAssigneeTask = new TextBox();
            buttonEditTask = new Button();
            textBoxTitleTask = new TextBox();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)initialBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskModelBindingSource).BeginInit();
            panelAddTask.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new Point(725, 448);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(160, 43);
            buttonAddTask.TabIndex = 0;
            buttonAddTask.Text = "Добавить задачу";
            buttonAddTask.UseVisualStyleBackColor = true;
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(37, 17);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersWidth = 51;
            dataGridViewTasks.Size = new Size(848, 361);
            dataGridViewTasks.TabIndex = 3;
            // 
            // taskModelBindingSource
            // 
            taskModelBindingSource.DataSource = typeof(TaskModel);
            // 
            // labelToTask
            // 
            labelToTask.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            labelToTask.Location = new Point(30, 9);
            labelToTask.Name = "labelToTask";
            labelToTask.Size = new Size(362, 38);
            labelToTask.TabIndex = 11;
            labelToTask.Text = "ЗАДАЧИ";
            // 
            // panelAddTask
            // 
            panelAddTask.BackColor = Color.White;
            panelAddTask.Controls.Add(textBoxAssigneeTask);
            panelAddTask.Controls.Add(buttonEditTask);
            panelAddTask.Controls.Add(textBoxTitleTask);
            panelAddTask.Controls.Add(dataGridViewTasks);
            panelAddTask.Controls.Add(buttonAddTask);
            panelAddTask.Location = new Point(12, 45);
            panelAddTask.Name = "panelAddTask";
            panelAddTask.Size = new Size(932, 504);
            panelAddTask.TabIndex = 12;
            // 
            // textBoxAssigneeTask
            // 
            textBoxAssigneeTask.BackColor = SystemColors.Window;
            textBoxAssigneeTask.BorderStyle = BorderStyle.FixedSingle;
            textBoxAssigneeTask.Font = new Font("Segoe UI", 16F);
            textBoxAssigneeTask.Location = new Point(37, 394);
            textBoxAssigneeTask.Name = "textBoxAssigneeTask";
            textBoxAssigneeTask.Size = new Size(668, 43);
            textBoxAssigneeTask.TabIndex = 10;
            textBoxAssigneeTask.Enter += textBoxAssigneeTask_Enter;
            textBoxAssigneeTask.Leave += textBoxAssigneeTask_Leave;
            // 
            // buttonEditTask
            // 
            buttonEditTask.Location = new Point(725, 384);
            buttonEditTask.Name = "buttonEditTask";
            buttonEditTask.Size = new Size(160, 53);
            buttonEditTask.TabIndex = 9;
            buttonEditTask.Text = "Редактировать задачу";
            buttonEditTask.UseVisualStyleBackColor = true;
            buttonEditTask.Click += buttonEditTask_Click;
            // 
            // textBoxTitleTask
            // 
            textBoxTitleTask.BackColor = SystemColors.Window;
            textBoxTitleTask.BorderStyle = BorderStyle.FixedSingle;
            textBoxTitleTask.Font = new Font("Segoe UI", 16F);
            textBoxTitleTask.Location = new Point(37, 448);
            textBoxTitleTask.Name = "textBoxTitleTask";
            textBoxTitleTask.Size = new Size(668, 43);
            textBoxTitleTask.TabIndex = 8;
            textBoxTitleTask.Enter += textBoxTitleTask_Enter;
            textBoxTitleTask.Leave += textBoxTitleTask_Leave;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 561);
            Controls.Add(panelAddTask);
            Controls.Add(labelToTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddTaskForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление задачами";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)initialBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskModelBindingSource).EndInit();
            panelAddTask.ResumeLayout(false);
            panelAddTask.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddTask;
        private DataGridView dataGridViewTasks;
        private Label labelToTask;
        private Panel panelAddTask;
        private TextBox textBoxTitleTask;
        private BindingSource taskModelBindingSource;
        private BindingSource initialBindingSource;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Button buttonEditTask;
        private TextBox textBoxAssigneeTask;
    }
}
