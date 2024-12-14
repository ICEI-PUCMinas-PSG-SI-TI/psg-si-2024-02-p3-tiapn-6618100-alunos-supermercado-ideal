using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Supermercado_Windows_Form
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Caixa_Eletrônico());
            //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MinhaConexao"].ConnectionString);
            
        }
}
    }

