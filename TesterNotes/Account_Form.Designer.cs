namespace TesterNotes
{
    partial class Account_Form
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
            this.button_exit = new System.Windows.Forms.Button();
            this.button_updateuserdata = new System.Windows.Forms.Button();
            this.button_deleteaccount = new System.Windows.Forms.Button();
            this.button_changepassword = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxMF_userlogin = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxMF_useremail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxMF_username = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.labelAF_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCountProjects = new System.Windows.Forms.Label();
            this.labelCountTasks = new System.Windows.Forms.Label();
            this.labelCountReports = new System.Windows.Forms.Label();
            this.labelCtOpen = new System.Windows.Forms.Label();
            this.labelCtClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCtStitched = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(24, 228);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(240, 30);
            this.button_exit.TabIndex = 56;
            this.button_exit.Text = "Вийти з облікового запису";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_updateuserdata
            // 
            this.button_updateuserdata.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_updateuserdata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_updateuserdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updateuserdata.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_updateuserdata.ForeColor = System.Drawing.Color.White;
            this.button_updateuserdata.Location = new System.Drawing.Point(24, 183);
            this.button_updateuserdata.Name = "button_updateuserdata";
            this.button_updateuserdata.Size = new System.Drawing.Size(240, 30);
            this.button_updateuserdata.TabIndex = 55;
            this.button_updateuserdata.Text = "Оновити дані";
            this.button_updateuserdata.UseVisualStyleBackColor = false;
            this.button_updateuserdata.Click += new System.EventHandler(this.button_updateuserdata_Click);
            // 
            // button_deleteaccount
            // 
            this.button_deleteaccount.BackColor = System.Drawing.Color.Firebrick;
            this.button_deleteaccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_deleteaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deleteaccount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deleteaccount.ForeColor = System.Drawing.Color.White;
            this.button_deleteaccount.Location = new System.Drawing.Point(292, 228);
            this.button_deleteaccount.Name = "button_deleteaccount";
            this.button_deleteaccount.Size = new System.Drawing.Size(182, 30);
            this.button_deleteaccount.TabIndex = 54;
            this.button_deleteaccount.Text = "Видалити аккаунт";
            this.button_deleteaccount.UseVisualStyleBackColor = false;
            this.button_deleteaccount.Click += new System.EventHandler(this.button_deleteaccount_Click);
            // 
            // button_changepassword
            // 
            this.button_changepassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_changepassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_changepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_changepassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_changepassword.ForeColor = System.Drawing.Color.White;
            this.button_changepassword.Location = new System.Drawing.Point(292, 183);
            this.button_changepassword.Name = "button_changepassword";
            this.button_changepassword.Size = new System.Drawing.Size(182, 30);
            this.button_changepassword.TabIndex = 53;
            this.button_changepassword.Text = "Змінити пароль";
            this.button_changepassword.UseVisualStyleBackColor = false;
            this.button_changepassword.Click += new System.EventHandler(this.button_changepassword_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(25, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 14);
            this.label20.TabIndex = 52;
            this.label20.Text = "Логін";
            // 
            // textBoxMF_userlogin
            // 
            this.textBoxMF_userlogin.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxMF_userlogin.ForeColor = System.Drawing.Color.Gray;
            this.textBoxMF_userlogin.Location = new System.Drawing.Point(24, 87);
            this.textBoxMF_userlogin.Multiline = true;
            this.textBoxMF_userlogin.Name = "textBoxMF_userlogin";
            this.textBoxMF_userlogin.Size = new System.Drawing.Size(240, 26);
            this.textBoxMF_userlogin.TabIndex = 51;
            this.textBoxMF_userlogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMF_userlogin_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(25, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 14);
            this.label19.TabIndex = 50;
            this.label19.Text = "Email";
            // 
            // textBoxMF_useremail
            // 
            this.textBoxMF_useremail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxMF_useremail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxMF_useremail.Location = new System.Drawing.Point(24, 135);
            this.textBoxMF_useremail.Multiline = true;
            this.textBoxMF_useremail.Name = "textBoxMF_useremail";
            this.textBoxMF_useremail.Size = new System.Drawing.Size(240, 26);
            this.textBoxMF_useremail.TabIndex = 49;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(25, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 14);
            this.label18.TabIndex = 48;
            this.label18.Text = "ПІБ";
            // 
            // textBoxMF_username
            // 
            this.textBoxMF_username.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBoxMF_username.ForeColor = System.Drawing.Color.Gray;
            this.textBoxMF_username.Location = new System.Drawing.Point(24, 39);
            this.textBoxMF_username.Multiline = true;
            this.textBoxMF_username.Name = "textBoxMF_username";
            this.textBoxMF_username.Size = new System.Drawing.Size(240, 26);
            this.textBoxMF_username.TabIndex = 47;
            this.textBoxMF_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMF_username_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label25.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label25.Location = new System.Drawing.Point(316, 140);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 18);
            this.label25.TabIndex = 59;
            this.label25.Text = "Звіти";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label24.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label24.Location = new System.Drawing.Point(25, 33);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 18);
            this.label24.TabIndex = 58;
            this.label24.Text = "Завдання";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label23.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label23.Location = new System.Drawing.Point(24, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 18);
            this.label23.TabIndex = 57;
            this.label23.Text = "Проекти";
            // 
            // labelAF_close
            // 
            this.labelAF_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAF_close.AutoSize = true;
            this.labelAF_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAF_close.ForeColor = System.Drawing.Color.Gray;
            this.labelAF_close.Location = new System.Drawing.Point(429, 274);
            this.labelAF_close.Name = "labelAF_close";
            this.labelAF_close.Size = new System.Drawing.Size(45, 14);
            this.labelAF_close.TabIndex = 64;
            this.labelAF_close.Text = "Назад";
            this.labelAF_close.Click += new System.EventHandler(this.labelAF_close_Click);
            this.labelAF_close.MouseEnter += new System.EventHandler(this.labelAF_close_MouseEnter);
            this.labelAF_close.MouseLeave += new System.EventHandler(this.labelAF_close_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(38, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "Відкрито";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(38, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "Виконано";
            // 
            // labelCountProjects
            // 
            this.labelCountProjects.AutoSize = true;
            this.labelCountProjects.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCountProjects.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountProjects.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelCountProjects.Location = new System.Drawing.Point(135, 9);
            this.labelCountProjects.Name = "labelCountProjects";
            this.labelCountProjects.Size = new System.Drawing.Size(18, 18);
            this.labelCountProjects.TabIndex = 67;
            this.labelCountProjects.Text = "0";
            // 
            // labelCountTasks
            // 
            this.labelCountTasks.AutoSize = true;
            this.labelCountTasks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCountTasks.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountTasks.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelCountTasks.Location = new System.Drawing.Point(135, 33);
            this.labelCountTasks.Name = "labelCountTasks";
            this.labelCountTasks.Size = new System.Drawing.Size(18, 18);
            this.labelCountTasks.TabIndex = 68;
            this.labelCountTasks.Text = "0";
            // 
            // labelCountReports
            // 
            this.labelCountReports.AutoSize = true;
            this.labelCountReports.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCountReports.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountReports.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelCountReports.Location = new System.Drawing.Point(427, 140);
            this.labelCountReports.Name = "labelCountReports";
            this.labelCountReports.Size = new System.Drawing.Size(18, 18);
            this.labelCountReports.TabIndex = 69;
            this.labelCountReports.Text = "0";
            // 
            // labelCtOpen
            // 
            this.labelCtOpen.AutoSize = true;
            this.labelCtOpen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCtOpen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCtOpen.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelCtOpen.Location = new System.Drawing.Point(136, 56);
            this.labelCtOpen.Name = "labelCtOpen";
            this.labelCtOpen.Size = new System.Drawing.Size(15, 16);
            this.labelCtOpen.TabIndex = 70;
            this.labelCtOpen.Text = "0";
            // 
            // labelCtClose
            // 
            this.labelCtClose.AutoSize = true;
            this.labelCtClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCtClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCtClose.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelCtClose.Location = new System.Drawing.Point(136, 76);
            this.labelCtClose.Name = "labelCtClose";
            this.labelCtClose.Size = new System.Drawing.Size(15, 16);
            this.labelCtClose.TabIndex = 71;
            this.labelCtClose.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.labelCtStitched);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelCtClose);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.labelCtOpen);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelCountTasks);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelCountProjects);
            this.panel1.Location = new System.Drawing.Point(292, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 139);
            this.panel1.TabIndex = 72;
            // 
            // labelCtStitched
            // 
            this.labelCtStitched.AutoSize = true;
            this.labelCtStitched.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCtStitched.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCtStitched.ForeColor = System.Drawing.Color.Firebrick;
            this.labelCtStitched.Location = new System.Drawing.Point(136, 96);
            this.labelCtStitched.Name = "labelCtStitched";
            this.labelCtStitched.Size = new System.Drawing.Size(15, 16);
            this.labelCtStitched.TabIndex = 73;
            this.labelCtStitched.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(38, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "Прострочено";
            // 
            // Account_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 293);
            this.ControlBox = false;
            this.Controls.Add(this.labelCountReports);
            this.Controls.Add(this.labelAF_close);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_updateuserdata);
            this.Controls.Add(this.button_deleteaccount);
            this.Controls.Add(this.button_changepassword);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBoxMF_userlogin);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxMF_useremail);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxMF_username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Account_Form";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Account_Form_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_updateuserdata;
        private System.Windows.Forms.Button button_deleteaccount;
        private System.Windows.Forms.Button button_changepassword;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxMF_userlogin;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxMF_useremail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxMF_username;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelAF_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCountProjects;
        private System.Windows.Forms.Label labelCountTasks;
        private System.Windows.Forms.Label labelCountReports;
        private System.Windows.Forms.Label labelCtOpen;
        private System.Windows.Forms.Label labelCtClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCtStitched;
        private System.Windows.Forms.Label label4;
    }
}