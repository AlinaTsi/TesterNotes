using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TesterNotes
{
	public partial class Main_Form : Form
	{
		public Main_Form()
		{
			InitializeComponent();
		}

		private void buttonMF_tasks_MouseDown(object sender, MouseEventArgs e)
		{
			base.Capture = false;
			Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref m);
		}

		Methods md = new Methods();

		/// <summary>
		/// Вихід
		/// </summary>
		private void buttonExit_Click(object sender, EventArgs e)
		{
			md.exit(this);
		}

		/// <summary>
		/// Перехід між панелями
		/// </summary>

		private void buttonMF_projects_Click(object sender, EventArgs e)
		{
			showProjects();
		}

		private void button_reports_Click(object sender, EventArgs e)
		{
			showReports();
		}

		private void buttonMF_tasks_Click(object sender, EventArgs e)
		{
			showTasks();
		}

		/// <summary>
		/// Методи виводу даних для панелей
		/// </summary>
		public void showProjects()
		{
			string user = Info.UserName;
			panelMF_projects.Visible = true;
			panelMF_tasks.Visible = false;
			panelMF_reports.Visible = false;
			md.FillDGW("SELECT name_project FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '" + user + "')", dataGridView_projects);
			buttonMF_goTaskRep.BackColor = Color.DarkGray;
			buttonMF_goTaskRep.Enabled = false;
			buttonMF_goRep.BackColor = Color.DarkGray;
			buttonMF_goRep.Enabled = false;
		}

		public void showTasks()
		{
			panelMF_projects.Visible = false;
			panelMF_tasks.Visible = true;
			panelMF_reports.Visible = false;
			label_TaskID.Text = "";
			md.FillDGW("SELECT `tasks`.id_task, `tasks`.name_task, `projects`.name_project, `tasks`.status_task " +
				"FROM `tasks`, `projects`, `users` " +
				"WHERE `tasks`.id_project = `projects`.id_project " +
				"AND `projects`.id_user = `users`.id_user " +
				"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", dataGridViewMF_tasks);
			md.FillCB(comboBoxMF_taskproject, "SELECT * FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", "name_project");
			dataGridViewMF_tasks.Columns[0].Visible = false;
		}

		public void showReports()
		{
			panelMF_projects.Visible = false;
			panelMF_tasks.Visible = false;
			panelMF_reports.Visible = true;
			label_ReportID.Text = "";
			md.FillDGW("SELECT `reports`.id_bug, `reports`.summary_bug FROM `reports`, `projects` " +
				"WHERE `reports`.id_project = `projects`.id_project AND " +
				"`projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", dataGridViewMF_reports);
			dataGridViewMF_reports.Columns[0].Visible = false;
		}

		/// <summary>*************************************************************************************
		/// панель PROJECTS
		/// </summary>************************************************************************************
		/// Вивід

		private void dataGridView_projects_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataBase db = new DataBase();
			string nproject = dataGridView_projects.CurrentRow.Cells[0].Value.ToString();


			string selectQuery = "SELECT * FROM projects WHERE name_project = '" + nproject + "'"; // запит
			string selectQueryTasks = "SELECT id_task, name_task FROM tasks WHERE id_project = (SELECT id_project FROM projects WHERE name_project = '" + nproject + "')";
			string selectQueryReports = "SELECT id_bug, summary_bug FROM reports WHERE id_project = (SELECT id_project FROM projects WHERE name_project = '" + nproject + "')";

			db.openConnection();

			MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());
			MySqlDataReader reader = command.ExecuteReader();

			try
			{
				if (reader.Read()) // якщо є дані для читання
				{
					string cproject = reader.GetString("customer_project");
					string idproj = reader.GetString("id_project");
					Info.IdProject = reader.GetInt32("id_project");
					textBoxMFP_name.Text = nproject;
					textBoxMFP_cust.Text = cproject;
					md.FillDGW(selectQueryTasks, dataGridViewMF_projTasks);
					md.FillDGW(selectQueryReports, dataGridViewMF_projReports);
					dataGridViewMF_projReports.Columns[0].Visible = false;
					dataGridViewMF_projTasks.Columns[0].Visible = false;
				}
				else // якщо нема даних для читання
				{
					MessageBox.Show("Даних не знайдено"); // вивести повідомлення
				}
			}
			catch
			{
				MessageBox.Show("Помилка");

			}

			db.closeConnection();

			if (dataGridViewMF_projTasks.Rows.Count == 0)
			{
				buttonMF_goTaskRep.BackColor = Color.DarkGray;
				buttonMF_goTaskRep.Enabled = false;
			}
			if (dataGridViewMF_projReports.Rows.Count == 0)
			{
				buttonMF_goRep.BackColor = Color.DarkGray;
				buttonMF_goRep.Enabled = false;
			}
		}

		// Додати видалити і оновити проект

		private void buttonMFP_add_Click(object sender, EventArgs e)
		{
			AddProject_Form addform = new AddProject_Form();
			addform.Show();
			this.Close();
		}

		private void buttonMFP_update_Click(object sender, EventArgs e)
		{
			DataBase database = new DataBase();

			MySqlCommand command = new MySqlCommand("UPDATE `projects` SET " +
				"name_project = @project, customer_project = @customer " +
				"WHERE id_project = '" + Info.IdProject + "'", database.getConnection());

			command.Parameters.Add("@project", MySqlDbType.VarChar).Value = textBoxMFP_name.Text;
			command.Parameters.Add("@customer", MySqlDbType.VarChar).Value = textBoxMFP_cust.Text;

			database.openConnection();

			if (textBoxMFP_name.Equals(""))
			{
				MessageBox.Show("Спочатку оберіть проект та відредагуйте інформацію");
			}

			else
			{
				try
				{
					if (command.ExecuteNonQuery() == 1)
					{
						MessageBox.Show("Дані змінено успішно");
						textBoxMFP_cust.Clear();
						textBoxMFP_name.Clear();
						md.FillDGW("SELECT name_project FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", dataGridView_projects);
					}
				}
				catch
				{
					MessageBox.Show("Помилка");
				}
			}
			database.closeConnection();

		}

		private void buttonMFP_delete_Click(object sender, EventArgs e)
		{
			DataBase database = new DataBase();

			MySqlCommand command = new MySqlCommand("DELETE FROM `projects` WHERE id_project = '" + Info.IdProject + "'", database.getConnection());

			database.openConnection();

			if (Info.IdProject.Equals(""))
			{
				MessageBox.Show("Спочатку оберіть проект");
			}

			else
			{
				try
				{
					if (command.ExecuteNonQuery() == 1)
					{
						MessageBox.Show("Проект видалено");
						md.FillDGW("SELECT name_project FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", dataGridView_projects);
						textBoxMFP_name.Clear();
						textBoxMFP_cust.Clear();
					}
					else
					{
						MessageBox.Show("Помилка");
					}
				}
				catch
				{
					MessageBox.Show("Неможливо видалити проект, поки інформація про нього є в інших розділах");
				}
			}
			database.closeConnection();
		}


		// Форми додавання завдань та звітів
		private void buttonMFaddTask_Click(object sender, EventArgs e)
		{
			AddTask_Form taskForm = new AddTask_Form();
			taskForm.Show();
			this.Close();
		}

		
		private void buttonMFaddProj_Click(object sender, EventArgs e)
		{
			AddReport_Form projForm = new AddReport_Form();
			projForm.Show();
			this.Close();

		}

		
		// Перейти до завдань та звітів

		private void buttonMF_goRep_Click(object sender, EventArgs e)
		{
			panelMF_projects.Visible = false;
			panelMF_reports.Visible = true;
			md.FillDGW("SELECT `reports`.id_bug, `reports`.summary_bug FROM `reports`, `projects` " +
				"WHERE `reports`.id_project = `projects`.id_project AND " +
				"`projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", dataGridViewMF_reports);
			fillReports(label_ReportID.Text);
			dataGridViewMF_reports.Columns[0].Visible = false;
			
		}

		private void buttonMF_goTaskRep_Click(object sender, EventArgs e)
		{
			panelMF_projects.Visible = false;
			panelMF_tasks.Visible = true;
			md.FillDGW("SELECT `tasks`.id_task, `tasks`.name_task, `projects`.name_project, `tasks`.status_task " +
				"FROM `tasks`, `projects`, `users` " +
				"WHERE `tasks`.id_project = `projects`.id_project " +
				"AND `projects`.id_user = `users`.id_user " +
				"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", dataGridViewMF_tasks);
			md.FillCB(comboBoxMF_taskproject, "SELECT * FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", "name_project");
			fillTasks(label_TaskID.Text);
			dataGridViewMF_tasks.Columns[0].Visible = false;
		}

		// Обробка завдань і звітів в проектах

		private void dataGridViewMF_projTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			buttonMF_goTaskRep.BackColor = Color.DarkSlateGray;
			buttonMF_goTaskRep.Enabled = true;
			label_TaskID.Text = dataGridViewMF_projTasks.CurrentRow.Cells[0].Value.ToString();
		}

		private void dataGridViewMF_projReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			buttonMF_goRep.BackColor = Color.DarkSlateGray;
			buttonMF_goRep.Enabled = true;
			label_ReportID.Text = dataGridViewMF_projReports.CurrentRow.Cells[0].Value.ToString();
		}


		/// <summary>******************************************************************************************
		/// панель TASKS
		/// </summary>*****************************************************************************************
		/// Вивід

		private void dataGridViewMF_tasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			fillTasks(dataGridViewMF_tasks.CurrentRow.Cells[0].Value.ToString());
		}

		public void fillTasks(string id)
		{
			DataBase db = new DataBase();
			string selectQuery = "SELECT `tasks`.name_task, `tasks`.description_task, `projects`.name_project, `tasks`.status_task, `tasks`.startdate_task, `tasks`.enddate_task " +
				"FROM `tasks`, `projects` WHERE `tasks`.id_task = '" + id + "' AND `tasks`.id_project = `projects`.id_project"; // запит

			db.openConnection();

			MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());
			MySqlDataReader reader = command.ExecuteReader();

			if (reader.Read()) // якщо є дані для читання
			{
				string name = reader.GetString("name_task");
				string description = reader.GetString("description_task");
				string project = reader.GetString("name_project");
				string status = reader.GetString("status_task");
				string start = reader.GetString("startdate_task");
				string end = reader.GetString("enddate_task");

				textBoxMF_taskname.Text = name;
				textBoxMF_taskdescription.Text = description;
				comboBoxMF_taskproject.Text = project;
				comboBoxMF_taskstatus.Text = status;
				dateMF_taskstart.Text = start;
				dateMF_taskend.Text = end;
			}
			else // якщо нема даних для читання
			{
				MessageBox.Show("Даних не знайдено"); // вивести повідомлення
			}

			db.closeConnection();
		}

		// Додати оновити та видалити дані

		private void buttonMF_addTask_Click(object sender, EventArgs e)
		{
			AddTask_Form addtask = new AddTask_Form();
			addtask.Show();
			this.Close();
		}

		private void buttonMF_updateTask_Click(object sender, EventArgs e)
		{
			DataBase database = new DataBase();
			string id = label_TaskID.Text;
			if (id.Equals("")) { id = dataGridViewMF_tasks.CurrentRow.Cells[0].Value.ToString(); }
			string status = comboBoxMF_taskstatus.Text;
			if (comboBoxMF_taskstatus.Text.Equals("Статус")){ status = ""; }

			MySqlCommand command = new MySqlCommand("UPDATE `tasks` SET " +
				"name_task = @name, description_task = @description, id_project = (SELECT id_project FROM `projects` WHERE name_project = @project), " +
                "status_task = @status, startdate_task = @start, enddate_task = @end " +
				"WHERE id_task = '" + id + "'", database.getConnection());

			command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxMF_taskname.Text;
			command.Parameters.Add("@description", MySqlDbType.VarChar).Value = textBoxMF_taskdescription.Text;
			command.Parameters.Add("@project", MySqlDbType.VarChar).Value = comboBoxMF_taskproject.Text;
			command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
			command.Parameters.Add("@start", MySqlDbType.VarChar).Value = dateMF_taskstart.Text;
			command.Parameters.Add("@end", MySqlDbType.VarChar).Value = dateMF_taskend.Text;


			database.openConnection();

			if (textBoxMF_taskname.Text.Equals(""))
			{
				MessageBox.Show("Введіть назву завдання");
			}
			else
			{
				try
				{
					if (command.ExecuteNonQuery() == 1)
					{
						MessageBox.Show("Дані змінено успішно");
						textBoxMF_taskname.Clear();
						textBoxMF_taskdescription.Clear();
						comboBoxMF_taskstatus.SelectedIndex = -1;
						comboBoxMF_taskproject.SelectedIndex = -1;

						md.FillDGW("SELECT `tasks`.id_task, `tasks`.name_task, `projects`.name_project, `tasks`.status_task " +
						"FROM `tasks`, `projects`, `users` " +
						"WHERE `tasks`.id_project = `projects`.id_project " +
						"AND `projects`.id_user = `users`.id_user " +
						"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", dataGridViewMF_tasks);
					}
				}
				catch
				{
					MessageBox.Show("Помилка");
				}
			}
			database.closeConnection();
		}

		private void buttonMF_deleteTask_Click(object sender, EventArgs e)
		{
			DataBase database = new DataBase();
			string id = label_TaskID.Text;
			if (id.Equals("")) { id = dataGridViewMF_tasks.CurrentRow.Cells[0].Value.ToString(); }

			MySqlCommand command = new MySqlCommand("DELETE FROM `tasks` WHERE id_task = '"+ id + "'", database.getConnection());

			database.openConnection();

			if (textBoxMF_taskname.Text.Equals(""))
			{
				MessageBox.Show("Спочатку оберіть завдання");
			}
			else
			{
				try
				{
					if (command.ExecuteNonQuery() == 1)
					{
						MessageBox.Show("Завдання видалено");
						md.FillDGW("SELECT `tasks`.id_task, `tasks`.name_task, `projects`.name_project, `tasks`.status_task " +
						"FROM `tasks`, `projects`, `users` " +
						"WHERE `tasks`.id_project = `projects`.id_project " +
						"AND `projects`.id_user = `users`.id_user " +
						"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", dataGridViewMF_tasks);
						textBoxMF_taskname.Clear();
						textBoxMF_taskdescription.Clear();
						comboBoxMF_taskproject.SelectedIndex = -1;
						comboBoxMF_taskstatus.SelectedIndex = -1;
						dateMF_taskend.Value = DateTime.Now;
						dateMF_taskstart.Value = DateTime.Now;
					}
				}
					catch
					{
						MessageBox.Show("Помилка");
					}
				
			}
			database.closeConnection();
		}

		// Пошук по завданнях

		private void textBoxMF_taskSearch_TextChanged(object sender, EventArgs e)
		{
			string datasearch = textBoxMF_taskSearch.Text;
			md.FillDGW("SELECT `tasks`.id_task, `tasks`.name_task, `projects`.name_project, `tasks`.status_task " +
				"FROM `tasks`, `projects`, `users` " +
				"WHERE (`tasks`.name_task LIKE '%" + datasearch + "%' OR `projects`.name_project LIKE '%" + datasearch + "%') " +
				"AND `tasks`.id_project = `projects`.id_project " +
				"AND `projects`.id_user = `users`.id_user " +
				"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", dataGridViewMF_tasks);
		}

		private void comboBoxMF_statusTask_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (comboBoxMF_statusTask.Text.Equals("всі"))
			{
				md.FillDGW("SELECT `tasks`.id_task, `tasks`.name_task, `projects`.name_project, `tasks`.status_task " +
						"FROM `tasks`, `projects`, `users` " +
						"WHERE `tasks`.id_project = `projects`.id_project " +
						"AND `projects`.id_user = `users`.id_user " +
                        "AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", dataGridViewMF_tasks);

			}
			else
			{
				md.FillDGW("SELECT `tasks`.id_task, `tasks`.name_task, `projects`.name_project, `tasks`.status_task " +
					"FROM `tasks`, `projects`, `users` " +
					"WHERE `tasks`.id_project = `projects`.id_project " +
					"AND `projects`.id_user = `users`.id_user " +
					"AND `tasks`.status_task = '" + comboBoxMF_statusTask.Text + "' " +
					"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", dataGridViewMF_tasks);
			}
			}



		/// <summary>******************************************************************************
		/// панель REPORTS
		/// </summary>*****************************************************************************
		/// Вивід

		private void dataGridViewMF_reports_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			fillReports(dataGridViewMF_reports.CurrentRow.Cells[0].Value.ToString());
		}

		public void fillReports(string id)
		{
			DataBase db = new DataBase();

			string selectQuery = "SELECT id_bug, summary_bug, platform_bug, environment_bug, steps_bug, actualresult_bug, expectedresult_bug, notes_bug " +
				"FROM reports WHERE id_bug = '" + id + "'"; // запит

			db.openConnection();

			MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());
			MySqlDataReader reader = command.ExecuteReader();

			try
			{
				if (reader.Read()) 
				{
					string summary = reader.GetString("summary_bug");
					string platform = reader.GetString("platform_bug");
					string environment = reader.GetString("environment_bug");
					string steps = reader.GetString("steps_bug");
					string actualres = reader.GetString("actualresult_bug");
					string expectedres = reader.GetString("expectedresult_bug");
					string notes = reader.GetString("notes_bug");

					textBoxMF_repname.Text = summary;
					textBoxMF_repEnv.Text = environment;
					textBoxMF_repPlatform.Text = platform;
					textBox_repstep.Text = steps;
					textBoxMF_repActRes.Text = actualres;
					textBoxMF_repExpRes.Text = expectedres;
					textBoxMF_repnotes.Text = notes;
				}
			}
			catch 
			{
				MessageBox.Show("Даних не знайдено"); 

			}

			db.closeConnection();
		}

		// Додати оновити і видалити репорти

		private void buttonMF_addReport_Click(object sender, EventArgs e)
		{
			AddReport_Form addrep = new AddReport_Form();
			addrep.Show();
			this.Close();
		}

		private void buttonMF_deleteReport_Click(object sender, EventArgs e)
		{
			DataBase database = new DataBase();
			string id = label_ReportID.Text;
			if (id.Equals("")) { id = dataGridViewMF_reports.CurrentRow.Cells[0].Value.ToString(); }


			MySqlCommand command = new MySqlCommand("DELETE FROM `reports` WHERE id_bug = '" + id + "'", database.getConnection());

			database.openConnection();

			if (id == null)
			{
				MessageBox.Show("Спочатку оберіть звіт");
			}
			else
			{
				try
				{
					if (command.ExecuteNonQuery() == 1)
					{
						MessageBox.Show("Звіт видалено");
						textBoxMF_repname.Clear();
						textBoxMF_repPlatform.Clear();
						textBoxMF_repEnv.Clear();
						textBox_repstep.Clear();
						textBoxMF_repActRes.Clear();
						textBoxMF_repExpRes.Clear();
						textBoxMF_repnotes.Clear();

						md.FillDGW("SELECT `reports`.id_bug, `reports`.summary_bug FROM `reports`, `projects` " +
						"WHERE `reports`.id_project = `projects`.id_project AND " +
						"`projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", dataGridViewMF_reports);


					}
					else
					{
						MessageBox.Show("Помилка");
					}
				}
				catch
				{
					MessageBox.Show("Неможливо видалити звіт, поки інформація про нього є в інших розділах");
				}
			}
			database.closeConnection();
		}

		private void buttonMF_updateReport_Click(object sender, EventArgs e)
		{
			DataBase database = new DataBase();
			string id = label_ReportID.Text;
			if (id.Equals("")) { id = dataGridViewMF_reports.CurrentRow.Cells[0].Value.ToString(); }

			MySqlCommand command = new MySqlCommand("UPDATE `reports` SET " +
				"summary_bug = @summary, platform_bug = @platform, environment_bug = @env, steps_bug = @steps, " +
				"actualresult_bug = @actual, expectedresult_bug = @expect, notes_bug = @notes " +
				"WHERE id_bug = '" + id + "'", database.getConnection());

			command.Parameters.Add("@summary", MySqlDbType.VarChar).Value = textBoxMF_repname.Text;
			command.Parameters.Add("@platform", MySqlDbType.VarChar).Value = textBoxMF_repPlatform.Text;
			command.Parameters.Add("@env", MySqlDbType.VarChar).Value = textBoxMF_repEnv.Text;
			command.Parameters.Add("@steps", MySqlDbType.VarChar).Value = textBox_repstep.Text;
			command.Parameters.Add("@actual", MySqlDbType.VarChar).Value = textBoxMF_repActRes.Text;
			command.Parameters.Add("@expect", MySqlDbType.VarChar).Value = textBoxMF_repExpRes.Text;
			command.Parameters.Add("@notes", MySqlDbType.VarChar).Value = textBoxMF_repnotes.Text;


			database.openConnection();

			if (textBoxMF_repname.Equals(""))
			{
				MessageBox.Show("Введіть ім'я звіту");
			}
			else
			{
				try
				{
					if (command.ExecuteNonQuery() == 1)
					{
						MessageBox.Show("Дані змінено успішно");
						textBoxMF_repname.Clear();
						textBoxMF_repPlatform.Clear();
						textBoxMF_repEnv.Clear();
						textBox_repstep.Clear();
						textBoxMF_repActRes.Clear();
						textBoxMF_repExpRes.Clear();
						textBoxMF_repnotes.Clear();

						md.FillDGW("SELECT `reports`.id_bug, `reports`.summary_bug FROM `reports`, `projects` " +
						"WHERE `reports`.id_project = `projects`.id_project AND " +
						"`projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", dataGridViewMF_reports);


					}
				}
				catch
				{
					MessageBox.Show("Помилка");
				}
			}
			database.closeConnection();
		}

		// Пошук репортів

		private void textBoxMF_searchReport_TextChanged(object sender, EventArgs e)
		{
			string datasearch = textBoxMF_searchReport.Text;
			md.FillDGW("SELECT `reports`.id_bug, `reports`.summary_bug " +
				"FROM `reports`, `projects`, `users` " +
				"WHERE `reports`.summary_bug LIKE '%" + datasearch + "%' " +
				"AND `reports`.id_project = `projects`.id_project " +
				"AND `projects`.id_user = `users`.id_user " +
				"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.UserName + "')", dataGridViewMF_reports);

		}
		
		// Форма створення звіту

        private void buttonMF_createDoc_Click(object sender, EventArgs e)
        {
			SaveReport_Form rep = new SaveReport_Form();
			rep.Show();
			this.Close();
        }

    }
}
