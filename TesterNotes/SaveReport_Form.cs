using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Drawing;
using MySql.Data.MySqlClient;
using System;

namespace TesterNotes
{
    public partial class SaveReport_Form : Form
    {
        public SaveReport_Form()
        {
            InitializeComponent();
        }

        Methods md = new Methods();

        string projectField = "", environmentField = "", platformField = "", stepsField = "", actualField = "", expectedField = "", notesField = "";

        public void pdfSaveClass(DataGridView datagridsave, string namefile)
        {

            // Створення iTextSharp таблиці з даних бд
            PdfPTable pdfTable = new PdfPTable(datagridsave.ColumnCount);

            pdfTable.DefaultCell.BorderWidth = 1;

            BaseFont baseFont = BaseFont.CreateFont("c:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 10);
            iTextSharp.text.Font headfont = new iTextSharp.text.Font(baseFont, 16);

            // Додавання назв колонок

            foreach (DataGridViewColumn column in datagridsave.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, headfont));
                pdfTable.AddCell(cell);
            }

            // Додавання рядків

            foreach (DataGridViewRow row in datagridsave.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                { 
                pdfTable.AddCell(new Phrase(System.Convert.ToString(cell.Value), font));
                }
            }

            // Експорт у ".pdf"

            string folderPath = "C:\\Звіти\\";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + namefile + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
                MessageBox.Show("Файл успішно збережено (C:\\Звіти\\" + namefile + ".pdf" + ")");
            }
        }

        private void label_close_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Main_Form form = new Main_Form();
            form.Show();
        }

        private void buttonCreatePDF_Click(object sender, System.EventArgs e)
        {
            md.FillDGW("SELECT `reports`.summary_bug AS 'Назва' "+ projectField + platformField + environmentField + stepsField + actualField + expectedField + notesField +" FROM `reports`, `projects`, `users` WHERE `reports`.id_project = `projects`.id_project AND `projects`.id_user = `users`.id_user " +
                "AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "') ", dataGridView_pdf);
        }

        private void label_close_MouseEnter(object sender, System.EventArgs e)
        {
            label_close.ForeColor = Color.IndianRed;
        }

        
        private void label_close_MouseLeave(object sender, System.EventArgs e)
        {
            label_close.ForeColor = Color.Gray;
        }

        private void SaveReport_Form_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }


        private void button_save_Click(object sender, System.EventArgs e)
        {
            if (textBox_name.Text.Equals(""))
            {
                MessageBox.Show("Спочатку введіть назву документа");
            }
            else
                pdfSaveClass(dataGridView_pdf, textBox_name.Text);
        }

    
        //
        private void checkBoxProject_Click(object sender, System.EventArgs e)
        {
            if (checkBoxProject.Checked)
            {
                projectField = ", `projects`.name_project AS 'Проект' ";
            }
            else projectField = "";
        }


        private void checkBoxPlatform_Click(object sender, System.EventArgs e)
        {
            if (checkBoxPlatform.Checked)
            {
                platformField = ", `reports`.platform_bug AS 'Платформа'";
            }
            else platformField = "";
        }

        private void checkBoxEnvironment_Click(object sender, System.EventArgs e)
        {
            if (checkBoxEnvironment.Checked)
            {
                environmentField = ", `reports`.environment_bug AS 'Середовище'";
            }
            else environmentField = "";
        }

        private void checkBoxSteps_Click(object sender, System.EventArgs e)
        {
            if (checkBoxSteps.Checked)
            {
                stepsField = ", `reports`.steps_bug AS 'Кроки'";
            }
            else stepsField = "";
        }

        private void checkBoxActual_Click(object sender, System.EventArgs e)
        {
            if (checkBoxActual.Checked)
            {
                actualField = ", `reports`.actualresult_bug AS 'Фактичний р.'";
            }
            else actualField = "";
        }

        private void checkBoxExpected_Click(object sender, System.EventArgs e)
        {
            if (checkBoxExpected.Checked)
            {
                expectedField = ", `reports`.expectedresult_bug AS 'Очікуваний р.'";
            }
            else expectedField = "";
        }

        private void checkBoxNotes_Click(object sender, System.EventArgs e)
        {
            if (checkBoxNotes.Checked)
            {
                notesField = ", `reports`.notes_bug AS 'Нотатки'";
            }
            else notesField = "";
        }
    }
}
