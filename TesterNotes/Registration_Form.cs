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

		Methods md = new Methods();

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
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}

		private void labelRF_login_Click(object sender, EventArgs e)
		{
			Login_Form logform = new Login_Form();
			logform.Show();
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
			md.metodMouseEnter(textBoxRF_pib, "ПІБ");
		}

		private void textBoxRF_pib_MouseLeave(object sender, EventArgs e)
		{
			md.metodMouseLeave(textBoxRF_pib, "ПІБ");
		}

		private void textBoxRF_mail_MouseEnter(object sender, EventArgs e)
		{
			md.metodMouseEnter(textBoxRF_mail, "Email");
		}

		private void textBoxRF_mail_MouseLeave(object sender, EventArgs e)
		{
			md.metodMouseLeave(textBoxRF_mail, "Email");
		}

		private void textBoxRF_login_MouseEnter(object sender, EventArgs e)
		{
			md.metodMouseEnter(textBoxRF_login, "Логін");
		}

		private void textBoxRF_login_MouseLeave(object sender, EventArgs e)
		{
			md.metodMouseLeave(textBoxRF_login, "Логін");
		}

		private void textBoxRF_password_MouseEnter(object sender, EventArgs e)
		{
			md.metodMouseEnter(textBoxRF_password, "Пароль");
		}

		private void textBoxRF_password_MouseLeave(object sender, EventArgs e)
		{
			md.metodMouseLeave(textBoxRF_password, "Пароль");
		}

		private void textBoxRF_repassword_MouseEnter(object sender, EventArgs e)
		{
			md.metodMouseEnter(textBoxRF_repassword, "Пароль");
		}

		private void textBoxRF_repassword_MouseLeave(object sender, EventArgs e)
		{
			md.metodMouseLeave(textBoxRF_repassword, "Пароль");
		}

		private void buttonRF_register_Click(object sender, EventArgs e)
		{
			DataBase database = new DataBase();

			MySqlCommand command = new MySqlCommand("INSERT INTO `users`" +
				"(`pib_user`, `mail_user`, `login_user`, `password_user`) " +
				"VALUES (@pib, @mail, @login, @pass)", database.getConnection());

			command.Parameters.Add("@pib", MySqlDbType.VarChar).Value = textBoxRF_pib.Text;
			command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = textBoxRF_mail.Text;
			command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBoxRF_login.Text;
			command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxRF_password.Text;


			database.openConnection();

			if (ChekTextBoxes())
			{
				MessageBox.Show("Для початку введіть свою інформацію");
			}
			else if (chekUserName())
			{
				MessageBox.Show("Такий логін вже існує");
			}
			else if (chekUserEmail())
			{
				MessageBox.Show("Користувач з такою поштою вже існує");
			}
			else if (textBoxRF_password.Text != textBoxRF_repassword.Text)
			{
				MessageBox.Show("Пароль повторений невірно");
			}
			else if (!CheckEmail(textBoxRF_mail.Text))
			{
				MessageBox.Show("Хибний e-mail адрес ");
			}
			else
			{
				if (command.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Обліковий запис створено");
					Info.UserName = textBoxRF_login.Text;
					this.Hide();
					Main_Form mainForm = new Main_Form();
					mainForm.Show();
					mainForm.showProjects();
				}
				else
				{
					MessageBox.Show("Помилка створення облікового запису");
				}
			}
			database.closeConnection();
		}

			 
		public Boolean chekUserName()
	   {
		   DataBase database = new DataBase();

		   String username = textBoxRF_login.Text;

		   DataTable table = new DataTable();
		   MySqlDataAdapter adapter = new MySqlDataAdapter();
		   MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login_user` = @login", database.getConnection());

		   command.Parameters.Add("@login", MySqlDbType.VarChar).Value = username;

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


		public Boolean chekUserEmail()
		{
			DataBase database = new DataBase();

			String mail = textBoxRF_mail.Text;

			DataTable table = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `mail_user` = @mail", database.getConnection());

			command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;

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
		// Перевірка полів на введення нових даних

		public Boolean ChekTextBoxes()
	   {
		   String pib = textBoxRF_pib.Text;
		   String mail = textBoxRF_mail.Text;
		   String login = textBoxRF_login.Text;
		   String pass = textBoxRF_password.Text;
		   String repass = textBoxRF_repassword.Text;

		   if(pib.Equals("ПІБ") || mail.Equals("Mail") || login.Equals("Логін") ||
			   pass.Equals("Пароль") || repass.Equals("Пароль") || pib.Equals("") || mail.Equals("") || login.Equals("") ||
			   pass.Equals("") || repass.Equals(""))
		   {
			   return true;
		   }
		   else
		   {
			   return false;
		   }
	   }

	   // Перевірка на правильність email

	   public Boolean CheckEmail(string email)
	   {
		   try
		   {
			   var address = new System.Net.Mail.MailAddress(email);
			   return address.Address == email;
		   }
		   catch
		   {
			   return false;
		   }
	   }


    }
}
