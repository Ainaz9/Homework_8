using TaskLibrary;

namespace Homework_8
{
    partial class CheckAndEditTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelToInfoTask = new Label();
            panel1 = new Panel();
            groupBoxProgressTask = new GroupBox();
            radioButtonCompleted = new RadioButton();
            radioButtonInProgress = new RadioButton();
            radioButtonQueue = new RadioButton();
            buttonRemoveTask = new Button();
            buttonEditTask = new Button();
            labelToEditTask = new Label();
            textBoxTitleTask = new TextBox();
            textBoxAssigneeTask = new TextBox();
            labelAssigneeTask = new Label();
            panel1.SuspendLayout();
            groupBoxProgressTask.SuspendLayout();
            SuspendLayout();
            // 
            // labelToInfoTask
            // 
            labelToInfoTask.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            labelToInfoTask.Location = new Point(12, 9);
            labelToInfoTask.Name = "labelToInfoTask";
            labelToInfoTask.Size = new Size(362, 38);
            labelToInfoTask.TabIndex = 12;
            labelToInfoTask.Text = "ИНФОРМАЦИЯ О ЗАДАЧЕ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(labelAssigneeTask);
            panel1.Controls.Add(textBoxAssigneeTask);
            panel1.Controls.Add(groupBoxProgressTask);
            panel1.Controls.Add(buttonRemoveTask);
            panel1.Controls.Add(buttonEditTask);
            panel1.Controls.Add(labelToEditTask);
            panel1.Controls.Add(textBoxTitleTask);
            panel1.Location = new Point(10, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(719, 295);
            panel1.TabIndex = 13;
            // 
            // groupBoxProgressTask
            // 
            groupBoxProgressTask.Controls.Add(radioButtonCompleted);
            groupBoxProgressTask.Controls.Add(radioButtonInProgress);
            groupBoxProgressTask.Controls.Add(radioButtonQueue);
            groupBoxProgressTask.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            groupBoxProgressTask.Location = new Point(3, 144);
            groupBoxProgressTask.Name = "groupBoxProgressTask";
            groupBoxProgressTask.Size = new Size(698, 77);
            groupBoxProgressTask.TabIndex = 16;
            groupBoxProgressTask.TabStop = false;
            groupBoxProgressTask.Text = "Прогресс задачи:";
            // 
            // radioButtonCompleted
            // 
            radioButtonCompleted.AutoSize = true;
            radioButtonCompleted.Location = new Point(486, 31);
            radioButtonCompleted.Name = "radioButtonCompleted";
            radioButtonCompleted.Size = new Size(158, 30);
            radioButtonCompleted.TabIndex = 19;
            radioButtonCompleted.TabStop = true;
            radioButtonCompleted.Tag = StatusForTask.Completed;
            radioButtonCompleted.Text = "Выполнено";
            radioButtonCompleted.UseVisualStyleBackColor = true;
            // 
            // radioButtonInProgress
            // 
            radioButtonInProgress.AutoSize = true;
            radioButtonInProgress.Location = new Point(247, 31);
            radioButtonInProgress.Name = "radioButtonInProgress";
            radioButtonInProgress.Size = new Size(133, 30);
            radioButtonInProgress.TabIndex = 18;
            radioButtonInProgress.TabStop = true;
            radioButtonInProgress.Tag = StatusForTask.InProgress;
            radioButtonInProgress.Text = "В работе";
            radioButtonInProgress.UseVisualStyleBackColor = true;
            // 
            // radioButtonQueue
            // 
            radioButtonQueue.AutoSize = true;
            radioButtonQueue.Location = new Point(11, 31);
            radioButtonQueue.Name = "radioButtonQueue";
            radioButtonQueue.Size = new Size(130, 30);
            radioButtonQueue.TabIndex = 17;
            radioButtonQueue.TabStop = true;
            radioButtonQueue.Tag = StatusForTask.Queue;
            radioButtonQueue.Text = "Очередь";
            radioButtonQueue.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveTask
            // 
            buttonRemoveTask.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            buttonRemoveTask.Location = new Point(481, 227);
            buttonRemoveTask.Name = "buttonRemoveTask";
            buttonRemoveTask.Size = new Size(220, 52);
            buttonRemoveTask.TabIndex = 15;
            buttonRemoveTask.Text = "Удалить задачу";
            buttonRemoveTask.UseVisualStyleBackColor = true;
            buttonRemoveTask.Click += buttonRemoveTask_Click;
            // 
            // buttonEditTask
            // 
            buttonEditTask.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            buttonEditTask.Location = new Point(202, 227);
            buttonEditTask.Name = "buttonEditTask";
            buttonEditTask.Size = new Size(271, 52);
            buttonEditTask.TabIndex = 14;
            buttonEditTask.Text = "Сохранить изменения";
            buttonEditTask.UseVisualStyleBackColor = true;
            buttonEditTask.Click += buttonEditTask_Click;
            // 
            // labelToEditTask
            // 
            labelToEditTask.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            labelToEditTask.Location = new Point(41, 80);
            labelToEditTask.Name = "labelToEditTask";
            labelToEditTask.Size = new Size(128, 43);
            labelToEditTask.TabIndex = 13;
            labelToEditTask.Text = "Задача:";
            // 
            // textBoxTitleTask
            // 
            textBoxTitleTask.BackColor = SystemColors.Window;
            textBoxTitleTask.BorderStyle = BorderStyle.FixedSingle;
            textBoxTitleTask.Font = new Font("Segoe UI", 16F);
            textBoxTitleTask.Location = new Point(175, 80);
            textBoxTitleTask.Multiline = true;
            textBoxTitleTask.Name = "textBoxTitleTask";
            textBoxTitleTask.Size = new Size(526, 48);
            textBoxTitleTask.TabIndex = 9;
            // 
            // textBoxAssigneeTask
            // 
            textBoxAssigneeTask.BackColor = SystemColors.Window;
            textBoxAssigneeTask.BorderStyle = BorderStyle.FixedSingle;
            textBoxAssigneeTask.Font = new Font("Segoe UI", 16F);
            textBoxAssigneeTask.Location = new Point(175, 14);
            textBoxAssigneeTask.Multiline = true;
            textBoxAssigneeTask.Name = "textBoxAssigneeTask";
            textBoxAssigneeTask.Size = new Size(526, 48);
            textBoxAssigneeTask.TabIndex = 17;
            // 
            // labelAssigneeTask
            // 
            labelAssigneeTask.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            labelAssigneeTask.Location = new Point(3, 14);
            labelAssigneeTask.Name = "labelAssigneeTask";
            labelAssigneeTask.Size = new Size(166, 43);
            labelAssigneeTask.TabIndex = 18;
            labelAssigneeTask.Text = "Исполнитель:";
            // 
            // CheckAndEditTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 358);
            Controls.Add(panel1);
            Controls.Add(labelToInfoTask);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CheckAndEditTaskForm";
            Text = "Изменение задачи";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxProgressTask.ResumeLayout(false);
            groupBoxProgressTask.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelToInfoTask;
        private Panel panel1;
        private Label labelToEditTask;
        private TextBox textBoxTitleTask;
        private Button buttonRemoveTask;
        private Button buttonEditTask;
        private GroupBox groupBoxProgressTask;
        private RadioButton radioButtonCompleted;
        private RadioButton radioButtonInProgress;
        private RadioButton radioButtonQueue;
        private TextBox textBoxAssigneeTask;
        private Label labelAssigneeTask;
    }
}