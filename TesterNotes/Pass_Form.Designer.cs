namespace TesterNotes
{
    partial class Pass_Form
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
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.buttonPF_sendMail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_mail = new System.Windows.Forms.Panel();
            this.panel_code = new System.Windows.Forms.Panel();
            this.labelTimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.button_check = new System.Windows.Forms.Button();
            this.panel_pass = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_repassword = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_changePass = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label_tologin = new System.Windows.Forms.Label();
            this.timerForCode = new System.Windows.Forms.Timer(this.components);
            this.panel_mail.SuspendLayout();
            this.panel_code.SuspendLayout();
            this.panel_pass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_mail
            // 
            this.textBox_mail.BackColor = System.Drawing.Color.White;
            this.textBox_mail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_mail.ForeColor = System.Drawing.Color.Gray;
            this.textBox_mail.Location = new System.Drawing.Point(14, 36);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(210, 26);
            this.textBox_mail.TabIndex = 2;
            // 
            // buttonPF_sendMail
            // 
            this.buttonPF_sendMail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonPF_sendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPF_sendMail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPF_sendMail.ForeColor = System.Drawing.Color.White;
            this.buttonPF_sendMail.Location = new System.Drawing.Point(12, 81);
            this.buttonPF_sendMail.Name = "buttonPF_sendMail";
            this.buttonPF_sendMail.Size = new System.Drawing.Size(212, 35);
            this.buttonPF_sendMail.TabIndex = 3;
            this.buttonPF_sendMail.Text = "Відправити код";
            this.buttonPF_sendMail.UseVisualStyleBackColor = false;
            this.buttonPF_sendMail.Click += new System.EventHandler(this.buttonPF_sendMail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(56, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введіть свій e-mail";
            // 
            // panel_mail
            // 
            this.panel_mail.Controls.Add(this.buttonPF_sendMail);
            this.panel_mail.Controls.Add(this.label1);
            this.panel_mail.Controls.Add(this.textBox_mail);
            this.panel_mail.Location = new System.Drawing.Point(0, 17);
            this.panel_mail.Name = "panel_mail";
            this.panel_mail.Size = new System.Drawing.Size(239, 128);
            this.panel_mail.TabIndex = 7;
            // 
            // panel_code
            // 
            this.panel_code.Controls.Add(this.labelTimer);
            this.panel_code.Controls.Add(this.label2);
            this.panel_code.Controls.Add(this.textBox_code);
            this.panel_code.Controls.Add(this.button_check);
            this.panel_code.Location = new System.Drawing.Point(3, 12);
            this.panel_code.Name = "panel_code";
            this.panel_code.Size = new System.Drawing.Size(233, 131);
            this.panel_code.TabIndex = 8;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.ForeColor = System.Drawing.Color.DimGray;
            this.labelTimer.Location = new System.Drawing.Point(101, 35);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(31, 14);
            this.labelTimer.TabIndex = 6;
            this.labelTimer.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(23, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введіть код підтвердження";
            // 
            // textBox_code
            // 
            this.textBox_code.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_code.ForeColor = System.Drawing.Color.Gray;
            this.textBox_code.Location = new System.Drawing.Point(9, 61);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(210, 26);
            this.textBox_code.TabIndex = 4;
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_check.ForeColor = System.Drawing.Color.White;
            this.button_check.Location = new System.Drawing.Point(9, 93);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(210, 35);
            this.button_check.TabIndex = 3;
            this.button_check.Text = "Підтвердити";
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // panel_pass
            // 
            this.panel_pass.Controls.Add(this.label3);
            this.panel_pass.Controls.Add(this.textBox_repassword);
            this.panel_pass.Controls.Add(this.textBox_password);
            this.panel_pass.Controls.Add(this.button_changePass);
            this.panel_pass.Location = new System.Drawing.Point(12, 6);
            this.panel_pass.Name = "panel_pass";
            this.panel_pass.Size = new System.Drawing.Size(219, 150);
            this.panel_pass.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(32, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Створіть новий пароль";
            // 
            // textBox_repassword
            // 
            this.textBox_repassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_repassword.ForeColor = System.Drawing.Color.Gray;
            this.textBox_repassword.Location = new System.Drawing.Point(3, 67);
            this.textBox_repassword.Name = "textBox_repassword";
            this.textBox_repassword.PasswordChar = '●';
            this.textBox_repassword.Size = new System.Drawing.Size(210, 26);
            this.textBox_repassword.TabIndex = 11;
            this.textBox_repassword.Text = "Пароль";
            this.textBox_repassword.MouseEnter += new System.EventHandler(this.textBox_repassword_MouseEnter);
            this.textBox_repassword.MouseLeave += new System.EventHandler(this.textBox_repassword_MouseLeave);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.ForeColor = System.Drawing.Color.Gray;
            this.textBox_password.Location = new System.Drawing.Point(3, 35);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '●';
            this.textBox_password.Size = new System.Drawing.Size(210, 26);
            this.textBox_password.TabIndex = 10;
            this.textBox_password.Text = "Пароль";
            this.textBox_password.MouseEnter += new System.EventHandler(this.textBox_password_MouseEnter);
            this.textBox_password.MouseLeave += new System.EventHandler(this.textBox_password_MouseLeave);
            // 
            // button_changePass
            // 
            this.button_changePass.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_changePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_changePass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_changePass.ForeColor = System.Drawing.Color.White;
            this.button_changePass.Location = new System.Drawing.Point(3, 110);
            this.button_changePass.Name = "button_changePass";
            this.button_changePass.Size = new System.Drawing.Size(210, 35);
            this.button_changePass.TabIndex = 9;
            this.button_changePass.Text = "Змінити";
            this.button_changePass.UseVisualStyleBackColor = false;
            this.button_changePass.Click += new System.EventHandler(this.button_changePass_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label_tologin
            // 
            this.label_tologin.AutoSize = true;
            this.label_tologin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tologin.ForeColor = System.Drawing.Color.Gray;
            this.label_tologin.Location = new System.Drawing.Point(183, 159);
            this.label_tologin.Name = "label_tologin";
            this.label_tologin.Size = new System.Drawing.Size(44, 13);
            this.label_tologin.TabIndex = 10;
            this.label_tologin.Text = "Назад";
            this.label_tologin.Click += new System.EventHandler(this.label_tologin_Click);
            this.label_tologin.MouseEnter += new System.EventHandler(this.label_tologin_MouseEnter);
            this.label_tologin.MouseLeave += new System.EventHandler(this.label_tologin_MouseLeave);
            // 
            // Pass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 181);
            this.ControlBox = false;
            this.Controls.Add(this.label_tologin);
            this.Controls.Add(this.panel_code);
            this.Controls.Add(this.panel_mail);
            this.Controls.Add(this.panel_pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pass_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Pass_Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pass_Form_MouseDown);
            this.panel_mail.ResumeLayout(false);
            this.panel_mail.PerformLayout();
            this.panel_code.ResumeLayout(false);
            this.panel_code.PerformLayout();
            this.panel_pass.ResumeLayout(false);
            this.panel_pass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Button buttonPF_sendMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_mail;
        private System.Windows.Forms.Panel panel_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Panel panel_pass;
        private System.Windows.Forms.TextBox textBox_repassword;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_changePass;
        private System.Windows.Forms.Label label3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label_tologin;
        private System.Windows.Forms.Timer timerForCode;
        private System.Windows.Forms.Label labelTimer;
    }
}