using System;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Net;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Timers;

namespace TesterNotes
{
    public partial class Pass_Form : Form
    {
        public Pass_Form()
        {
            InitializeComponent();
        }

        System.Timers.Timer timer = new System.Timers.Timer();
        Methods methodsForm = new Methods();

        string code;
        string mail;
        int timeCounter = 120;

        private void buttonPF_sendMail_Click(object sender, EventArgs e)
        {
            if (textBox_mail.Text.Equals(""))
            {
                MessageBox.Show("Введіть email.");
            }
            else if (!methodsForm.checkEmail(textBox_mail.Text))
            {
                MessageBox.Show("Не правильний формат пошти.");
            }
            else if (!methodsForm.chekUserEmail(textBox_mail, "SELECT * FROM `users` WHERE `mail_user` = @mail", "@mail"))
            {
                MessageBox.Show("Користувача з такою поштою не існує.");
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
                    MessageBox.Show("На вашу пошту успішно відправлений код, введіть його в наступне вікно.");

                    timerCode();

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Помилка: " + exception.Message);
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
                MessageBox.Show("Ви підтвердили свою пошту.");
                panel_mail.Visible = false;
                panel_code.Visible = false;
                panel_pass.Visible = true;
            }
            else
            {
                MessageBox.Show("Неправильний код. Повторіть спробу.");
                panel_mail.Visible = true;
                panel_code.Visible = false;
                panel_pass.Visible = false;
            }
        }

        private void button_changePass_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase database = new DataBase();

                MySqlCommand command = new MySqlCommand("UPDATE `users` SET " +
                    "password_user = @pass WHERE mail_user = '" + mail + "'", database.getConnection());

                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = methodsForm.encryptText(textBox_password.Text);
                database.openConnection();

                if (textBox_password.Text.Equals("") || textBox_password.Equals("Пароль"))
                {
                    MessageBox.Show("Введіть новий пароль та повторіть його.");
                }
                else if (textBox_password.TextLength < 8)
                {
                    MessageBox.Show("Пароль має бути не менше 8 символів.");
                }
                else if (textBox_password.Text != textBox_repassword.Text)
                {
                    MessageBox.Show("Пароль повторений невірно.");
                }
                else if (command.ExecuteNonQuery() == 1)
                {
                    try
                    {
                        MessageBox.Show("Пароль змінено успішно.");
                        this.Close();

                        if (Info.formNumber == 321)
                        {
                            Login_Form loginForm = new Login_Form();
                            loginForm.Show();
                        }
                        else if (Info.formNumber == 123)
                        {
                            Account_Form accountForm = new Account_Form();
                            accountForm.Show();
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

        private void textBox_password_MouseEnter(object sender, EventArgs e)
        {
            methodsForm.metodMouseEnter(textBox_password, "Пароль");
        }

        private void textBox_password_MouseLeave(object sender, EventArgs e)
        {
            methodsForm.metodMouseLeave(textBox_password, "Пароль");
        }

        private void textBox_repassword_MouseEnter(object sender, EventArgs e)
        {
            methodsForm.metodMouseEnter(textBox_repassword, "Пароль");
        }

        private void textBox_repassword_MouseLeave(object sender, EventArgs e)
        {
            methodsForm.metodMouseLeave(textBox_repassword, "Пароль");
        }

        private void label_tologin_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Info.formNumber == 321)
            {
                Login_Form loginForm = new Login_Form();
                loginForm.Show();
            }
            else if (Info.formNumber == 123)
            {
                Account_Form accountForm = new Account_Form();
                accountForm.Show();
            }

        }


        private void label_tologin_MouseEnter(object sender, EventArgs e)
        {
            label_tologin.ForeColor = Color.DarkSlateGray;
        }

        private void label_tologin_MouseLeave(object sender, EventArgs e)
        {
            label_tologin.ForeColor = Color.Gray;
        }

        private void Pass_Form_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message message = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref message);
        }

        public void timerCode()
        {
            timer.Interval = 1000;
            timer.Elapsed += new ElapsedEventHandler(startTimer);
            timer.Start();
        }

        private void startTimer(object sender, ElapsedEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                if (timeCounter != 0)
                {
                    labelTimer.Text = timeCounter--.ToString() + " c";
                }
                else
                {
                    timer.Stop();
                    code = GeneratePassword(10);
                    panel_mail.Visible = true;
                    panel_code.Visible = false;
                    panel_pass.Visible = false;
                }

            }));

        }
    }
}
    

