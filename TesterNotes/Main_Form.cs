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
			Message message = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref message);
		}

		Methods methods = new Methods();
				

		private void button_exit_Click(object sender, EventArgs e)
		{
			methods.exit(this);
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
			label_ReportID.Text = "";
		}

		private void buttonMF_tasks_Click(object sender, EventArgs e)
		{
			showTasks();
			label_TaskID.Text = "";
		}

		private void buttonAccount_Click(object sender, EventArgs e)
		{
			Account_Form accountForm = new Account_Form();
			accountForm.Show();
			this.Close();
		}

		/// <summary>
		/// Методи виводу даних для панелей
		/// </summary>
		public void showProjects()
		{
			string user = Info.userName;
			panelMF_projects.Visible = true;
			panelMF_tasks.Visible = false;
			panelMF_reports.Visible = false;
			methods.fillDataGW("SELECT name_project FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '" + user + "')", dataGridView_projects);
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
			methods.fillDataGW("SELECT `tasks`.id_task, `tasks`.name_task FROM `tasks`, `projects`, `users` " +
				"WHERE `tasks`.id_project = `projects`.id_project " +
				"AND `projects`.id_user = `users`.id_user " +
				"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "') " +
				"ORDER BY `tasks`.priority_task ASC", dataGridViewMF_tasks);
			methods.fillComboBox(comboBoxMF_taskproject, "SELECT * FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "')", "name_project");
			dataGridViewMF_tasks.Columns[0].Width = 30;
			textBoxMF_taskname.BackColor = Color.White;
			label_forTime.Visible = false;
		}

		public void showReports()
		{
			panelMF_projects.Visible = false;
			panelMF_tasks.Visible = false;
			panelMF_reports.Visible = true;
			label_ReportID.Text = "";
			methods.fillDataGW("SELECT `reports`.id_bug, `reports`.summary_bug FROM `reports`, `projects` " +
				"WHERE `reports`.id_project = `projects`.id_project AND " +
				"`projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "')", dataGridViewMF_reports);
			dataGridViewMF_reports.Columns[0].Width = 30;
		}

		
		/// <summary>*************************************************************************************
		/// панель PROJECTS
		/// </summary>************************************************************************************
		/// Вивід

		private void dataGridView_projects_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
			DataBase database = new DataBase();
			string projectName = dataGridView_projects.CurrentRow.Cells[0].Value.ToString();


			string selectQuery = "SELECT * FROM projects WHERE name_project = '" + projectName + "'"; // запит
			string selectQueryTasks = "SELECT id_task, name_task FROM tasks WHERE id_project = (SELECT id_project FROM projects WHERE name_project = '" + projectName + "')";
			string selectQueryReports = "SELECT id_bug, summary_bug FROM reports WHERE id_project = (SELECT id_project FROM projects WHERE name_project = '" + projectName + "')";

			database.openConnection();

			MySqlCommand command = new MySqlCommand(selectQuery, database.getConnection());
			MySqlDataReader reader = command.ExecuteReader();

			
				if (reader.Read())
				{
					string cproject = reader.GetString("customer_project");
					string idproj = reader.GetString("id_project");
					Info.idProject = reader.GetInt32("id_project");
					textBoxMFP_name.Text = projectName;
					textBoxMFP_cust.Text = cproject;
					methods.fillDataGW(selectQueryTasks, dataGridViewMF_projTasks);
					methods.fillDataGW(selectQueryReports, dataGridViewMF_projReports);
					dataGridViewMF_projReports.Columns[0].Visible = false;
					dataGridViewMF_projTasks.Columns[0].Visible = false;
				}
				else // якщо нема даних для читання
				{
					MessageBox.Show("Даних не знайдено."); // вивести повідомлення
				}
				database.closeConnection();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Помилка: " + exception.Message);
			}

			
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
			AddProject_Form addProjectForm = new AddProject_Form();
			addProjectForm.Show();
			this.Close();
		}

		private void buttonMFP_update_Click(object sender, EventArgs e)
		{
			try
			{
				DataBase database = new DataBase();

				MySqlCommand command = new MySqlCommand("UPDATE `projects` SET " +
					"name_project = @project, customer_project = @customer " +
					"WHERE id_project = '" + Info.idProject + "'", database.getConnection());

				command.Parameters.Add("@project", MySqlDbType.VarChar).Value = textBoxMFP_name.Text;
				command.Parameters.Add("@customer", MySqlDbType.VarChar).Value = textBoxMFP_cust.Text;

				database.openConnection();

				if (Info.idProject.Equals(""))
				{
					MessageBox.Show("Спочатку оберіть проект.");
				}
				else if (textBoxMFP_name.Equals(""))
				{
					MessageBox.Show("Спочатку оберіть проект та відредагуйте інформацію.");
				}
				else if (command.ExecuteNonQuery() == 1)
				{
					try
					{
						MessageBox.Show("Дані змінено успішно.");
						textBoxMFP_cust.Clear();
						textBoxMFP_name.Clear();
						methods.fillDataGW("SELECT name_project FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "')", dataGridView_projects);
					}
					catch (Exception exception)
					{
						MessageBox.Show("Помилка: " + exception.Message);
					}

				}
				else
				{
					MessageBox.Show("Спочатку оберіть дані.");
				}
				database.closeConnection();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Не вдалось підключитись до бази даних. Перевірте підключення до Інтернету, налаштування проксі-сервера та брандмауера. " + exception.Message);
			}
			

		}

		private void buttonMFP_delete_Click(object sender, EventArgs e)
		{
			try
			{
				DataBase database = new DataBase();
				MySqlCommand command = new MySqlCommand("DELETE FROM `projects` WHERE id_project = '" + Info.idProject + "'", database.getConnection());

				database.openConnection();

				if (Info.idProject.Equals(""))
				{
					MessageBox.Show("Спочатку оберіть проект.");
				}
				else if (command.ExecuteNonQuery() == 1)
				{
					try
					{
						MessageBox.Show("Проект видалено.");
						methods.fillDataGW("SELECT name_project FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "')", dataGridView_projects);
						textBoxMFP_name.Clear();
						textBoxMFP_cust.Clear();
					}
					catch (Exception exception)
					{
						MessageBox.Show("Помилка: " + exception.Message);
					}
				}
				else
				{
					MessageBox.Show("Спочатку оберіть дані.");
				}
				database.closeConnection();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Не вдалось підключитись до бази даних. Перевірте підключення до Інтернету, налаштування проксі-сервера та брандмауера. " + exception.Message);
			}
			
		}

				
		// Перейти до завдань та звітів

		private void buttonMF_goRep_Click(object sender, EventArgs e)
		{
			panelMF_projects.Visible = false;
			panelMF_reports.Visible = true;
			methods.fillDataGW("SELECT `reports`.id_bug, `reports`.summary_bug FROM `reports`, `projects` " +
				"WHERE `reports`.id_project = `projects`.id_project AND " +
				"`projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "')", dataGridViewMF_reports);
			
			fillReports(label_ReportID.Text);
			dataGridViewMF_reports.Columns[0].Width = 30;
		}

		private void buttonMF_goTaskRep_Click(object sender, EventArgs e)
		{
			panelMF_projects.Visible = false;
			panelMF_tasks.Visible = true;
			methods.fillDataGW("SELECT `tasks`.id_task, `tasks`.name_task " +
				"FROM `tasks`, `projects`, `users` " +
				"WHERE `tasks`.id_project = `projects`.id_project " +
				"AND `projects`.id_user = `users`.id_user " +
				"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "') " +
				"ORDER BY `tasks`.priority_task ASC", dataGridViewMF_tasks);
			
			methods.fillComboBox(comboBoxMF_taskproject, "SELECT * FROM `projects` WHERE id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "')", "name_project");
			checkDate();
			fillTasks(label_TaskID.Text);
			dataGridViewMF_tasks.Columns[0].Width = 30;
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
			checkDate();
			label_TaskID.Text = dataGridViewMF_tasks.CurrentRow.Cells[0].Value.ToString();
		}

		public void checkDate()
        {
			DateTime today = DateTime.Today;
			DateTime time = dateMF_taskend.Value.Date;
			if (today > time && comboBoxMF_taskstatus.Text == "відкрито")
            {
				textBoxMF_taskname.BackColor = Color.MistyRose;
				label_forTime.Visible = true;
            }
            else
            {
				textBoxMF_taskname.BackColor = Color.White;
				label_forTime.Visible = false;
			}
        }

		private void textBoxMF_taskname_Click(object sender, EventArgs e)
		{
			textBoxMF_taskname.BackColor = Color.White;
			label_forTime.Visible = false;
		}

		public void fillTasks(string id)
		{
			DataBase database = new DataBase();
			string selectQuery = "SELECT `tasks`.name_task, `tasks`.description_task, `projects`.name_project, `tasks`.status_task, `tasks`.priority_task, `tasks`.enddate_task " +
				"FROM `tasks`, `projects` WHERE `tasks`.id_task = '" + id + "' AND `tasks`.id_project = `projects`.id_project";

			database.openConnection();

			MySqlCommand command = new MySqlCommand(selectQuery, database.getConnection());
			MySqlDataReader reader = command.ExecuteReader();

			if (reader.Read())
			{
				string name = reader.GetString("name_task");
				string description = reader.GetString("description_task");
				string project = reader.GetString("name_project");
				string status = reader.GetString("status_task");
				string priority = reader.GetString("priority_task");
				string end = reader.GetString("enddate_task");

				textBoxMF_taskname.Text = name;
				textBoxMF_taskdescription.Text = description;
				comboBoxMF_taskproject.Text = project;
				comboBoxMF_taskstatus.Text = status;
				comboBoxMF_prioritytask.Text = priority;
				dateMF_taskend.Text = end;
			}
			else
			{
				MessageBox.Show("Даних не знайдено.");
			}

			database.closeConnection();
		}

		// Додати оновити та видалити дані

		private void buttonMF_addTask_Click(object sender, EventArgs e)
		{
			AddTask_Form addTaskForm = new AddTask_Form();
			addTaskForm.Show();
			this.Close();
		}

		private void buttonMF_updateTask_Click(object sender, EventArgs e)
		{
			try
			{
				DataBase database = new DataBase();
				string id = label_TaskID.Text;
				string status = comboBoxMF_taskstatus.Text;
				string priority = comboBoxMF_prioritytask.Text;
				if (comboBoxMF_taskstatus.Text.Equals("Статус")) { status = "відкрито"; }
				if (comboBoxMF_prioritytask.Text.Equals("")) { priority = "0"; }

				MySqlCommand command = new MySqlCommand("UPDATE `tasks` SET " +
					"name_task = @name, description_task = @description, id_project = (SELECT id_project FROM `projects` WHERE name_project = @project), " +
					"status_task = @status, priority_task = @priority, enddate_task = @end " +
					"WHERE id_task = '" + id + "'", database.getConnection());

				command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBoxMF_taskname.Text;
				command.Parameters.Add("@description", MySqlDbType.VarChar).Value = textBoxMF_taskdescription.Text;
				command.Parameters.Add("@project", MySqlDbType.VarChar).Value = comboBoxMF_taskproject.Text;
				command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
				command.Parameters.Add("@priority", MySqlDbType.VarChar).Value = priority;
				command.Parameters.Add("@end", MySqlDbType.VarChar).Value = dateMF_taskend.Text;


				database.openConnection();

				if (label_TaskID.Text.Equals(""))
				{
					MessageBox.Show("Спочатку оберіть дані.");
				}
				else if (textBoxMF_taskname.Text.Equals(""))
				{
					MessageBox.Show("Введіть назву завдання.");
				}
				else if (command.ExecuteNonQuery() == 1)
				{
					try
					{
						MessageBox.Show("Дані змінено успішно.");
						textBoxMF_taskname.Clear();
						textBoxMF_taskdescription.Clear();
						comboBoxMF_taskstatus.SelectedIndex = -1;
						comboBoxMF_taskproject.SelectedIndex = -1;
						comboBoxMF_prioritytask.SelectedIndex = -1;
						dateMF_taskend.Value = DateTime.Now;
						showTasks();
						label_TaskID.Text = "";
					}
					catch (Exception exception)
					{
						MessageBox.Show("Помилка: " + exception.Message);
					}
				}
				else
				{
					MessageBox.Show("Спочатку оберіть дані.");
				}

				database.closeConnection();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Не вдалось підключитись до бази даних. Перевірте підключення до Інтернету, налаштування проксі-сервера та брандмауера. " + exception.Message);
			}
			
		}

		private void buttonMF_deleteTask_Click(object sender, EventArgs e)
		{
			try
			{
				DataBase database = new DataBase();
				string id = label_TaskID.Text;

				MySqlCommand command = new MySqlCommand("DELETE FROM `tasks` WHERE id_task = '" + id + "'", database.getConnection());

				database.openConnection();


				if (label_TaskID.Text.Equals(""))
				{
					MessageBox.Show("Спочатку оберіть дані.");
				}
				else if (command.ExecuteNonQuery() == 1)
				{
					try
					{
						MessageBox.Show("Завдання видалено.");

						textBoxMF_taskname.Clear();
						textBoxMF_taskdescription.Clear();
						comboBoxMF_taskproject.SelectedIndex = -1;
						comboBoxMF_taskstatus.SelectedIndex = -1;
						dateMF_taskend.Value = DateTime.Now;
						showTasks();
						label_TaskID.Text = "";
					}
					catch (Exception exception)
					{
						MessageBox.Show("Помилка: " + exception.Message);
					}

				}
				else
				{
					MessageBox.Show("Спочатку оберіть дані.");
				}
				database.closeConnection();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Не вдалось підключитись до бази даних. Перевірте підключення до Інтернету, налаштування проксі-сервера та брандмауера. " + exception.Message);
			}
			
		}

		// Пошук по завданнях

		private void textBoxMF_taskSearch_TextChanged(object sender, EventArgs e)
		{
			string datasearch = textBoxMF_taskSearch.Text;
			methods.fillDataGW("SELECT `tasks`.id_task, `tasks`.name_task " +
				"FROM `tasks`, `projects`, `users` " +
				"WHERE (`tasks`.name_task LIKE '%" + datasearch + "%' ) " +
				"AND `tasks`.id_project = `projects`.id_project " +
				"AND `projects`.id_user = `users`.id_user " +
				"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "') " +
				"ORDER BY `tasks`.priority_task ASC", dataGridViewMF_tasks);
		}

		private void comboBoxMF_statusTask_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (comboBoxMF_statusTask.Text.Equals("всі"))
			{
				methods.fillDataGW("SELECT `tasks`.id_task, `tasks`.name_task " +
						"FROM `tasks`, `projects`, `users` " +
						"WHERE `tasks`.id_project = `projects`.id_project " +
						"AND `projects`.id_user = `users`.id_user " +
                        "AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "') " +
						"ORDER BY `tasks`.priority_task ASC", dataGridViewMF_tasks);

			}
			else
			{
				methods.fillDataGW("SELECT `tasks`.id_task, `tasks`.name_task " +
					"FROM `tasks`, `projects`, `users` " +
					"WHERE `tasks`.id_project = `projects`.id_project " +
					"AND `projects`.id_user = `users`.id_user " +
					"AND `tasks`.status_task = '" + comboBoxMF_statusTask.Text + "' " +
					"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "') " +
					"ORDER BY `tasks`.priority_task ASC", dataGridViewMF_tasks);
			}
			}



		/// <summary>******************************************************************************
		/// панель REPORTS
		/// </summary>*****************************************************************************
		/// Вивід

		private void dataGridViewMF_reports_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			fillReports(dataGridViewMF_reports.CurrentRow.Cells[0].Value.ToString());
			label_ReportID.Text = dataGridViewMF_reports.CurrentRow.Cells[0].Value.ToString();
		}

		public void fillReports(string id)
		{
			DataBase database = new DataBase();

			string selectQuery = "SELECT id_bug, summary_bug, platform_bug, environment_bug, steps_bug, actualresult_bug, expectedresult_bug, notes_bug " +
				"FROM reports WHERE id_bug = '" + id + "'";

			database.openConnection();

			MySqlCommand command = new MySqlCommand(selectQuery, database.getConnection());
			MySqlDataReader reader = command.ExecuteReader();

			try
			{
				if (reader.Read()) 
				{
					string summary = reader.GetString("summary_bug");
					string platform = reader.GetString("platform_bug");
					string environment = reader.GetString("environment_bug");
					string steps = reader.GetString("steps_bug");
					string actualResult = reader.GetString("actualresult_bug");
					string expectedResult = reader.GetString("expectedresult_bug");
					string notes = reader.GetString("notes_bug");

					textBoxMF_repname.Text = summary;
					textBoxMF_repEnv.Text = environment;
					textBoxMF_repPlatform.Text = platform;
					textBox_repstep.Text = steps;
					textBoxMF_repActRes.Text = actualResult;
					textBoxMF_repExpRes.Text = expectedResult;
					textBoxMF_repnotes.Text = notes;
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Помилка: " + exception.Message);
			}

			database.closeConnection();
		}

		// Додати оновити і видалити репорти

		private void buttonMF_addReport_Click(object sender, EventArgs e)
		{
			AddReport_Form addReportForm = new AddReport_Form();
			addReportForm.Show();
			this.Close();
		}

		private void buttonMF_deleteReport_Click(object sender, EventArgs e)
		{
			try
			{
				DataBase database = new DataBase();
				string id = label_ReportID.Text;

				MySqlCommand command = new MySqlCommand("DELETE FROM `reports` WHERE id_bug = '" + id + "'", database.getConnection());

				database.openConnection();

				if (label_ReportID.Text.Equals(""))
				{
					MessageBox.Show("Спочатку оберіть дані.");
				}
				else if (command.ExecuteNonQuery() == 1)
				{
					try
					{

						MessageBox.Show("Звіт видалено.");
						textBoxMF_repname.Clear();
						textBoxMF_repPlatform.Clear();
						textBoxMF_repEnv.Clear();
						textBox_repstep.Clear();
						textBoxMF_repActRes.Clear();
						textBoxMF_repExpRes.Clear();
						textBoxMF_repnotes.Clear();
						showReports();
						label_ReportID.Text = "";
					}
					catch (Exception exception)
					{
						MessageBox.Show("Помилка: " + exception.Message);
					}
				}
				else
				{
					MessageBox.Show("Спочатку оберіть дані.");
				}
				database.closeConnection();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Не вдалось підключитись до бази даних. Перевірте підключення до Інтернету, налаштування проксі-сервера та брандмауера. " + exception.Message);
			}
			
		}

		private void buttonMF_updateReport_Click(object sender, EventArgs e)
		{
			try
			{
				DataBase database = new DataBase();
				string id = label_ReportID.Text;

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

				if (label_ReportID.Text.Equals("")) { MessageBox.Show("Спочатку оберіть дані."); }
				else if (textBoxMF_repname.Equals(""))
				{
					MessageBox.Show("Введіть назву звіту.");
				}
				else if (command.ExecuteNonQuery() == 1)
				{
					try
					{
						MessageBox.Show("Дані змінено успішно.");
						textBoxMF_repname.Clear();
						textBoxMF_repPlatform.Clear();
						textBoxMF_repEnv.Clear();
						textBox_repstep.Clear();
						textBoxMF_repActRes.Clear();
						textBoxMF_repExpRes.Clear();
						textBoxMF_repnotes.Clear();
						showReports();
						label_ReportID.Text = "";

					}
					catch (Exception exception)
					{
						MessageBox.Show("Помилка: " + exception.Message);
					}
				}
				else
				{
					MessageBox.Show("Спочатку оберіть дані.");
				}
				database.closeConnection();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Не вдалось підключитись до бази даних. Перевірте підключення до Інтернету, налаштування проксі-сервера та брандмауера. " + exception.Message);
			}
			
		}

		// Пошук репортів

		private void textBoxMF_searchReport_TextChanged(object sender, EventArgs e)
		{
			string datasearch = textBoxMF_searchReport.Text;
			methods.fillDataGW("SELECT `reports`.id_bug, `reports`.summary_bug " +
				"FROM `reports`, `projects`, `users` " +
				"WHERE `reports`.summary_bug LIKE '%" + datasearch + "%' " +
				"AND `reports`.id_project = `projects`.id_project " +
				"AND `projects`.id_user = `users`.id_user " +
				"AND `projects`.id_user = (SELECT id_user FROM `users` WHERE login_user = '" + Info.userName + "')", dataGridViewMF_reports);

		}
		
		// Форма створення звіту

		private void buttonMF_createPdf_Click(object sender, EventArgs e)
		{
			SaveReport_Form reportForm = new SaveReport_Form();
			reportForm.Show();
			this.Close();
		}

        private void comboBoxMF_prioritytask_MouseMove(object sender, MouseEventArgs e)
        {
			toolTipPriority.SetToolTip(comboBoxMF_prioritytask, "1 - найвищий, 10 - найнижчий");
        }
    }
}
