using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseNamespace
{
    public interface IDataBase
    {
        void OpenConnectDB();
        void CloseConnectDB();

        SqlConnection GetConnection();
    }
}
