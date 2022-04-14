using System;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Net;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace TesterNotes
{
    public partial class Pass_Form : Form
    {
        public Pass_Form()
        {
            InitializeComponent();
        }

        Methods md = new Methods();
        string code;
        string mail;

        private void buttonPF_sendMail_Click(object sender, EventArgs e)
        {
            if (textBox_mail.Text.Equals(""))
            {
                MessageBox.Show("Введіть email");
            }
            else if (!UserEmail(textBox_mail.Text))
            {
                MessageBox.Show("Не правильний формат пошти");
            }
            else if (!chekMail())
            {
                MessageBox.Show("Користувача з такою поштою не існує");
            }
            else
            {
                try
                {
                    code = GeneratePassword(10);
                    MailAddress from = new MailAddress("alinatester8@gmail.com", "Tester Notes");
                    MailAddress to = new MailAddress(textBox_mail.Text, "User");
                    MailMessage message = new MailMessage(from, to);
                    message.Body = "Введіть даний код у відповідне поле і дотримуйтесь подальших інструкцій по зміні пароля. " +
                        "Код: " + code;
                    message.Subject = "Код для скидання пароля";

                    Registration_Form rf = new Registration_Form();

                    SmtpClient client = new SmtpClient();
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(from.Address, "tester888");

                    client.Send(message);
                    mail = textBox_mail.Text;
                    panel_mail.Visible = false;
                    panel_code.Visible = true;
                    panel_pass.Visible = false;
                    MessageBox.Show("На вашу пошту успішно відправлений код, введіть його в наступне вікно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }

        private static string GeneratePassword(int length)
        {
            var random = new Random();
            var resultPassword = new StringBuilder(length);
            var passwordCharSet = "abcdefghijklmnopqrstuvwxyz0123456789";
            for (var i = 0; i < length; i++)
            {
                resultPassword.Append(passwordCharSet[random.Next(0, passwordCharSet.Length)]);
            }
            return resultPassword.ToString();
        }


        private void labelARF_close_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Show();
            this.Close();
        }


        private void Pass_Form_Load(object sender, EventArgs e)
        {
            panel_mail.Visible = true;
            panel_code.Visible = false;
            panel_pass.Visible = false;
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            if (textBox_code.Text == code)
            {
                MessageBox.Show("Ви підтвердили свою пошту");
                panel_mail.Visible = false;
                panel_code.Visible = false;
                panel_pass.Visible = true;
            }
            else
            {
                MessageBox.Show("Не правильний код. Повторіть спробу.");
                panel_mail.Visible = true;
                panel_code.Visible = false;
                panel_pass.Visible = false;
            }
        }

        private void button_changePass_Click(object sender, EventArgs e)
        {
            DataBase database = new DataBase();
            
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET " +
                "password_user = @pass WHERE mail_user = '" + mail + "'", database.getConnection());

            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox_password.Text;
            database.openConnection();

            if (textBox_password.Text != textBox_repassword.Text)
            {
                MessageBox.Show("Пароль повторений невірно");
            }
            else
            {
                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        Login_Form lform = new Login_Form();
                        lform.Show();
                        MessageBox.Show("Пароль змінено успішно");
                        this.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
            database.closeConnection();
        }

        public Boolean chekMail()
        {
            DataBase database = new DataBase();

            String mail = textBox_mail.Text;

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

        public Boolean UserEmail(string email)
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

        private void textBox_password_MouseEnter(object sender, EventArgs e)
        {
            md.metodMouseEnter(textBox_password, "Пароль");
        }

        private void textBox_password_MouseLeave(object sender, EventArgs e)
        {
            md.metodMouseLeave(textBox_password, "Пароль");
        }

        private void textBox_repassword_MouseEnter(object sender, EventArgs e)
        {
            md.metodMouseEnter(textBox_repassword, "Пароль");
        }

        private void textBox_repassword_MouseLeave(object sender, EventArgs e)
        {
            md.metodMouseLeave(textBox_repassword, "Пароль");
        }

        private void label_tologin_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Show();
            this.Hide();
        }

        private void label_tologin_MouseEnter(object sender, EventArgs e)
        {
            label_tologin.ForeColor = Color.DarkSlateGray;
        }

        private void label_tologin_MouseLeave(object sender, EventArgs e)
        {
            label_tologin.ForeColor = Color.Gray;
        }
    }
}
