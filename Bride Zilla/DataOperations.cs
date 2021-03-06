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
        public int ID { get; set; }
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
        public int pase { get; set; }
        public string wedPaid { get; set; }
        public int pendrive { get; set; }

        public int year { get; set; }
        public string month { get; set; }
        public string source { get; set; }
        public string date { get; set; }
        public int qoute { get; set; }
        public string meeting { get; set; }
        public string contract { get; set; }
        public string name { get; set; }

        public string size { get; set; }
        public int estate { get; set; }
        public int reserv { get; set; }
        public int av { get; set; }

        public string type { get; set; }
        public string content { get; set; }
        public string expired { get; set; }
        public string realised { get; set; }
        public int price { get; set; }

        public void Insert(string command,string table, string value)
        {
            ConnectionString connect = new ConnectionString();
            connect.Connect();
            connect.con.Open();

            MySqlCommand insert = new MySqlCommand(command + table + value);

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
            insert.Parameters.AddWithValue("@year", year);
            insert.Parameters.AddWithValue("@month", month);
            insert.Parameters.AddWithValue("@source", source);
            insert.Parameters.AddWithValue("@date", date);
            insert.Parameters.AddWithValue("@qoute", qoute);
            insert.Parameters.AddWithValue("@meeting", meeting);
            insert.Parameters.AddWithValue("@contract", contract);
            insert.Parameters.AddWithValue("@name", name);

            insert.Parameters.AddWithValue("@type", type);
            insert.Parameters.AddWithValue("@price", price);
            insert.Parameters.AddWithValue("@content", content);
            insert.Parameters.AddWithValue("@expired", expired);
            insert.Parameters.AddWithValue("@realised", realised);

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
        public void Update(string table, string value)
        {
            ConnectionString connect = new ConnectionString();
            connect.Connect();
            connect.con.Open();

            MySqlCommand update = new MySqlCommand("UPDATE " + table + value);

            update.Parameters.AddWithValue("@ID", ID);
            update.Parameters.AddWithValue("@bride", bride);
            update.Parameters.AddWithValue("@brideAdress", brideAdress);
            update.Parameters.AddWithValue("@bridePhone", bridePhone);
            update.Parameters.AddWithValue("@groom", groom);
            update.Parameters.AddWithValue("@groomAdress", groomAdress);
            update.Parameters.AddWithValue("@groomPhone", groomPhone);
            update.Parameters.AddWithValue("@weddingDate", weddingDate);
            update.Parameters.AddWithValue("@weddingPlace", weddingPlace);

            update.Parameters.AddWithValue("@jurnal", jurnal);
            update.Parameters.AddWithValue("@sesion", sesion);
            update.Parameters.AddWithValue("@engagment", engag);
            update.Parameters.AddWithValue("@engPaid", engagPaid);
            update.Parameters.AddWithValue("@photobook", photobook);
            update.Parameters.AddWithValue("@extraPhoto", extraPhotobook);
            update.Parameters.AddWithValue("@paint", paint);
            update.Parameters.AddWithValue("@prints", prints);
            update.Parameters.AddWithValue("@guestPaid", guestPaid);
            update.Parameters.AddWithValue("@guestToPay", guestToPay);
            update.Parameters.AddWithValue("@travel", travel);
            update.Parameters.AddWithValue("@wedPaid", wedPaid);
            update.Parameters.AddWithValue("@pase", pase);
            update.Parameters.AddWithValue("@pendrive", pendrive);

            update.Parameters.AddWithValue("@year", year);
            update.Parameters.AddWithValue("@month", month);
            update.Parameters.AddWithValue("@source", source);
            update.Parameters.AddWithValue("@date", date);
            update.Parameters.AddWithValue("@qoute", qoute);
            update.Parameters.AddWithValue("@meeting", meeting);
            update.Parameters.AddWithValue("@contract", contract);
            update.Parameters.AddWithValue("@name", name);

            update.Parameters.AddWithValue("@size", size);
            update.Parameters.AddWithValue("@estate", estate);
            update.Parameters.AddWithValue("@reserv", reserv);
            update.Parameters.AddWithValue("@av", estate-reserv);

            update.Parameters.AddWithValue("@type", type);
            update.Parameters.AddWithValue("@price", price);
            update.Parameters.AddWithValue("@content", content);
            update.Parameters.AddWithValue("@expired", expired);
            update.Parameters.AddWithValue("@realised", realised);

            update.Connection = connect.con;
            update.ExecuteNonQuery();
            connect.con.Close();
        }
    }
}

