using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TesterNotes
{
	internal class Methods
	{
		public void metodMouseLeave(TextBox textBox, string leaveText)
		{
			String name = textBox.Text;

			if (name.Equals(""))
			{
				textBox.Text = leaveText;
				textBox.ForeColor = Color.Gray;
			}
		}

		public void metodMouseEnter(TextBox textBox, string enterText)
		{
			String name = textBox.Text;

			if (name.Equals(enterText))
			{
				textBox.Text = "";
				textBox.ForeColor = Color.DimGray;
			}
		}

		public void exit(Form form)
		{
			DialogResult result = MessageBox.Show("Ви дійсно хочете вийти?", "", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				form.Close();
				Application.Exit();
			}
		}

		public void fillDataGW(string selectQuery, DataGridView dataGVi)
		{
			DataBase db = new DataBase();
			DataTable table = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, db.getConnection());
			adapter.Fill(table);
			dataGVi.DataSource = table;
		}

		public void fillComboBox(ComboBox comboBox, string nameQuery, string nameRow)
		{
			comboBox.Items.Clear();
			DataBase database = new DataBase();
			database.openConnection();
			MySqlCommand command = new MySqlCommand(nameQuery, database.getConnection());
			MySqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				comboBox.Items.Add(reader.GetString(nameRow));
			}
			database.closeConnection();
		}
		public Boolean chekUserEmail(TextBox textBox, string query, string field)
		{
			DataBase database = new DataBase();

			String mail = textBox.Text;

			DataTable table = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			MySqlCommand command = new MySqlCommand(query, database.getConnection());

			command.Parameters.Add(field, MySqlDbType.VarChar).Value = mail;

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

		public Boolean checkEmail(string email)
		{
			
			if (string.IsNullOrWhiteSpace(email))
				return false;

			try
			{
				email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
									  RegexOptions.None, TimeSpan.FromMilliseconds(200));

				string DomainMapper(Match match)
				{
					var idn = new IdnMapping();

					string domainName = idn.GetAscii(match.Groups[2].Value);

					return match.Groups[1].Value + domainName;
				}
			}
			catch (RegexMatchTimeoutException exception)
			{
				return false;
			}
			catch (ArgumentException exception)
			{
				return false;
			}

			try
			{
				return Regex.IsMatch(email,
					@"^[^@\s]+@[^@\s]+\.[^@\s]+$",
					RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
			}
			catch (RegexMatchTimeoutException)
			{
				return false;
			}
		}

		string alphabet = Resource.ResourceManager.GetString("key");

		private string reverse(string inputText)
		{
			var reversedText = string.Empty;
			foreach (var row in inputText)
			{
				reversedText = row + reversedText;
			}

			return reversedText;
		}

		private string encryptDecrypt(string text, string symbols, string cipher)
		{
			text = text.ToLower();

			var outputText = string.Empty;
			for (var counter = 0; counter < text.Length; counter++)
			{
				var index = symbols.IndexOf(text[counter]);
				if (index >= 0)
				{
					outputText += cipher[index].ToString();
				}
			}

			return outputText;
		}

		public string encryptText(string plainText)
		{
			return encryptDecrypt(plainText, alphabet, reverse(alphabet));
		}

		public string decryptText(string encryptedText)
		{
			return encryptDecrypt(encryptedText, reverse(alphabet), alphabet);
		}
	

	}
}
