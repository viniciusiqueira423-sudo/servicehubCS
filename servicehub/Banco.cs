using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ServiceHubClass;

namespace servicehub
{
    public static class Banco

    {
        //string de conexão com o banco de dados (MAriaDB)
        public static string? StrConn { get; set; }


    //metodo para abrir conexão com o banco - entraga uma conexão aberta, no objeto de 
    //no um objeto de comandos sql (um objeto do tipo MySql  Command)
    public static MySqlCommand Abrir(string strconn = "") 
        {
            MySqlCommand cmd = new MySqlCommand();
            StrConn = strconn;
            if(StrConn == string.Empty)
                StrConn = $@"server=10.91.47.44;database=comercialti101;user=root;password=P@ssw0rd";

            MySqlConnection cn = new(StrConn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cmd;
        }


    }
}
