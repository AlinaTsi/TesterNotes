
namespace TesterNotes
{
	partial class Login_Form
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.buttonLF_login = new System.Windows.Forms.Button();
            this.textBoxLF_login = new System.Windows.Forms.TextBox();
            this.textBoxLF_password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLF_registration = new System.Windows.Forms.Label();
            this.labelLF_close = new System.Windows.Forms.Label();
            this.label_toRePass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLF_login
            // 
            this.buttonLF_login.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonLF_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLF_login.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLF_login.ForeColor = System.Drawing.Color.White;
            this.buttonLF_login.Location = new System.Drawing.Point(21, 141);
            this.buttonLF_login.Name = "buttonLF_login";
            this.buttonLF_login.Size = new System.Drawing.Size(262, 35);
            this.buttonLF_login.TabIndex = 0;
            this.buttonLF_login.Text = "Увійти";
            this.buttonLF_login.UseVisualStyleBackColor = false;
            this.buttonLF_login.Click += new System.EventHandler(this.buttonLF_login_Click);
            // 
            // textBoxLF_login
            // 
            this.textBoxLF_login.BackColor = System.Drawing.Color.White;
            this.textBoxLF_login.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLF_login.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLF_login.Location = new System.Drawing.Point(57, 57);
            this.textBoxLF_login.Name = "textBoxLF_login";
            this.textBoxLF_login.Size = new System.Drawing.Size(226, 26);
            this.textBoxLF_login.TabIndex = 1;
            // 
            // textBoxLF_password
            // 
            this.textBoxLF_password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLF_password.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLF_password.Location = new System.Drawing.Point(57, 93);
            this.textBoxLF_password.Name = "textBoxLF_password";
            this.textBoxLF_password.PasswordChar = '●';
            this.textBoxLF_password.Size = new System.Drawing.Size(226, 26);
            this.textBoxLF_password.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(96, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Авторизація";
            // 
            // labelLF_registration
            // 
            this.labelLF_registration.AutoSize = true;
            this.labelLF_registration.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLF_registration.ForeColor = System.Drawing.Color.Gray;
            this.labelLF_registration.Location = new System.Drawing.Point(18, 206);
            this.labelLF_registration.Name = "labelLF_registration";
            this.labelLF_registration.Size = new System.Drawing.Size(72, 13);
            this.labelLF_registration.TabIndex = 7;
            this.labelLF_registration.Text = "Реєстрація";
            this.labelLF_registration.Click += new System.EventHandler(this.labelLF_registration_Click);
            this.labelLF_registration.MouseEnter += new System.EventHandler(this.labelLF_registration_MouseEnter);
            this.labelLF_registration.MouseLeave += new System.EventHandler(this.labelLF_registration_MouseLeave);
            // 
            // labelLF_close
            // 
            this.labelLF_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLF_close.AutoSize = true;
            this.labelLF_close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLF_close.ForeColor = System.Drawing.Color.Gray;
            this.labelLF_close.Location = new System.Drawing.Point(242, 192);
            this.labelLF_close.Name = "labelLF_close";
            this.labelLF_close.Size = new System.Drawing.Size(41, 14);
            this.labelLF_close.TabIndex = 4;
            this.labelLF_close.Text = "Вихід";
            this.labelLF_close.Click += new System.EventHandler(this.labelLF_close_Click);
            this.labelLF_close.MouseEnter += new System.EventHandler(this.labelLF_close_MouseEnter);
            this.labelLF_close.MouseLeave += new System.EventHandler(this.labelLF_close_MouseLeave);
            // 
            // label_toRePass
            // 
            this.label_toRePass.AutoSize = true;
            this.label_toRePass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_toRePass.ForeColor = System.Drawing.Color.Gray;
            this.label_toRePass.Location = new System.Drawing.Point(18, 193);
            this.label_toRePass.Name = "label_toRePass";
            this.label_toRePass.Size = new System.Drawing.Size(131, 13);
            this.label_toRePass.TabIndex = 8;
            this.label_toRePass.Text = "Відновлення паролю";
            this.label_toRePass.Click += new System.EventHandler(this.label_toRePass_Click);
            this.label_toRePass.MouseEnter += new System.EventHandler(this.label_toRePass_MouseEnter);
            this.label_toRePass.MouseLeave += new System.EventHandler(this.label_toRePass_MouseLeave);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 228);
            this.ControlBox = false;
            this.Controls.Add(this.label_toRePass);
            this.Controls.Add(this.labelLF_close);
            this.Controls.Add(this.labelLF_registration);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxLF_password);
            this.Controls.Add(this.textBoxLF_login);
            this.Controls.Add(this.buttonLF_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_Form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLF_login;
		private System.Windows.Forms.TextBox textBoxLF_login;
		private System.Windows.Forms.TextBox textBoxLF_password;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelLF_registration;
		private System.Windows.Forms.Label labelLF_close;
        private System.Windows.Forms.Label label_toRePass;
    }
}

