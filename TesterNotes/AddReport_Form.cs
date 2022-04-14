using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TesterNotes
{
    public partial class AddReport_Form : Form
    {
        public AddReport_Form()
        {
            InitializeComponent();
            md.FillCB(comboBoxARF_project, "SELECT * FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", "name_project");
                  
        }

        Methods md = new Methods();

        private void labelARF_close_Click(object sender, EventArgs e)
        {
            Main_Form mf = new Main_Form();
            mf.Show();
            mf.showReports();
            this.Close();
        }

        private void labelARF_close_MouseEnter(object sender, EventArgs e)
        {
            labelARF_close.ForeColor = Color.IndianRed;
        }

        private void labelARF_close_MouseLeave(object sender, EventArgs e)
        {
            labelARF_close.ForeColor = Color.Gray;
        }

        public Boolean ChekTextBoxes()
        {
            String nametask = textBoxARF_summary.Text;
            String project = comboBoxARF_project.Text;

            if (nametask.Equals("") || project.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonARF_addtask_Click(object sender, EventArgs e)
        {
            DataBase database = new DataBase();
            string project = comboBoxARF_project.Text;
            string summary = textBoxARF_summary.Text;
            string platform;
            string env;
            string steps;
            string act;
            string exp;
            string notes;
            if (textBoxARF_platf.Text.Equals("Платформа")) { platform = ""; } else { platform = textBoxARF_platf.Text; }
            if (textBoxARF_envir.Text.Equals("Середовище")) { env = ""; } else { env = textBoxARF_envir.Text; }
            if (textBoxARF_steps.Text.Equals("Кроки відтворення")) { steps = ""; } else { steps = textBoxARF_steps.Text; }
            if (textBoxARF_actual.Text.Equals("Фактичний результат")) { act = ""; } else { act = textBoxARF_actual.Text; }
            if (textBoxARF_expected.Text.Equals("Очікуваний результат")) { exp = ""; } else { exp = textBoxARF_expected.Text; }
            if (textBoxARF_notes.Text.Equals("Нотатки")) { notes = ""; } else { notes = textBoxARF_notes.Text; }

            MySqlCommand command = new MySqlCommand("INSERT INTO `reports`" +
                "(`id_project`, `summary_bug`, `platform_bug`, `environment_bug`, `steps_bug`, `actualresult_bug`, `expectedresult_bug`, `notes_bug`) " +
                "VALUES ((SELECT id_project FROM `projects` WHERE name_project = @project), @summary, " +
                "@platform, @environment, @steps, @ares, @eres, @notes) ", database.getConnection());

            command.Parameters.Add("@project", MySqlDbType.VarChar).Value = project;
            command.Parameters.Add("@summary", MySqlDbType.VarChar).Value = summary;
            command.Parameters.Add("@platform", MySqlDbType.VarChar).Value = platform;
            command.Parameters.Add("@environment", MySqlDbType.VarChar).Value = env;
            command.Parameters.Add("@steps", MySqlDbType.VarChar).Value = steps;
            command.Parameters.Add("@ares", MySqlDbType.VarChar).Value = act;
            command.Parameters.Add("@eres", MySqlDbType.VarChar).Value = exp;
            command.Parameters.Add("@notes", MySqlDbType.VarChar).Value = notes;

            database.openConnection();

            try
            {
                if (summary.Equals("Назва") || summary.Equals("") || project.Equals("Проект") || project.Equals(""))
                {
                    MessageBox.Show("Введіть назву та проект");
                }
                else
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Репорт додано");
                        Main_Form mf = new Main_Form();
                        mf.Show();
                        mf.showReports();
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Помилка. Повторіть спробу");
            }
            
            database.closeConnection();
        }

        private void AddReport_Form_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void textBoxARF_summary_MouseEnter(object sender, EventArgs e)
        {
            md.metodMouseEnter(textBoxARF_summary, "Назва");
        }

        private void textBoxARF_summary_MouseLeave(object sender, EventArgs e)
        {
            md.metodMouseLeave(textBoxARF_summary, "Назва");
        }

        private void textBoxARF_envir_MouseEnter(object sender, EventArgs e)
        {
            md.metodMouseEnter(textBoxARF_envir, "Середовище");
        }

        private void textBoxARF_envir_MouseLeave(object sender, EventArgs e)
        {
            md.metodMouseLeave(textBoxARF_envir, "Середовище");
        }

        private void textBoxARF_platf_MouseEnter(object sender, EventArgs e)
        {
            md.metodMouseEnter(textBoxARF_platf, "Платформа");
        }

        private void textBoxARF_platf_MouseLeave(object sender, EventArgs e)
        {
            md.metodMouseLeave(textBoxARF_platf, "Платформа");
        }

        private void textBoxARF_steps_MouseEnter(object sender, EventArgs e)
        {
            md.metodMouseEnter(textBoxARF_steps, "Кроки відтворення");
        }

        private void textBoxARF_steps_MouseLeave(object sender, EventArgs e)
        {
            md.metodMouseLeave(textBoxARF_steps, "Кроки відтворення");
        }

        private void textBoxARF_actual_MouseEnter(object sender, EventArgs e)
        {
            md.metodMouseEnter(textBoxARF_actual, "Фактичний результат");
        }

        private void textBoxARF_actual_MouseLeave(object sender, EventArgs e)
        {
            md.metodMouseLeave(textBoxARF_actual, "Фактичний результат");
        }

        private void textBoxARF_expected_MouseEnter(object sender, EventArgs e)
        {
            md.metodMouseEnter(textBoxARF_expected, "Очікуваний результат");
        }

        private void textBoxARF_expected_MouseLeave(object sender, EventArgs e)
        {
            md.metodMouseLeave(textBoxARF_expected, "Очікуваний результат");
        }

        private void textBoxARF_notes_MouseEnter(object sender, EventArgs e)
        {
            md.metodMouseEnter(textBoxARF_notes, "Нотатки");
        }

        private void textBoxARF_notes_MouseLeave(object sender, EventArgs e)
        {
            md.metodMouseLeave(textBoxARF_notes, "Нотатки");
        }
    }
}
