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
        public MySql.Data.MySqlClient.MySqlConnection con { get; set; }
        public void Connect()
        {
            Read red = new Read();
            red.GetRead();
            ConnectionString connection = new ConnectionString();

            con = new MySql.Data.MySqlClient.MySqlConnection(red.read);
        }
    }
}
