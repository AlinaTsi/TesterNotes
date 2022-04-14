using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesterNotes
{
    internal class Methods
    {
		/// <summary> this.buttonMF_addReport.Click += new System.EventHandler(this.buttonMF_addReport_Click);
		/// Заповнює поля при відведенні миші
		/// </summary>
		public void metodMouseLeave(TextBox textbl, string leavetext)
		{
			String name = textbl.Text;

			if (name.Equals(""))
			{
				textbl.Text = leavetext;
				textbl.ForeColor = Color.Gray;
			}
		}

		/// <summary>
		/// Очищує поля при наведенні миші
		/// </summary>
		public void metodMouseEnter(TextBox textbe, string entertext)
		{
			String name = textbe.Text;

			if (name.Equals(entertext))
			{
				textbe.Text = "";
				textbe.ForeColor = Color.DimGray;
			}
		}

		/// <summary>
		/// Вихід з програми
		/// </summary>
		public void exit(Form form)
		{
			DialogResult res = MessageBox.Show("Ви дійсно хочете вийти?","", MessageBoxButtons.YesNo);
			if (res == DialogResult.Yes)
			{
				form.Close();
				Application.Exit();
			}
		}
		/// <summary>
		/// Заповнення DataGridView
		/// </summary>
		public void FillDGW(string selectQuery, DataGridView dataGVi)
		{
			DataBase db = new DataBase();
			DataTable table = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, db.getConnection());
			adapter.Fill(table);
			dataGVi.DataSource = table;
		}

		/// <summary>
		/// Заповнення комбобоксів
		/// </summary>
		public void FillCB(ComboBox comboBox, string nameQuery, string nameRow)
		{
			comboBox.Items.Clear();
			DataBase db = new DataBase();
			db.openConnection();
			MySqlCommand command = new MySqlCommand(nameQuery, db.getConnection());
			MySqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				comboBox.Items.Add(reader.GetString(nameRow));
			}
			db.closeConnection();
		}

	}
}
