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

		Methods md = new Methods();

		private void Login_Form_MouseDown(object sender, MouseEventArgs e)
		{
			base.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
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
			md.exit(this);
		}

		private void labelLF_registration_Click(object sender, EventArgs e)
		{
			Registration_Form regform = new Registration_Form();
			regform.Show();
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
			DataBase database = new DataBase();

			String username = textBoxLF_login.Text;
			String password = textBoxLF_password.Text;

			DataTable table = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login_user` = @usrn and `password_user` = @pass", database.getConnection());

			command.Parameters.Add("@usrn", MySqlDbType.VarChar).Value = username;
			command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

			adapter.SelectCommand = command;

			adapter.Fill(table);

			try
			{
				if (table.Rows.Count > 0)
				{
					Info.UserName = username;
					this.Hide();
					Main_Form mainForm = new Main_Form();
					mainForm.Show();
					mainForm.showProjects();

				}
				else
				{
					if (username.Trim().Equals(""))
					{
						MessageBox.Show("Введіть логін");
					}
					else if (password.Trim().Equals(""))
					{
						MessageBox.Show("Введіть пароль");
					}
					else
					{
						MessageBox.Show("Неправильний логін або пароль");
					}
				}
			}
			catch
			{
				MessageBox.Show("Користувача не знайдено");
			}

		}

        private void label_toRePass_Click(object sender, EventArgs e)
        {
			Pass_Form pf = new Pass_Form();
			pf.Show();
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
    }
}
