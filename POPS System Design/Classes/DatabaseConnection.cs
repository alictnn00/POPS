using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace POPS_System_Design.Classes
{
    public class DatabaseConnection
    {
        private string connectionString =
        "server=misdb.wright.edu;database=w1038axc_production_system;uid=w1038axc;pwd=XtpAhK3c8YM;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
