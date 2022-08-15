namespace TesterNotes
{
    partial class AddReport_Form
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
            this.labelARF_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxARF_project = new System.Windows.Forms.ComboBox();
            this.textBoxARF_summary = new System.Windows.Forms.TextBox();
            this.textBoxARF_steps = new System.Windows.Forms.TextBox();
            this.textBoxARF_actual = new System.Windows.Forms.TextBox();
            this.textBoxARF_expected = new System.Windows.Forms.TextBox();
            this.buttonARF_addtask = new System.Windows.Forms.Button();
            this.textBoxARF_notes = new System.Windows.Forms.TextBox();
            this.textBoxARF_envir = new System.Windows.Forms.TextBox();
            this.textBoxARF_platf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelARF_close
            // 
            this.labelARF_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelARF_close.AutoSize = true;
            this.labelARF_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelARF_close.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelARF_close.Location = new System.Drawing.Point(377, 371);
            this.labelARF_close.Name = "labelARF_close";
            this.labelARF_close.Size = new System.Drawing.Size(45, 14);
            this.labelARF_close.TabIndex = 1;
            this.labelARF_close.Text = "Назад";
            this.labelARF_close.Click += new System.EventHandler(this.labelARF_close_Click);
            this.labelARF_close.MouseEnter += new System.EventHandler(this.labelARF_close_MouseEnter);
            this.labelARF_close.MouseLeave += new System.EventHandler(this.labelARF_close_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(141, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Новий баг-репорт";
            // 
            // comboBoxARF_project
            // 
            this.comboBoxARF_project.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxARF_project.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxARF_project.FormattingEnabled = true;
            this.comboBoxARF_project.Location = new System.Drawing.Point(22, 293);
            this.comboBoxARF_project.Name = "comboBoxARF_project";
            this.comboBoxARF_project.Size = new System.Drawing.Size(197, 24);
            this.comboBoxARF_project.TabIndex = 11;
            this.comboBoxARF_project.Text = "Проект*";
            // 
            // textBoxARF_summary
            // 
            this.textBoxARF_summary.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxARF_summary.ForeColor = System.Drawing.Color.Gray;
            this.textBoxARF_summary.Location = new System.Drawing.Point(22, 60);
            this.textBoxARF_summary.Multiline = true;
            this.textBoxARF_summary.Name = "textBoxARF_summary";
            this.textBoxARF_summary.Size = new System.Drawing.Size(400, 40);
            this.textBoxARF_summary.TabIndex = 12;
            this.textBoxARF_summary.Text = "Назва*";
            this.textBoxARF_summary.MouseEnter += new System.EventHandler(this.textBoxARF_summary_MouseEnter);
            this.textBoxARF_summary.MouseLeave += new System.EventHandler(this.textBoxARF_summary_MouseLeave);
            // 
            // textBoxARF_steps
            // 
            this.textBoxARF_steps.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxARF_steps.ForeColor = System.Drawing.Color.Gray;
            this.textBoxARF_steps.Location = new System.Drawing.Point(22, 136);
            this.textBoxARF_steps.Multiline = true;
            this.textBoxARF_steps.Name = "textBoxARF_steps";
            this.textBoxARF_steps.Size = new System.Drawing.Size(400, 80);
            this.textBoxARF_steps.TabIndex = 15;
            this.textBoxARF_steps.Text = "Кроки відтворення";
            this.textBoxARF_steps.MouseEnter += new System.EventHandler(this.textBoxARF_steps_MouseEnter);
            this.textBoxARF_steps.MouseLeave += new System.EventHandler(this.textBoxARF_steps_MouseLeave);
            // 
            // textBoxARF_actual
            // 
            this.textBoxARF_actual.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxARF_actual.ForeColor = System.Drawing.Color.Gray;
            this.textBoxARF_actual.Location = new System.Drawing.Point(22, 222);
            this.textBoxARF_actual.Multiline = true;
            this.textBoxARF_actual.Name = "textBoxARF_actual";
            this.textBoxARF_actual.Size = new System.Drawing.Size(197, 65);
            this.textBoxARF_actual.TabIndex = 16;
            this.textBoxARF_actual.Text = "Фактичний результат";
            this.textBoxARF_actual.MouseEnter += new System.EventHandler(this.textBoxARF_actual_MouseEnter);
            this.textBoxARF_actual.MouseLeave += new System.EventHandler(this.textBoxARF_actual_MouseLeave);
            // 
            // textBoxARF_expected
            // 
            this.textBoxARF_expected.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxARF_expected.ForeColor = System.Drawing.Color.Gray;
            this.textBoxARF_expected.Location = new System.Drawing.Point(225, 222);
            this.textBoxARF_expected.Multiline = true;
            this.textBoxARF_expected.Name = "textBoxARF_expected";
            this.textBoxARF_expected.Size = new System.Drawing.Size(197, 65);
            this.textBoxARF_expected.TabIndex = 17;
            this.textBoxARF_expected.Text = "Очікуваний результат";
            this.textBoxARF_expected.MouseEnter += new System.EventHandler(this.textBoxARF_expected_MouseEnter);
            this.textBoxARF_expected.MouseLeave += new System.EventHandler(this.textBoxARF_expected_MouseLeave);
            // 
            // buttonARF_addtask
            // 
            this.buttonARF_addtask.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonARF_addtask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonARF_addtask.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonARF_addtask.ForeColor = System.Drawing.Color.White;
            this.buttonARF_addtask.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonARF_addtask.Location = new System.Drawing.Point(22, 323);
            this.buttonARF_addtask.Name = "buttonARF_addtask";
            this.buttonARF_addtask.Size = new System.Drawing.Size(197, 36);
            this.buttonARF_addtask.TabIndex = 18;
            this.buttonARF_addtask.Text = "Додати";
            this.buttonARF_addtask.UseVisualStyleBackColor = false;
            this.buttonARF_addtask.Click += new System.EventHandler(this.buttonARF_addtask_Click);
            // 
            // textBoxARF_notes
            // 
            this.textBoxARF_notes.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxARF_notes.ForeColor = System.Drawing.Color.Gray;
            this.textBoxARF_notes.Location = new System.Drawing.Point(225, 293);
            this.textBoxARF_notes.Multiline = true;
            this.textBoxARF_notes.Name = "textBoxARF_notes";
            this.textBoxARF_notes.Size = new System.Drawing.Size(197, 66);
            this.textBoxARF_notes.TabIndex = 20;
            this.textBoxARF_notes.Text = "Нотатки";
            this.textBoxARF_notes.MouseEnter += new System.EventHandler(this.textBoxARF_notes_MouseEnter);
            this.textBoxARF_notes.MouseLeave += new System.EventHandler(this.textBoxARF_notes_MouseLeave);
            // 
            // textBoxARF_envir
            // 
            this.textBoxARF_envir.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxARF_envir.ForeColor = System.Drawing.Color.Gray;
            this.textBoxARF_envir.Location = new System.Drawing.Point(22, 106);
            this.textBoxARF_envir.Name = "textBoxARF_envir";
            this.textBoxARF_envir.Size = new System.Drawing.Size(197, 24);
            this.textBoxARF_envir.TabIndex = 22;
            this.textBoxARF_envir.Text = "Середовище";
            this.textBoxARF_envir.MouseEnter += new System.EventHandler(this.textBoxARF_envir_MouseEnter);
            this.textBoxARF_envir.MouseLeave += new System.EventHandler(this.textBoxARF_envir_MouseLeave);
            // 
            // textBoxARF_platf
            // 
            this.textBoxARF_platf.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxARF_platf.ForeColor = System.Drawing.Color.Gray;
            this.textBoxARF_platf.Location = new System.Drawing.Point(225, 106);
            this.textBoxARF_platf.Name = "textBoxARF_platf";
            this.textBoxARF_platf.Size = new System.Drawing.Size(197, 24);
            this.textBoxARF_platf.TabIndex = 23;
            this.textBoxARF_platf.Text = "Платформа";
            this.textBoxARF_platf.MouseEnter += new System.EventHandler(this.textBoxARF_platf_MouseEnter);
            this.textBoxARF_platf.MouseLeave += new System.EventHandler(this.textBoxARF_platf_MouseLeave);
            // 
            // AddReport_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 402);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxARF_platf);
            this.Controls.Add(this.textBoxARF_envir);
            this.Controls.Add(this.textBoxARF_notes);
            this.Controls.Add(this.buttonARF_addtask);
            this.Controls.Add(this.textBoxARF_expected);
            this.Controls.Add(this.textBoxARF_actual);
            this.Controls.Add(this.textBoxARF_steps);
            this.Controls.Add(this.textBoxARF_summary);
            this.Controls.Add(this.comboBoxARF_project);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelARF_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddReport_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddReport_Form_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelARF_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxARF_project;
        private System.Windows.Forms.TextBox textBoxARF_summary;
        private System.Windows.Forms.TextBox textBoxARF_steps;
        private System.Windows.Forms.TextBox textBoxARF_actual;
        private System.Windows.Forms.TextBox textBoxARF_expected;
        private System.Windows.Forms.Button buttonARF_addtask;
        private System.Windows.Forms.TextBox textBoxARF_notes;
        private System.Windows.Forms.TextBox textBoxARF_envir;
        private System.Windows.Forms.TextBox textBoxARF_platf;
    }
}