using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Colocando_em_pratica
{
    public class Conectado
    {
        private static string stringConn = "Server=localhost;port=3306;Database=dbFuncionario;Uid=root;Pwd=''";
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection(stringConn);
            try
            {
                conn.Open();
            }
            catch (MySqlException)
            {
                conn = null;
            }
            return conn; 
        }
        public static void fechaConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
