namespace TesterNotes
{
    partial class AddTask_Form
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
            this.components = new System.ComponentModel.Container();
            this.labelATF_close = new System.Windows.Forms.Label();
            this.buttonATF_addtask = new System.Windows.Forms.Button();
            this.textBoxATF_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxATF_description = new System.Windows.Forms.TextBox();
            this.comboBoxATF_project = new System.Windows.Forms.ComboBox();
            this.comboBoxATF_status = new System.Windows.Forms.ComboBox();
            this.dateTP_ATF_end = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxATF_priorityTask = new System.Windows.Forms.ComboBox();
            this.toolTipPriority = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelATF_close
            // 
            this.labelATF_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelATF_close.AutoSize = true;
            this.labelATF_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelATF_close.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelATF_close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelATF_close.Location = new System.Drawing.Point(293, 308);
            this.labelATF_close.Name = "labelATF_close";
            this.labelATF_close.Size = new System.Drawing.Size(45, 14);
            this.labelATF_close.TabIndex = 2;
            this.labelATF_close.Text = "Назад";
            this.labelATF_close.Click += new System.EventHandler(this.labelATF_close_Click);
            this.labelATF_close.MouseEnter += new System.EventHandler(this.labelATF_close_MouseEnter);
            this.labelATF_close.MouseLeave += new System.EventHandler(this.labelATF_close_MouseLeave);
            // 
            // buttonATF_addtask
            // 
            this.buttonATF_addtask.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonATF_addtask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonATF_addtask.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonATF_addtask.ForeColor = System.Drawing.Color.White;
            this.buttonATF_addtask.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonATF_addtask.Location = new System.Drawing.Point(20, 258);
            this.buttonATF_addtask.Name = "buttonATF_addtask";
            this.buttonATF_addtask.Size = new System.Drawing.Size(318, 35);
            this.buttonATF_addtask.TabIndex = 3;
            this.buttonATF_addtask.Text = "Додати";
            this.buttonATF_addtask.UseVisualStyleBackColor = false;
            this.buttonATF_addtask.Click += new System.EventHandler(this.buttonATF_addtask_Click);
            // 
            // textBoxATF_name
            // 
            this.textBoxATF_name.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxATF_name.ForeColor = System.Drawing.Color.Gray;
            this.textBoxATF_name.Location = new System.Drawing.Point(21, 52);
            this.textBoxATF_name.Multiline = true;
            this.textBoxATF_name.Name = "textBoxATF_name";
            this.textBoxATF_name.Size = new System.Drawing.Size(317, 42);
            this.textBoxATF_name.TabIndex = 4;
            this.textBoxATF_name.Text = "Назва*";
            this.textBoxATF_name.MouseEnter += new System.EventHandler(this.textBoxATF_name_MouseEnter);
            this.textBoxATF_name.MouseLeave += new System.EventHandler(this.textBoxATF_name_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(116, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Нове завдання";
            // 
            // textBoxATF_description
            // 
            this.textBoxATF_description.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxATF_description.ForeColor = System.Drawing.Color.Gray;
            this.textBoxATF_description.Location = new System.Drawing.Point(21, 103);
            this.textBoxATF_description.Multiline = true;
            this.textBoxATF_description.Name = "textBoxATF_description";
            this.textBoxATF_description.Size = new System.Drawing.Size(317, 59);
            this.textBoxATF_description.TabIndex = 7;
            this.textBoxATF_description.Text = "Опис";
            this.textBoxATF_description.MouseEnter += new System.EventHandler(this.textBoxATF_description_MouseEnter);
            this.textBoxATF_description.MouseLeave += new System.EventHandler(this.textBoxATF_description_MouseLeave);
            // 
            // comboBoxATF_project
            // 
            this.comboBoxATF_project.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxATF_project.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxATF_project.FormattingEnabled = true;
            this.comboBoxATF_project.Location = new System.Drawing.Point(21, 170);
            this.comboBoxATF_project.Name = "comboBoxATF_project";
            this.comboBoxATF_project.Size = new System.Drawing.Size(155, 24);
            this.comboBoxATF_project.TabIndex = 10;
            this.comboBoxATF_project.Text = "Проект*";
            // 
            // comboBoxATF_status
            // 
            this.comboBoxATF_status.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxATF_status.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxATF_status.FormattingEnabled = true;
            this.comboBoxATF_status.Items.AddRange(new object[] {
            "виконано",
            "відкрито"});
            this.comboBoxATF_status.Location = new System.Drawing.Point(182, 170);
            this.comboBoxATF_status.Name = "comboBoxATF_status";
            this.comboBoxATF_status.Size = new System.Drawing.Size(156, 24);
            this.comboBoxATF_status.TabIndex = 11;
            this.comboBoxATF_status.Text = "Статус";
            // 
            // dateTP_ATF_end
            // 
            this.dateTP_ATF_end.CalendarForeColor = System.Drawing.Color.Gray;
            this.dateTP_ATF_end.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dateTP_ATF_end.CustomFormat = "yyyy.MM.dd";
            this.dateTP_ATF_end.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTP_ATF_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTP_ATF_end.Location = new System.Drawing.Point(20, 217);
            this.dateTP_ATF_end.Name = "dateTP_ATF_end";
            this.dateTP_ATF_end.Size = new System.Drawing.Size(156, 23);
            this.dateTP_ATF_end.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(17, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Крайній термін";
            // 
            // comboBoxATF_priorityTask
            // 
            this.comboBoxATF_priorityTask.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxATF_priorityTask.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxATF_priorityTask.FormattingEnabled = true;
            this.comboBoxATF_priorityTask.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxATF_priorityTask.Location = new System.Drawing.Point(182, 216);
            this.comboBoxATF_priorityTask.Name = "comboBoxATF_priorityTask";
            this.comboBoxATF_priorityTask.Size = new System.Drawing.Size(156, 24);
            this.comboBoxATF_priorityTask.TabIndex = 16;
            this.comboBoxATF_priorityTask.Text = "Пріоритетність";
            this.comboBoxATF_priorityTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboBoxATF_priorityTask_MouseMove);
            // 
            // AddTask_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 335);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxATF_priorityTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTP_ATF_end);
            this.Controls.Add(this.comboBoxATF_status);
            this.Controls.Add(this.comboBoxATF_project);
            this.Controls.Add(this.textBoxATF_description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxATF_name);
            this.Controls.Add(this.buttonATF_addtask);
            this.Controls.Add(this.labelATF_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTask_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddTask_Form_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelATF_close;
        private System.Windows.Forms.Button buttonATF_addtask;
        private System.Windows.Forms.TextBox textBoxATF_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxATF_description;
        private System.Windows.Forms.ComboBox comboBoxATF_project;
        private System.Windows.Forms.ComboBox comboBoxATF_status;
        private System.Windows.Forms.DateTimePicker dateTP_ATF_end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxATF_priorityTask;
        private System.Windows.Forms.ToolTip toolTipPriority;
    }
}