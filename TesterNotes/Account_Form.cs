using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TesterNotes
{
	public partial class Account_Form : Form
	{
		public Account_Form()
		{
			InitializeComponent();
			if(Info.forAccount == 1)
            {
				account();
				countTasks("SELECT COUNT(id_project) FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "')", "COUNT(id_project)", labelCountProjects);
				countTasks("SELECT COUNT(`tasks`.id_task) FROM `tasks`, `projects`, `users` " +
					"WHERE `tasks`.id_project = `projects`.id_project " +
					"AND `projects`.id_user = `users`.id_user " +
					"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "')", "COUNT(`tasks`.id_task)", labelCountTasks);
				countTasks("SELECT COUNT(`tasks`.id_task) FROM `tasks`, `projects`, `users` " +
					"WHERE `tasks`.id_project = `projects`.id_project " +
					"AND `projects`.id_user = `users`.id_user " +
					"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "') " +
					"AND `tasks`.status_task = 'відкрито' AND `tasks`.enddate_task < '" + DateTime.Today.ToString("yyyy-MM-dd") + "' ", "COUNT(`tasks`.id_task)", labelCtStitched);
				countTasks("SELECT COUNT(`tasks`.id_task) FROM `tasks`, `projects`, `users` " +
					"WHERE `tasks`.id_project = `projects`.id_project " +
					"AND `projects`.id_user = `users`.id_user " +
					"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "') " +
					"AND `tasks`.status_task = 'відкрито'", "COUNT(`tasks`.id_task)", labelCtOpen);
				countTasks("SELECT COUNT(`tasks`.id_task) FROM `tasks`, `projects`, `users` " +
					"WHERE `tasks`.id_project = `projects`.id_project " +
					"AND `projects`.id_user = `users`.id_user " +
					"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "') " +
					"AND `tasks`.status_task = 'виконано'", "COUNT(`tasks`.id_task)", labelCtClose);
				countTasks("SELECT COUNT(`reports`.id_bug) FROM `reports`, `projects` " +
					"WHERE `reports`.id_project = `projects`.id_project AND " +
					"`projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "')", "COUNT(`reports`.id_bug)", labelCountReports);

			}
		}

		Methods methods = new Methods();

		private void button_changepassword_Click(object sender, EventArgs e)
		{
			Info.formNumber = 123;
			Pass_Form passForm = new Pass_Form();
			passForm.Show();
			this.Close();
		}

		private void button_exit_Click(object sender, EventArgs e)
		{
			methods.exit(this);
		}

		private void button_updateuserdata_Click(object sender, EventArgs e)
		{
			try
			{
				DataBase database = new DataBase();

				MySqlCommand command = new MySqlCommand("UPDATE `users` SET " +
					"pib_user = @pib, mail_user = @mail, login_user = @login " +
					"WHERE login_user = '" + Info.userName + "'", database.getConnection());

				command.Parameters.Add("@pib", MySqlDbType.VarChar).Value = textBoxMF_username.Text;
				command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = textBoxMF_useremail.Text;
				command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBoxMF_userlogin.Text;

				database.openConnection();

				if (textBoxMF_useremail.Text.Equals("") && textBoxMF_userlogin.Text.Equals(""))
				{
					MessageBox.Show("Введіть логін та email.");
				}
				else if (textBoxMF_useremail.Text.Equals(""))
				{
					MessageBox.Show("Введіть логін.");
				}
				else if (textBoxMF_userlogin.Text.Equals(""))
				{
					MessageBox.Show("Введіть email.");
				}
				else if (chekData(textBoxMF_userlogin, "@login_user", "SELECT * FROM `users` WHERE `login_user` = @login_user") && (Info.userName != textBoxMF_userlogin.Text))
				{
					MessageBox.Show("Користувач з таким логіном вже існує.");
				}
				else if (chekData(textBoxMF_useremail, "@mail_user", "SELECT * FROM `users` WHERE `mail_user` = @mail_user") && (Info.userMail != textBoxMF_useremail.Text))
				{
					MessageBox.Show("Користувач з такою поштою вже існує.");
				}
				else
				{
					try
					{
						if (command.ExecuteNonQuery() == 1)
						{
							MessageBox.Show("Дані змінено успішно.");
							Info.userName = textBoxMF_userlogin.Text;
						}
					}
					catch (Exception exception)
					{
						MessageBox.Show("Помилка: " + exception.Message);
					}
				}
				database.closeConnection();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Не вдалось підключитись до бази даних. Перевірте підключення до Інтернету, налаштування проксі-сервера та брандмауера. " + exception.Message);
			}
			
		}

		public void account()
		{
			string user = Info.userName;

			DataBase database = new DataBase();
			string selectQuery = "SELECT * FROM users WHERE login_user = '" + user + "'";

			database.openConnection();

			MySqlCommand command = new MySqlCommand(selectQuery, database.getConnection());
			MySqlDataReader reader = command.ExecuteReader();

			if (reader.Read())
			{
				string name = reader.GetString("pib_user");
				string email = reader.GetString("mail_user");
				string login = reader.GetString("login_user");

				textBoxMF_username.Text = name;
				textBoxMF_useremail.Text = email;
				textBoxMF_userlogin.Text = login;
			}
			else
			{
				MessageBox.Show("Даних не знайдено.");
			}

			database.closeConnection();
		}

		private void labelAF_close_Click(object sender, EventArgs e)
		{
			Main_Form mainForm = new Main_Form();
			mainForm.Show();
			mainForm.showProjects();
			this.Close();
		}

		public void countTasks(string selectQueryCount, string field, Label label)
		{
			DataBase database = new DataBase();

			database.openConnection();

			MySqlCommand command = new MySqlCommand(selectQueryCount, database.getConnection());
			MySqlDataReader reader = command.ExecuteReader();

			try
			{
				if (reader.Read())
				{
					label.Text = reader.GetString(field);
				}
				else
				{
					MessageBox.Show("Даних не знайдено.");
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Помилка: " + exception.Message);
			}

			database.closeConnection();
		}

		private void button_deleteaccount_Click(object sender, EventArgs e)
		{
			DataBase database = new DataBase();

			MySqlCommand command = new MySqlCommand("DELETE FROM users WHERE login_user = '" + Info.userName + "'", database.getConnection());

			database.openConnection();

			try
			{
				DialogResult dialog = MessageBox.Show("Ви дійсно хочете видалити аккаунт зі всіма даними?", "DELETE", MessageBoxButtons.YesNo);

				if (dialog == DialogResult.Yes)
				{
					if (command.ExecuteNonQuery() == 1)
					{
						Login_Form logform = new Login_Form();
						logform.Show();
						this.Close();
					}
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Помилка: " + exception.Message);
			}

			database.closeConnection();
		}

		private void labelAF_close_MouseEnter(object sender, EventArgs e)
		{
			labelAF_close.ForeColor = Color.DarkSlateGray;
		}

		private void labelAF_close_MouseLeave(object sender, EventArgs e)
		{
			labelAF_close.ForeColor = Color.Gray;
		}

		private void Account_Form_MouseDown(object sender, MouseEventArgs e)
		{
			base.Capture = false;
			Message message = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref message);
		}

		public Boolean chekData(TextBox textBox, string field, string query)
		{
			DataBase database = new DataBase();

			DataTable table = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			MySqlCommand command = new MySqlCommand(query, database.getConnection());

			command.Parameters.Add(field, MySqlDbType.VarChar).Value = textBox.Text;

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

        private void textBoxMF_username_KeyPress(object sender, KeyPressEventArgs e)
        {
			char letter = e.KeyChar;
			if ((letter < 'А' || letter > 'я') && letter != ' ' && letter != 'і' && letter != 'ї'
				&& letter != 'І' && letter != 'ї' && letter != '\b')
				e.Handled = true;
		}

        private void textBoxMF_userlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
			char letter = e.KeyChar;
			if ((letter < 'А' || letter > 'я') && (letter < 'A' || letter > 'z') && (letter < '0' || letter > '9')
				&& letter != ' ' && letter != '\b' && letter != 'і' && letter != 'ї' && letter != 'І' && letter != 'ї')
				e.Handled = true;
		}
    }
}