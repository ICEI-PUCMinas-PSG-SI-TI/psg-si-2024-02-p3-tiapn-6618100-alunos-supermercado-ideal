using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Supermercado_Windows_Form
{
    public class DatabaseConnection
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString;
            return new MySqlConnection(connectionString);
        }
    }
}
