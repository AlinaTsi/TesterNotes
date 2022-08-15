using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TesterNotes
{
	public partial class Login_Form : Form
	{
		public Login_Form()
		{
			InitializeComponent();
		}

		Methods methods = new Methods();
		String mail;
		private void Login_Form_MouseDown(object sender, MouseEventArgs e)
		{
			base.Capture = false;
			Message message = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref message);
		}

		private void labelLF_close_MouseEnter(object sender, EventArgs e)
		{
			labelLF_close.ForeColor = Color.IndianRed;
		}

		private void labelLF_close_MouseLeave(object sender, EventArgs e)
		{
			labelLF_close.ForeColor = Color.Gray;
		}

		private void labelLF_close_Click(object sender, EventArgs e)
		{
			methods.exit(this);
		}

		private void labelLF_registration_Click(object sender, EventArgs e)
		{
			Registration_Form registrationForm = new Registration_Form();
			registrationForm.Show();
			this.Hide();
		}

		private void labelLF_registration_MouseEnter(object sender, EventArgs e)
		{
			labelLF_registration.ForeColor = Color.DarkSlateGray;
		}

		private void labelLF_registration_MouseLeave(object sender, EventArgs e)
		{
			labelLF_registration.ForeColor = Color.Gray;
		}

		private void buttonLF_login_Click(object sender, EventArgs e)
		{
			try
			{
				DataBase database = new DataBase();

				String userName = textBoxLF_login.Text;
				String password = textBoxLF_password.Text;

				DataTable table = new DataTable();
				MySqlDataAdapter adapter = new MySqlDataAdapter();
				MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login_user` = @usrn and `password_user` = @pass", database.getConnection());

				command.Parameters.Add("@usrn", MySqlDbType.VarChar).Value = userName;
				command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = methods.decryptText(password);

				adapter.SelectCommand = command;

				adapter.Fill(table);

				if (userName.Trim().Equals("") && password.Trim().Equals(""))
				{
					MessageBox.Show("Введіть логін та пароль.");
				}
				else if (userName.Trim().Equals(""))
				{
					MessageBox.Show("Введіть логін.");
				}
				else if (password.Trim().Equals(""))
				{
					MessageBox.Show("Введіть пароль.");
				}

				else if (table.Rows.Count > 0)
				{
					try
					{
						Info.userName = userName;
						Info.userMail = ReturnMail();
						Info.forAccount = 1;
						this.Hide();
						Main_Form mainForm = new Main_Form();
						mainForm.Show();
						mainForm.showProjects();

					}
					catch (Exception exception)
					{
						MessageBox.Show("Помилка: " + exception.Message);
					}
				}
				else
				{
					MessageBox.Show("Неправильний логін або пароль.");
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Не вдалось підключитись до бази даних. Перевірте підключення до Інтернету, налаштування проксі-сервера та брандмауера. " + exception.Message);
			}
		}

		private void label_toRePass_Click(object sender, EventArgs e)
		{
			Info.formNumber = 321;

			Pass_Form passForm = new Pass_Form();
			passForm.Show();
			this.Hide();
		}

		private void label_toRePass_MouseEnter(object sender, EventArgs e)
		{
			label_toRePass.ForeColor = Color.DarkSlateGray;
		}

		private void label_toRePass_MouseLeave(object sender, EventArgs e)
		{
			label_toRePass.ForeColor = Color.Gray;
		}

		public string ReturnMail()
		{

				DataBase database = new DataBase();


				string selectQuery = "SELECT * FROM users WHERE login_user = '" + textBoxLF_login.Text + "'";

				database.openConnection();

				MySqlCommand command = new MySqlCommand(selectQuery, database.getConnection());
				MySqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					mail = reader.GetString("mail_user");
				}
				else
				{
					MessageBox.Show("Помилка читання email.");
				}
				return mail;
			
		}
	}
}
