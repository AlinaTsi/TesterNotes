namespace TesterNotes
{
    partial class SaveReport_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_pdf = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_save = new System.Windows.Forms.Button();
            this.label_close = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreatePDF = new System.Windows.Forms.Button();
            this.checkBoxProject = new System.Windows.Forms.CheckBox();
            this.checkBoxNotes = new System.Windows.Forms.CheckBox();
            this.checkBoxExpected = new System.Windows.Forms.CheckBox();
            this.checkBoxActual = new System.Windows.Forms.CheckBox();
            this.checkBoxSteps = new System.Windows.Forms.CheckBox();
            this.checkBoxEnvironment = new System.Windows.Forms.CheckBox();
            this.checkBoxPlatform = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pdf)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_pdf
            // 
            this.dataGridView_pdf.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_pdf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_pdf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_pdf.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_pdf.GridColor = System.Drawing.Color.White;
            this.dataGridView_pdf.Location = new System.Drawing.Point(25, 64);
            this.dataGridView_pdf.Name = "dataGridView_pdf";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_pdf.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_pdf.RowHeadersVisible = false;
            this.dataGridView_pdf.Size = new System.Drawing.Size(376, 204);
            this.dataGridView_pdf.TabIndex = 0;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_save.Location = new System.Drawing.Point(25, 19);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(156, 36);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Зберегти";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_close
            // 
            this.label_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_close.AutoSize = true;
            this.label_close.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label_close.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_close.Location = new System.Drawing.Point(547, 1);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(30, 27);
            this.label_close.TabIndex = 4;
            this.label_close.Text = "×";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBox_name.ForeColor = System.Drawing.Color.Gray;
            this.textBox_name.Location = new System.Drawing.Point(203, 31);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(198, 24);
            this.textBox_name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(200, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 39;
            this.label3.Text = "Назва файлу";
            // 
            // buttonCreatePDF
            // 
            this.buttonCreatePDF.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCreatePDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreatePDF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.buttonCreatePDF.ForeColor = System.Drawing.Color.White;
            this.buttonCreatePDF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCreatePDF.Location = new System.Drawing.Point(407, 232);
            this.buttonCreatePDF.Name = "buttonCreatePDF";
            this.buttonCreatePDF.Size = new System.Drawing.Size(149, 36);
            this.buttonCreatePDF.TabIndex = 40;
            this.buttonCreatePDF.Text = "Сформувати";
            this.buttonCreatePDF.UseVisualStyleBackColor = false;
            this.buttonCreatePDF.Click += new System.EventHandler(this.buttonCreatePDF_Click);
            // 
            // checkBoxProject
            // 
            this.checkBoxProject.AutoSize = true;
            this.checkBoxProject.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxProject.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxProject.Location = new System.Drawing.Point(407, 64);
            this.checkBoxProject.Name = "checkBoxProject";
            this.checkBoxProject.Size = new System.Drawing.Size(67, 18);
            this.checkBoxProject.TabIndex = 41;
            this.checkBoxProject.Text = "Проект";
            this.checkBoxProject.UseVisualStyleBackColor = true;
            this.checkBoxProject.Click += new System.EventHandler(this.checkBoxProject_Click);
            // 
            // checkBoxNotes
            // 
            this.checkBoxNotes.AutoSize = true;
            this.checkBoxNotes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxNotes.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxNotes.Location = new System.Drawing.Point(407, 208);
            this.checkBoxNotes.Name = "checkBoxNotes";
            this.checkBoxNotes.Size = new System.Drawing.Size(72, 18);
            this.checkBoxNotes.TabIndex = 42;
            this.checkBoxNotes.Text = "Нотатки";
            this.checkBoxNotes.UseVisualStyleBackColor = true;
            this.checkBoxNotes.Click += new System.EventHandler(this.checkBoxNotes_Click);
            // 
            // checkBoxExpected
            // 
            this.checkBoxExpected.AutoSize = true;
            this.checkBoxExpected.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxExpected.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxExpected.Location = new System.Drawing.Point(407, 184);
            this.checkBoxExpected.Name = "checkBoxExpected";
            this.checkBoxExpected.Size = new System.Drawing.Size(149, 18);
            this.checkBoxExpected.TabIndex = 43;
            this.checkBoxExpected.Text = "Очікуваний результат";
            this.checkBoxExpected.UseVisualStyleBackColor = true;
            this.checkBoxExpected.Click += new System.EventHandler(this.checkBoxExpected_Click);
            // 
            // checkBoxActual
            // 
            this.checkBoxActual.AutoSize = true;
            this.checkBoxActual.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxActual.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxActual.Location = new System.Drawing.Point(407, 160);
            this.checkBoxActual.Name = "checkBoxActual";
            this.checkBoxActual.Size = new System.Drawing.Size(149, 18);
            this.checkBoxActual.TabIndex = 44;
            this.checkBoxActual.Text = "Фактичний результат";
            this.checkBoxActual.UseVisualStyleBackColor = true;
            this.checkBoxActual.Click += new System.EventHandler(this.checkBoxActual_Click);
            // 
            // checkBoxSteps
            // 
            this.checkBoxSteps.AutoSize = true;
            this.checkBoxSteps.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSteps.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxSteps.Location = new System.Drawing.Point(407, 136);
            this.checkBoxSteps.Name = "checkBoxSteps";
            this.checkBoxSteps.Size = new System.Drawing.Size(133, 18);
            this.checkBoxSteps.TabIndex = 45;
            this.checkBoxSteps.Text = "Кроки відтворення";
            this.checkBoxSteps.UseVisualStyleBackColor = true;
            this.checkBoxSteps.Click += new System.EventHandler(this.checkBoxSteps_Click);
            // 
            // checkBoxEnvironment
            // 
            this.checkBoxEnvironment.AutoSize = true;
            this.checkBoxEnvironment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxEnvironment.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxEnvironment.Location = new System.Drawing.Point(407, 112);
            this.checkBoxEnvironment.Name = "checkBoxEnvironment";
            this.checkBoxEnvironment.Size = new System.Drawing.Size(97, 18);
            this.checkBoxEnvironment.TabIndex = 46;
            this.checkBoxEnvironment.Text = "Середовище";
            this.checkBoxEnvironment.UseVisualStyleBackColor = true;
            this.checkBoxEnvironment.Click += new System.EventHandler(this.checkBoxEnvironment_Click);
            // 
            // checkBoxPlatform
            // 
            this.checkBoxPlatform.AutoSize = true;
            this.checkBoxPlatform.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxPlatform.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxPlatform.Location = new System.Drawing.Point(407, 88);
            this.checkBoxPlatform.Name = "checkBoxPlatform";
            this.checkBoxPlatform.Size = new System.Drawing.Size(91, 18);
            this.checkBoxPlatform.TabIndex = 47;
            this.checkBoxPlatform.Text = "Платформа";
            this.checkBoxPlatform.UseVisualStyleBackColor = true;
            this.checkBoxPlatform.Click += new System.EventHandler(this.checkBoxPlatform_Click);
            // 
            // SaveReport_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 293);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxPlatform);
            this.Controls.Add(this.checkBoxEnvironment);
            this.Controls.Add(this.checkBoxSteps);
            this.Controls.Add(this.checkBoxActual);
            this.Controls.Add(this.checkBoxExpected);
            this.Controls.Add(this.checkBoxNotes);
            this.Controls.Add(this.checkBoxProject);
            this.Controls.Add(this.buttonCreatePDF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dataGridView_pdf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveReport_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveReport_Form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_pdf;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreatePDF;
        private System.Windows.Forms.CheckBox checkBoxProject;
        private System.Windows.Forms.CheckBox checkBoxNotes;
        private System.Windows.Forms.CheckBox checkBoxExpected;
        private System.Windows.Forms.CheckBox checkBoxActual;
        private System.Windows.Forms.CheckBox checkBoxSteps;
        private System.Windows.Forms.CheckBox checkBoxEnvironment;
        private System.Windows.Forms.CheckBox checkBoxPlatform;
    }
}