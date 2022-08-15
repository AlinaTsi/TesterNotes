
namespace TesterNotes
{
	partial class Registration_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRF_pib = new System.Windows.Forms.TextBox();
            this.buttonRF_register = new System.Windows.Forms.Button();
            this.labelRF_close = new System.Windows.Forms.Label();
            this.labelRF_login = new System.Windows.Forms.Label();
            this.textBoxRF_mail = new System.Windows.Forms.TextBox();
            this.textBoxRF_login = new System.Windows.Forms.TextBox();
            this.textBoxRF_repassword = new System.Windows.Forms.TextBox();
            this.textBoxRF_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(120, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Реєстрація";
            // 
            // textBoxRF_pib
            // 
            this.textBoxRF_pib.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRF_pib.ForeColor = System.Drawing.Color.Gray;
            this.textBoxRF_pib.Location = new System.Drawing.Point(24, 54);
            this.textBoxRF_pib.Name = "textBoxRF_pib";
            this.textBoxRF_pib.Size = new System.Drawing.Size(288, 26);
            this.textBoxRF_pib.TabIndex = 1;
            this.textBoxRF_pib.Text = "ПІБ*";
            this.textBoxRF_pib.Click += new System.EventHandler(this.textBoxRF_pib_Click);
            this.textBoxRF_pib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRF_pib_KeyPress);
            this.textBoxRF_pib.MouseEnter += new System.EventHandler(this.textBoxRF_pib_MouseEnter);
            this.textBoxRF_pib.MouseLeave += new System.EventHandler(this.textBoxRF_pib_MouseLeave);
            // 
            // buttonRF_register
            // 
            this.buttonRF_register.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonRF_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRF_register.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRF_register.ForeColor = System.Drawing.Color.White;
            this.buttonRF_register.Location = new System.Drawing.Point(24, 205);
            this.buttonRF_register.Name = "buttonRF_register";
            this.buttonRF_register.Size = new System.Drawing.Size(288, 35);
            this.buttonRF_register.TabIndex = 2;
            this.buttonRF_register.Text = "Зареєструватись";
            this.buttonRF_register.UseVisualStyleBackColor = false;
            this.buttonRF_register.Click += new System.EventHandler(this.buttonRF_register_Click);
            // 
            // labelRF_close
            // 
            this.labelRF_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRF_close.AutoSize = true;
            this.labelRF_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRF_close.ForeColor = System.Drawing.Color.Gray;
            this.labelRF_close.Location = new System.Drawing.Point(267, 252);
            this.labelRF_close.Name = "labelRF_close";
            this.labelRF_close.Size = new System.Drawing.Size(41, 14);
            this.labelRF_close.TabIndex = 3;
            this.labelRF_close.Text = "Вихід";
            this.labelRF_close.Click += new System.EventHandler(this.labelRF_close_Click);
            this.labelRF_close.MouseEnter += new System.EventHandler(this.labelRF_close_MouseEnter);
            this.labelRF_close.MouseLeave += new System.EventHandler(this.labelRF_close_MouseLeave);
            // 
            // labelRF_login
            // 
            this.labelRF_login.AutoSize = true;
            this.labelRF_login.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRF_login.ForeColor = System.Drawing.Color.Gray;
            this.labelRF_login.Location = new System.Drawing.Point(21, 253);
            this.labelRF_login.Name = "labelRF_login";
            this.labelRF_login.Size = new System.Drawing.Size(80, 13);
            this.labelRF_login.TabIndex = 4;
            this.labelRF_login.Text = "Авторизація";
            this.labelRF_login.Click += new System.EventHandler(this.labelRF_login_Click);
            this.labelRF_login.MouseEnter += new System.EventHandler(this.labelRF_login_MouseEnter);
            this.labelRF_login.MouseLeave += new System.EventHandler(this.labelRF_login_MouseLeave);
            // 
            // textBoxRF_mail
            // 
            this.textBoxRF_mail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRF_mail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxRF_mail.Location = new System.Drawing.Point(24, 126);
            this.textBoxRF_mail.Name = "textBoxRF_mail";
            this.textBoxRF_mail.Size = new System.Drawing.Size(288, 26);
            this.textBoxRF_mail.TabIndex = 5;
            this.textBoxRF_mail.Text = "Email*";
            this.textBoxRF_mail.Click += new System.EventHandler(this.textBoxRF_mail_Click);
            this.textBoxRF_mail.MouseEnter += new System.EventHandler(this.textBoxRF_mail_MouseEnter);
            this.textBoxRF_mail.MouseLeave += new System.EventHandler(this.textBoxRF_mail_MouseLeave);
            // 
            // textBoxRF_login
            // 
            this.textBoxRF_login.BackColor = System.Drawing.Color.White;
            this.textBoxRF_login.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRF_login.ForeColor = System.Drawing.Color.Gray;
            this.textBoxRF_login.Location = new System.Drawing.Point(24, 90);
            this.textBoxRF_login.Name = "textBoxRF_login";
            this.textBoxRF_login.Size = new System.Drawing.Size(288, 26);
            this.textBoxRF_login.TabIndex = 6;
            this.textBoxRF_login.Text = "Логін*";
            this.textBoxRF_login.Click += new System.EventHandler(this.textBoxRF_login_Click);
            this.textBoxRF_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRF_login_KeyPress);
            this.textBoxRF_login.MouseEnter += new System.EventHandler(this.textBoxRF_login_MouseEnter);
            this.textBoxRF_login.MouseLeave += new System.EventHandler(this.textBoxRF_login_MouseLeave);
            // 
            // textBoxRF_repassword
            // 
            this.textBoxRF_repassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRF_repassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxRF_repassword.Location = new System.Drawing.Point(177, 161);
            this.textBoxRF_repassword.Name = "textBoxRF_repassword";
            this.textBoxRF_repassword.PasswordChar = '●';
            this.textBoxRF_repassword.Size = new System.Drawing.Size(135, 26);
            this.textBoxRF_repassword.TabIndex = 8;
            this.textBoxRF_repassword.Text = "Пароль";
            this.textBoxRF_repassword.Click += new System.EventHandler(this.textBoxRF_repassword_Click);
            this.textBoxRF_repassword.MouseEnter += new System.EventHandler(this.textBoxRF_repassword_MouseEnter);
            this.textBoxRF_repassword.MouseLeave += new System.EventHandler(this.textBoxRF_repassword_MouseLeave);
            // 
            // textBoxRF_password
            // 
            this.textBoxRF_password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRF_password.ForeColor = System.Drawing.Color.Gray;
            this.textBoxRF_password.Location = new System.Drawing.Point(24, 161);
            this.textBoxRF_password.Name = "textBoxRF_password";
            this.textBoxRF_password.PasswordChar = '●';
            this.textBoxRF_password.Size = new System.Drawing.Size(135, 26);
            this.textBoxRF_password.TabIndex = 7;
            this.textBoxRF_password.Text = "Пароль";
            this.textBoxRF_password.Click += new System.EventHandler(this.textBoxRF_password_Click);
            this.textBoxRF_password.MouseEnter += new System.EventHandler(this.textBoxRF_password_MouseEnter);
            this.textBoxRF_password.MouseLeave += new System.EventHandler(this.textBoxRF_password_MouseLeave);
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 275);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxRF_repassword);
            this.Controls.Add(this.textBoxRF_password);
            this.Controls.Add(this.textBoxRF_login);
            this.Controls.Add(this.textBoxRF_mail);
            this.Controls.Add(this.labelRF_login);
            this.Controls.Add(this.labelRF_close);
            this.Controls.Add(this.buttonRF_register);
            this.Controls.Add(this.textBoxRF_pib);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registration_Form_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxRF_pib;
		private System.Windows.Forms.Button buttonRF_register;
		private System.Windows.Forms.Label labelRF_close;
		private System.Windows.Forms.Label labelRF_login;
		private System.Windows.Forms.TextBox textBoxRF_mail;
		private System.Windows.Forms.TextBox textBoxRF_login;
		private System.Windows.Forms.TextBox textBoxRF_repassword;
		private System.Windows.Forms.TextBox textBoxRF_password;
	}
}