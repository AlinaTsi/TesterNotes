using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace TesterNotes
{
	class DataBase
	{

        // Рядок підключення

        private MySqlConnection connection = new MySqlConnection
            (
            "server=localhost;" +
            "port=3306;" +
            "username=root;" +
            "password=;" +
            "database=testerdatabase;" +
            "charset= utf8;" +
            "Allow User Variables=True"
            );

        // Відкриття з'єднання

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Закриття з'єднання

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Повернення з'єднання

        public MySqlConnection getConnection()
        {
            return connection;
        }

    }
}
