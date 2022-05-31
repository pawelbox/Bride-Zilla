using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bride_Zilla
{
    class DataOperations
    {
        public string customerID { get; set; }
        public string bride { get; set; }
        public string brideAdress { get; set; }
        public string bridePhone { get; set; }
        public string groom { get; set; }
        public string groomAdress { get; set; }
        public string groomPhone { get; set; }
        public string weddingDate { get; set; }
        public string weddingPlace { get; set; }

        public int jurnal { get; set; }
        public int sesion { get; set; }
        public int engag { get; set; }
        public string engagPaid { get; set; }
        public int photobook { get; set; }
        public int extraPhotobook { get; set; }
        public int paint { get; set; }
        public int prints { get; set; }
        public int guestPaid { get; set; }
        public int guestToPay { get; set; }
        public int travel { get; set; }
        public string wedPaid { get; set; }

        public void Insert(string table, string value)
        {
            ConnectionString connect = new ConnectionString();
            connect.Connect();
            connect.con.Open();
                       
            MySqlCommand insert = new MySqlCommand("INSERT INTO " + table + value);

            insert.Parameters.AddWithValue("@ID", customerID);
            insert.Parameters.AddWithValue("@bride", bride);
            insert.Parameters.AddWithValue("@brideAdress", brideAdress);
            insert.Parameters.AddWithValue("@bridePhone", bridePhone);
            insert.Parameters.AddWithValue("@groom", groom);
            insert.Parameters.AddWithValue("@groomAdress", groomAdress);
            insert.Parameters.AddWithValue("@groomPhone", groomPhone);
            insert.Parameters.AddWithValue("@weddingDate", weddingDate);
            insert.Parameters.AddWithValue("@weddingPlace", weddingPlace);
            insert.Parameters.AddWithValue("@jurnal", jurnal);
            insert.Parameters.AddWithValue("@sesion", sesion);
            insert.Parameters.AddWithValue("@engag", engag);
            insert.Parameters.AddWithValue("@engagPaid", engagPaid);
            insert.Parameters.AddWithValue("@photo", photobook);
            insert.Parameters.AddWithValue("@extraPhoto", extraPhotobook);
            insert.Parameters.AddWithValue("@paint", paint);
            insert.Parameters.AddWithValue("@prints", prints);
            insert.Parameters.AddWithValue("@guestPaid", guestPaid);
            insert.Parameters.AddWithValue("@guestToPay", guestToPay);
            insert.Parameters.AddWithValue("@travel", travel);
            insert.Parameters.AddWithValue("@wedPaid", wedPaid);

            insert.Connection = connect.con;
            insert.ExecuteNonQuery();
            connect.con.Close();
        }
        public void Delete(string table, int ID)
        {
            ConnectionString connect = new ConnectionString();
            connect.Connect();
            connect.con.Open();
            MySqlCommand delete = new MySqlCommand("DELETE FROM " + table + " WHERE ID=" + ID);

            delete.Connection = connect.con;
            delete.ExecuteNonQuery();
            connect.con.Close();
        }
    }
}
