using MySqlConnector;
using System;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bride_Zilla
{

    class ConnectionString
    {
        //Just add your MySql Connection data here
        public MySql.Data.MySqlClient.MySqlConnection con { get; set; }
        public void Connect()
        {
            try
            {
                Read red = new Read();
                red.GetRead();
                ConnectionString connection = new ConnectionString();
                                con = new MySql.Data.MySqlClient.MySqlConnection(red.read);
            }
           catch (NullReferenceException Exception )
            {
                MessageBox.Show("Brak właściowści połączenia. Dodaj je w ustawieniach.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
