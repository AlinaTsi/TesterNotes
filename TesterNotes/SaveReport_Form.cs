using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Drawing;
using System;

namespace TesterNotes
{
    public partial class SaveReport_Form : Form
    {
        public SaveReport_Form()
        {
            InitializeComponent();
            methods.fillComboBox(comboBox_project, "SELECT * FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "')", "name_project");
        }

        Methods methods = new Methods();

        string projectField = "", environmentField = "", platformField = "", stepsField = "", actualField = "", expectedField = "", notesField = "";
        string projectName = "";

        private void label_close_Click(object sender, System.EventArgs e)
        {
            this.Close();

            Main_Form mainForm = new Main_Form();
            mainForm.Show();
        }

        private void buttonCreatePDF_Click(object sender, System.EventArgs e)
        {
            methods.fillDataGW("SELECT `reports`.summary_bug AS 'Назва' "+ projectField + platformField + environmentField + stepsField + actualField + expectedField + notesField +" FROM `reports`, `projects`, `users` WHERE `reports`.id_project = `projects`.id_project AND `projects`.id_user = `users`.id_user " +
                "AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "') " + projectName, dataGridView_pdf);
        }

        public void pdfSaveClass(DataGridView datagridsave, string namefile)
        {
            try
            {
                PdfPTable pdfTable = new PdfPTable(datagridsave.ColumnCount);

                pdfTable.DefaultCell.Padding = 10;
                pdfTable.WidthPercentage = 100;

                BaseFont baseFont = BaseFont.CreateFont("c:\\Windows\\Fonts\\tahoma.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 14);
                iTextSharp.text.Font headFont = new iTextSharp.text.Font(baseFont, 20);


                foreach (DataGridViewColumn column in datagridsave.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, headFont));
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in datagridsave.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(new Phrase(System.Convert.ToString(cell.Value), font));
                    }
                }


                string folderPath = "C:\\Звіти\\";

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + namefile + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 20f, 20f, 10f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Файл успішно збережено C:\\Репорти\\" + namefile + ".pdf" + ".");
                }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Помилка: " + exception.Message);
                }
        }


        private void label_close_MouseEnter(object sender, System.EventArgs e)
        {
            label_close.ForeColor = Color.DarkSlateGray;
        }

        
        private void label_close_MouseLeave(object sender, System.EventArgs e)
        {
            label_close.ForeColor = Color.Gray;
        }

        private void SaveReport_Form_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message message = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref message);
        }


        private void button_save_Click(object sender, System.EventArgs e)
        {
            if (textBox_name.Text.Equals(""))
            {
                MessageBox.Show("Спочатку введіть назву документа.");
               
            }
            else
            {
                pdfSaveClass(dataGridView_pdf, textBox_name.Text);
                this.Close();

                SaveReport_Form reportForm = new SaveReport_Form();
                reportForm.Show();
            }
                
        }

        private void checkBoxProject_Click(object sender, System.EventArgs e)
        {
            if (checkBoxProject.Checked)
            {
                projectField = ", `projects`.name_project AS 'Проект' ";
            }
            else projectField = "";
        }

        private void comboBox_project_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_project.SelectedIndex > -1)
            {
                projectName = " AND `projects`.name_project = '" + comboBox_project.Text + "'";
            }
            else projectName = "";
        }

        private void checkBoxAllFields_Click(object sender, EventArgs e)
        {
            if (checkBoxAllFields.Checked)
            {
                checkBoxActual.Checked = true;
                checkBoxEnvironment.Checked = true;
                checkBoxExpected.Checked = true;
                checkBoxNotes.Checked = true;
                checkBoxPlatform.Checked = true;
                checkBoxProject.Checked = true;
                checkBoxSteps.Checked = true;
            }
            else
            {
                checkBoxActual.Checked = false;
                checkBoxEnvironment.Checked = false;
                checkBoxExpected.Checked = false;
                checkBoxNotes.Checked = false;
                checkBoxPlatform.Checked = false;
                checkBoxProject.Checked = false;
                checkBoxSteps.Checked = false;
            }
            checkBoxActual_Click(sender, e);
            checkBoxEnvironment_Click(sender, e);
            checkBoxExpected_Click(sender, e);
            checkBoxNotes_Click(sender, e);
            checkBoxPlatform_Click(sender, e);
            checkBoxProject_Click(sender, e);
            checkBoxSteps_Click(sender, e);
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
