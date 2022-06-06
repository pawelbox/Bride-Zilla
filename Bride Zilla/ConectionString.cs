using MySql.Data.MySqlClient;
using System;

namespace WindowsFormsApp1
{
    class ConectionString
    {
        public string server = "sql70.lh.pl";
        public string database = "serwer117140_customer";
        public string uid = "*********";
        public string pwd = "********";
        public MySqlConnection con { get; set; }
        public void Connect()
        {
            ConectionString connection = new ConectionString();
            con = new MySqlConnection("server=" + connection.server + ";user=" + connection.uid + ";database=" + connection.database +
                    ";password=" + connection.pwd + ";");
        }
    }
}
