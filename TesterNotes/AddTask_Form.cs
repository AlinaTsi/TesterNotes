using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TesterNotes
{
    public partial class AddTask_Form : Form
    {
        public AddTask_Form()
        {
            InitializeComponent();
            md.FillCB(comboBoxATF_project, "SELECT * FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '"+ Info.UserName +"')", "name_project");
        }

        Methods md = new Methods();

        private void labelATF_close_Click(object sender, EventArgs e)
        {
            Main_Form mf = new Main_Form();
            mf.Show();
            mf.showTasks();
            this.Close();
        }

        private void labelATF_close_MouseEnter(object sender, EventArgs e)
        {
            labelATF_close.ForeColor = Color.IndianRed;
        }

        private void labelATF_close_MouseLeave(object sender, EventArgs e)
        {
            labelATF_close.ForeColor = Color.Gray;
        }


        private void buttonATF_addtask_Click(object sender, EventArgs e)
        {
            DataBase database = new DataBase();
            string name = textBoxATF_name.Text;
            string desc;
            string project = comboBoxATF_project.Text;
            string status;

            if (textBoxATF_description.Text.Equals("Опис")) { desc = "";} else { desc = textBoxATF_description.Text; }
            if (comboBoxATF_status.Text.Equals("Статус")) { status = ""; } else { status = comboBoxATF_status.Text; }
            

            MySqlCommand command = new MySqlCommand("INSERT INTO `tasks`" +
                "(`name_task`, `description_task`, `id_project`, `status_task`, `startdate_task`, `enddate_task`) " +
                "VALUES (@name, @description, (SELECT id_project FROM `projects` WHERE name_project = @project), @status, @startdate, @enddate) ", database.getConnection());

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = desc;
            command.Parameters.Add("@project", MySqlDbType.VarChar).Value = project;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@startdate", MySqlDbType.VarChar).Value = dateTP_ATF_start.Text;
            command.Parameters.Add("@enddate", MySqlDbType.VarChar).Value = dateTP_ATF_end.Text;

            database.openConnection();

            try
            {
                if (name.Equals("") || name.Equals("Назва") || project.Equals("") || project.Equals("Проект"))
                {
                    MessageBox.Show("Введіть назву та проект");
                }
                else if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Завдання додано");
                    Main_Form mf = new Main_Form();
                    mf.Show();
                    mf.showTasks();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Помилка. Повторіть спробу");
            }
            

            database.closeConnection();
        }


        private void textBoxATF_name_MouseEnter(object sender, EventArgs e)
        {
            md.metodMouseEnter(textBoxATF_name, "Назва");
        }

        private void textBoxATF_name_MouseLeave(object sender, EventArgs e)
        {
            md.metodMouseLeave(textBoxATF_name, "Назва");
        }

        private void textBoxATF_description_MouseEnter(object sender, EventArgs e)
        {
            md.metodMouseEnter(textBoxATF_description, "Опис");
        }

        private void textBoxATF_description_MouseLeave(object sender, EventArgs e)
        {
            md.metodMouseLeave(textBoxATF_description, "Опис");
        }

        private void AddTask_Form_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
