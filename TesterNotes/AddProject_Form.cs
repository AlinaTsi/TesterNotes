using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TesterNotes
{
	public partial class AddProject_Form : Form
	{
		public AddProject_Form()
		{
			InitializeComponent();
		}

        Methods methods = new Methods();

        private void labelAPF_close_Click(object sender, EventArgs e)
		{
            Main_Form mainForm = new Main_Form();
            mainForm.Show();
            mainForm.showProjects();
            this.Close();
        }

		private void labelAPF_close_MouseEnter(object sender, EventArgs e)
		{
			labelAPF_close.ForeColor = Color.DarkSlateGray;
        }

		private void labelAPF_close_MouseLeave(object sender, EventArgs e)
		{
			labelAPF_close.ForeColor = Color.Gray;
		}

        public Boolean ChekTextBoxes()
        {
            String nameProject = textBoxAPF_name.Text;


            if (nameProject.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonAPF_addproject_Click(object sender, EventArgs e)
		{
            try
            {
                DataBase database = new DataBase();
                string idUser = Info.userName;
                string name = textBoxAPF_name.Text;
                string customer;

                if (textBoxAPF_cust.Text.Equals("Замовник"))
                {
                    customer = "";
                }
                else
                {
                    customer = textBoxAPF_cust.Text;
                }

                MySqlCommand command = new MySqlCommand("INSERT INTO `projects`" +
                    "(`id_user`, `name_project`, `customer_project`) " +
                    "VALUES ((SELECT id_user FROM `users` WHERE login_user = @id_user), @name_project, @cust_project) ", database.getConnection());

                command.Parameters.Add("@id_user", MySqlDbType.VarChar).Value = idUser;
                command.Parameters.Add("@name_project", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@cust_project", MySqlDbType.VarChar).Value = customer;

                database.openConnection();

                try
                {
                    if (name.Equals("") || name.Equals("Назва"))
                    {
                        MessageBox.Show("Введіть назву.");
                    }
                    else if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Проект додано.");

                        Main_Form mainForm = new Main_Form();
                        mainForm.Show();
                        mainForm.showProjects();
                        this.Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Помилка: " + exception.Message);
                }

                database.closeConnection();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Не вдалось підключитись до бази даних. Перевірте підключення до Інтернету, налаштування проксі-сервера та брандмауера. " + exception.Message);
            }
            
        }


        private void textBoxAPF_name_MouseEnter(object sender, EventArgs e)
        {
            methods.metodMouseEnter(textBoxAPF_name, "Назва*");
        }

        private void textBoxAPF_name_MouseLeave(object sender, EventArgs e)
        {
            methods.metodMouseLeave(textBoxAPF_name, "Назва*");
        }

        private void textBoxAPF_cust_MouseEnter(object sender, EventArgs e)
        {
            methods.metodMouseEnter(textBoxAPF_cust, "Замовник");
        }

        private void textBoxAPF_cust_MouseLeave(object sender, EventArgs e)
        {
            methods.metodMouseLeave(textBoxAPF_cust, "Замовник");
        }

        private void AddProject_Form_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message message = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref message);
        }
    }
}
