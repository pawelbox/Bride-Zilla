﻿using MySqlConnector;
using System;
using MySql.Data.MySqlClient;

namespace Bride_Zilla
{
    class ConnectionString
    {
        public string server = "sql70.lh.pl";
        public string database = "serwer117140_customer";
        public string uid = "serwer117140_customer";
        public string pwd = "!Trudne021";
        public MySql.Data.MySqlClient.MySqlConnection con { get; set; }
        public void Connect()
        {
            ConnectionString connection = new ConnectionString();
            con = new MySql.Data.MySqlClient.MySqlConnection("server=" + connection.server + ";user=" + connection.uid + ";database=" + connection.database +
                    ";password=" + connection.pwd + ";");
        }
    }
}
