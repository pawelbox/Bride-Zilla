using MySqlConnector;
using System;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text;

namespace Bride_Zilla
{

    class ConnectionString
    {
        //Just add your MySql Connection data here
        public string server = "sql70.lh.pl";
        public string database = "serwer117140_customer ";
        public string uid = "serwer117140_customer ";
        public string pwd = "#Trudne021!";
        public MySql.Data.MySqlClient.MySqlConnection con { get; set; }
        public void Connect()
        {
            Read red = new Read();
            red.GetRead();
            ConnectionString connection = new ConnectionString();
            
            con = new MySql.Data.MySqlClient.MySqlConnection(red.read);
            //con = new MySql.Data.MySqlClient.MySqlConnection("server=" + connection.server + ";user=" + connection.uid + ";database=" + connection.database +
            //";password=" + connection.pwd + ";");
        }
    }
}
