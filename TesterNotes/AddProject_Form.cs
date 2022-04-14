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

        Methods md = new Methods();

        private void labelAPF_close_Click(object sender, EventArgs e)
		{
            Main_Form mf = new Main_Form();
            mf.Show();
            mf.showProjects();
            this.Close();
        }

		private void labelAPF_close_MouseEnter(object sender, EventArgs e)
		{
			labelAPF_close.ForeColor = Color.IndianRed;
		}

		private void labelAPF_close_MouseLeave(object sender, EventArgs e)
		{
			labelAPF_close.ForeColor = Color.Gray;
		}

        public Boolean ChekTextBoxes()
        {
            String nameproj = textBoxAPF_name.Text;


            if (nameproj.Equals(""))
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
            DataBase database = new DataBase();
            string id_user = Info.UserName;
            string name = textBoxAPF_name.Text;
            string cust;

            if (textBoxAPF_cust.Text.Equals("Замовник"))
            {
                cust = "";
            }
            else
            {
                cust = textBoxAPF_cust.Text;
            }

            MySqlCommand command = new MySqlCommand("INSERT INTO `projects`" +
                "(`id_user`, `name_project`, `customer_project`) " +
                "VALUES ((SELECT id_user FROM `users` WHERE login_user = @id_user), @name_project, @cust_project) ", database.getConnection());

            command.Parameters.Add("@id_user", MySqlDbType.VarChar).Value = id_user;
            command.Parameters.Add("@name_project", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@cust_project", MySqlDbType.VarChar).Value = cust;

            database.openConnection();

            try
            {
                if (name.Equals("") || name.Equals("Назва"))
                {
                    MessageBox.Show("Введіть хоча б назву");
                }
                else if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Проект додано");
                    Main_Form mf = new Main_Form();
                    mf.Show();
                    mf.showProjects();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Помилка. Повторіть спробу");
            }

            database.closeConnection();
        }


        private void textBoxAPF_name_MouseEnter(object sender, EventArgs e)
        {
            md.metodMouseEnter(textBoxAPF_name, "Назва");
        }

        private void textBoxAPF_name_MouseLeave(object sender, EventArgs e)
        {
            md.metodMouseLeave(textBoxAPF_name, "Назва");
        }

        private void textBoxAPF_cust_MouseEnter(object sender, EventArgs e)
        {
            md.metodMouseEnter(textBoxAPF_cust, "Замовник");
        }

        private void textBoxAPF_cust_MouseLeave(object sender, EventArgs e)
        {
            md.metodMouseLeave(textBoxAPF_cust, "Замовник");
        }

        private void AddProject_Form_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
