using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseNamespace
{
    public class DataBase : IDataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-QONTBH7;Initial Catalog=HomeBookkeeping;Integrated Security=True");

        public void OpenConnectDB()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
                // MessageBox.Show("Соединение установлено!");
            }
        }

        public void CloseConnectDB()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
