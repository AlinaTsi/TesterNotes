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
            methods.fillComboBox(comboBoxATF_project, "SELECT * FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '"+ Info.userName +"')", "name_project");
        
        }

        Methods methods = new Methods();

        private void labelATF_close_Click(object sender, EventArgs e)
        {
            Main_Form mainForm = new Main_Form();
            mainForm.Show();
            mainForm.showTasks();
            this.Close();
        }

        private void labelATF_close_MouseEnter(object sender, EventArgs e)
        {
            labelATF_close.ForeColor = Color.DarkSlateGray;
        }

        private void labelATF_close_MouseLeave(object sender, EventArgs e)
        {
            labelATF_close.ForeColor = Color.Gray;
        }


        private void buttonATF_addtask_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase database = new DataBase();
                string name = textBoxATF_name.Text;
                string description;
                string project = comboBoxATF_project.Text;
                string status;
                string priority;

                if (textBoxATF_description.Text.Equals("Опис")) { description = ""; } else { description = textBoxATF_description.Text; }
                if (comboBoxATF_status.Text.Equals("Статус")) { status = "відкрито"; } else { status = comboBoxATF_status.Text; }
                if (comboBoxATF_priorityTask.Text.Equals("Приорітетність")) { priority = "0"; } else { priority = comboBoxATF_priorityTask.Text; }

                MySqlCommand command = new MySqlCommand("INSERT INTO `tasks`" +
                    "(`name_task`, `description_task`, `id_project`, `priority_task`, `status_task`, `enddate_task`) " +
                    "VALUES (@name, @description, (SELECT id_project FROM `projects` WHERE name_project = @project), @priority, @status, @enddate) ", database.getConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;
                command.Parameters.Add("@project", MySqlDbType.VarChar).Value = project;
                command.Parameters.Add("@priority", MySqlDbType.VarChar).Value = priority;
                command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
                command.Parameters.Add("@enddate", MySqlDbType.VarChar).Value = dateTP_ATF_end.Text;

                database.openConnection();


                if ((name.Equals("") || name.Equals("Назва*")) && (project.Equals("") || project.Equals("Проект*")))
                {
                    MessageBox.Show("Введіть назву завдання та проект.");
                }
                else if (name.Equals("") || name.Equals("Назва*"))
                {
                    MessageBox.Show("Введіть назву завдання.");
                }
                else if (project.Equals("") || project.Equals("Проект*"))
                {
                    MessageBox.Show("Введіть проект.");
                }
                else if (command.ExecuteNonQuery() == 1)
                {
                    try
                    {
                        MessageBox.Show("Завдання додано.");

                        Main_Form mainForm = new Main_Form();
                        mainForm.Show();
                        mainForm.showTasks();
                        this.Close();
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


        private void textBoxATF_name_MouseEnter(object sender, EventArgs e)
        {
            methods.metodMouseEnter(textBoxATF_name, "Назва*");
        }

        private void textBoxATF_name_MouseLeave(object sender, EventArgs e)
        {
            methods.metodMouseLeave(textBoxATF_name, "Назва*");
        }

        private void textBoxATF_description_MouseEnter(object sender, EventArgs e)
        {
            methods.metodMouseEnter(textBoxATF_description, "Опис");
        }

        private void textBoxATF_description_MouseLeave(object sender, EventArgs e)
        {
            methods.metodMouseLeave(textBoxATF_description, "Опис");
        }

        private void AddTask_Form_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message message = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref message);
        }

        private void comboBoxATF_priorityTask_MouseMove(object sender, MouseEventArgs e)
        {
            toolTipPriority.SetToolTip(comboBoxATF_priorityTask, "1 - найвищий, 10 - найнижчий");
        }
    }
}
