using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TesterNotes
{
	public partial class Registration_Form : Form
	{
		public Registration_Form()
		{
			InitializeComponent();
		}

		Methods methodsForm = new Methods();
		
		private void labelRF_close_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Ви дійсно хочете вийти?") == DialogResult.OK)
			{
				this.Close();
				Application.Exit();
			}
		}

		private void labelRF_close_MouseEnter(object sender, EventArgs e)
		{
			labelRF_close.ForeColor = Color.IndianRed;
		}

		private void labelRF_close_MouseLeave(object sender, EventArgs e)
		{
			labelRF_close.ForeColor = Color.Gray;
		}

		private void Registration_Form_MouseDown(object sender, MouseEventArgs e)
		{
			base.Capture = false;
			Message message = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref message);
		}

		private void labelRF_login_Click(object sender, EventArgs e)
		{
			Login_Form loginForm = new Login_Form();
			loginForm.Show();
			this.Hide();
		}

		private void labelRF_login_MouseEnter(object sender, EventArgs e)
		{
			labelRF_login.ForeColor = Color.DarkSlateGray;
		}

		private void labelRF_login_MouseLeave(object sender, EventArgs e)
		{
			labelRF_login.ForeColor = Color.Gray;
		}

		private void textBoxRF_pib_MouseEnter(object sender, EventArgs e)
		{
			methodsForm.metodMouseEnter(textBoxRF_pib, "ПІБ*");
		}

		private void textBoxRF_pib_MouseLeave(object sender, EventArgs e)
		{
			methodsForm.metodMouseLeave(textBoxRF_pib, "ПІБ*");
		}

		private void textBoxRF_mail_MouseEnter(object sender, EventArgs e)
		{
			methodsForm.metodMouseEnter(textBoxRF_mail, "Email*");
		}

		private void textBoxRF_mail_MouseLeave(object sender, EventArgs e)
		{
			methodsForm.metodMouseLeave(textBoxRF_mail, "Email*");
		}

		private void textBoxRF_login_MouseEnter(object sender, EventArgs e)
		{
			methodsForm.metodMouseEnter(textBoxRF_login, "Логін*");
		}

		private void textBoxRF_login_MouseLeave(object sender, EventArgs e)
		{
			methodsForm.metodMouseLeave(textBoxRF_login, "Логін*");
		}

		private void textBoxRF_password_MouseEnter(object sender, EventArgs e)
		{
			methodsForm.metodMouseEnter(textBoxRF_password, "Пароль");
		}

		private void textBoxRF_password_MouseLeave(object sender, EventArgs e)
		{
			methodsForm.metodMouseLeave(textBoxRF_password, "Пароль");
		}

		private void textBoxRF_repassword_MouseEnter(object sender, EventArgs e)
		{
			methodsForm.metodMouseEnter(textBoxRF_repassword, "Пароль");
		}

		private void textBoxRF_repassword_MouseLeave(object sender, EventArgs e)
		{
			methodsForm.metodMouseLeave(textBoxRF_repassword, "Пароль");
		}

		private void buttonRF_register_Click(object sender, EventArgs e)
		{
			try 
			{ 
			DataBase database = new DataBase();

			MySqlCommand command = new MySqlCommand("INSERT INTO `users`" +
				"(`pib_user`, `mail_user`, `login_user`, `password_user`) " +
				"VALUES (@pib, @mail, @login, @pass)", database.getConnection());

			command.Parameters.Add("@pib", MySqlDbType.VarChar).Value = textBoxRF_pib.Text;
			command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = textBoxRF_mail.Text;
			command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBoxRF_login.Text;
			command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = methodsForm.encryptText(textBoxRF_password.Text);


			database.openConnection();

			if (textBoxRF_pib.Text.Equals("ПІБ*") || textBoxRF_mail.Text.Equals("Email*") || 
				textBoxRF_login.Text.Equals("Логін*") || textBoxRF_password.Text.Equals("Пароль") || 
				textBoxRF_repassword.Text.Equals("Пароль") || textBoxRF_pib.Text.Equals("") ||
				textBoxRF_mail.Text.Equals("") || textBoxRF_login.Text.Equals("Логін*") || textBoxRF_password.Text.Equals("Пароль") ||
				textBoxRF_repassword.Equals("") || textBoxRF_password.Text.Equals("") || textBoxRF_repassword.Text.Equals(""))
			{
				chekTextBoxes();
			}
			else if (chekUserName())
			{
				MessageBox.Show("Користувач з таким логіном вже існує.");
			}
			else if (methodsForm.chekUserEmail(textBoxRF_mail, "SELECT * FROM `users` WHERE `mail_user` = @mail", "@mail"))
			{
				MessageBox.Show("Користувач з такою поштою вже існує.");
			}
			else if (!methodsForm.checkEmail(textBoxRF_mail.Text))
			{
				MessageBox.Show("Хибний e-mail адрес.");
			}
			else if (textBoxRF_password.TextLength < 8)
            {
				MessageBox.Show("Пароль має бути не менше 8 символів.");
			}
			else if (textBoxRF_password.Text != textBoxRF_repassword.Text)
			{
				MessageBox.Show("Пароль повторений невірно.");
			}
			
			else
			{
				if (command.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Обліковий запис створено.");
					Info.userName = textBoxRF_login.Text;
					Info.userMail = textBoxRF_mail.Text;
					Info.forAccount = 1;
					this.Hide();

					Main_Form mainForm = new Main_Form();
					mainForm.Show();
					mainForm.showProjects();
				}
				else
				{
					MessageBox.Show("Помилка створення облікового запису.");
				}
			}
			database.closeConnection();

			}
			catch (Exception exception)
			{
				MessageBox.Show("Не вдалось підключитись до бази даних. Перевірте підключення до Інтернету, налаштування проксі-сервера та брандмауера. " + exception.Message);
			}
		}

			 
		public Boolean chekUserName()
	   {
		   DataBase database = new DataBase();

		   String userName = textBoxRF_login.Text;

		   DataTable table = new DataTable();
		   MySqlDataAdapter adapter = new MySqlDataAdapter();
		   MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login_user` = @login", database.getConnection());

		   command.Parameters.Add("@login", MySqlDbType.VarChar).Value = userName;

		   adapter.SelectCommand = command;

		   adapter.Fill(table);

		   if (table.Rows.Count > 0)
		   {
			   return true;
		   }
		   else
		   {
			   return false;
		   }

	   }


		public void chekTextBoxes()
	   {
		   String pib = textBoxRF_pib.Text;
		   String mail = textBoxRF_mail.Text;
		   String login = textBoxRF_login.Text;
		   String password = textBoxRF_password.Text;
		   String repassword = textBoxRF_repassword.Text;

		   if(pib.Equals("ПІБ*") || pib.Equals(""))
		   {
				textBoxRF_pib.BackColor = Color.MistyRose;
		   }
		   if (mail.Equals("Email*") || mail.Equals(""))
		   {
			   textBoxRF_mail.BackColor = Color.MistyRose;
			}
			if (login.Equals("Логін*") || login.Equals(""))
			{
				textBoxRF_login.BackColor = Color.MistyRose;
			}
			if (password.Equals("Пароль") || password.Equals(""))
			{
				textBoxRF_password.BackColor = Color.MistyRose;
			}
			if (repassword.Equals("Пароль") || repassword.Equals(""))
			{
				textBoxRF_repassword.BackColor = Color.MistyRose;
			}
		}

        private void textBoxRF_pib_Click(object sender, EventArgs e)
        {
			textBoxRF_pib.BackColor = Color.White;
        }

        private void textBoxRF_login_Click(object sender, EventArgs e)
        {
			textBoxRF_login.BackColor = Color.White;
		}

        private void textBoxRF_mail_Click(object sender, EventArgs e)
        {
			textBoxRF_mail.BackColor = Color.White;
		}

        private void textBoxRF_password_Click(object sender, EventArgs e)
        {
			textBoxRF_password.BackColor = Color.White;
		}

        private void textBoxRF_repassword_Click(object sender, EventArgs e)
        {
			textBoxRF_repassword.BackColor = Color.White;
		}

        private void textBoxRF_pib_KeyPress(object sender, KeyPressEventArgs e)
        {
			char letter = e.KeyChar;
			if ((letter < 'А' || letter > 'я') && letter != ' ' && letter != 'і' && letter != 'ї'
				&& letter != 'І' && letter != 'ї' && letter != '\b')
			e.Handled = true;
		}

        private void textBoxRF_login_KeyPress(object sender, KeyPressEventArgs e)
        {
			char letter = e.KeyChar;
			if ((letter < 'А' || letter > 'я') && (letter < 'A' || letter > 'z') && (letter < '0' || letter > '9')
				&& letter != ' ' && letter != '\b' && letter != 'і' && letter != 'ї' && letter != 'І' && letter != 'ї')
				e.Handled = true;
		}
    }
}
