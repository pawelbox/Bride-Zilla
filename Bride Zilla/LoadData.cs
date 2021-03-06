using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Bride_Zilla
{
    class LoadData
    {
        public DataSet data = new DataSet();
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
        public int toPay { get; set; }
        public int costs { get; set; }
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

        public void LoadGridData(string table)
        {
            ConnectionString connect = new ConnectionString();
            connect.Connect();
            connect.con.Open();
            MySqlCommand select = new MySqlCommand("SELECT * FROM " + table, connect.con);
            MySqlDataAdapter adap = new MySqlDataAdapter(select);
            adap.Fill(data);
            connect.con.Close();
        }
        public void LoadCustomerData(string table, string customerID)
        {
            ConnectionString connect = new ConnectionString();
            connect.Connect();
            connect.con.Open();
            MySqlCommand select = new MySqlCommand("SELECT * FROM " + table + " WHERE ID=@ID", connect.con);
            select.Parameters.AddWithValue("@ID", customerID);
            MySqlDataReader data = select.ExecuteReader();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    bride = data.GetString(1);
                    brideAdress = data.GetString(2);
                    bridePhone = data.GetString(3);
                    groom = data.GetString(4);
                    groomAdress = data.GetString(5);
                    groomPhone = data.GetString(6);
                    weddingDate = data.GetString(7);
                    weddingPlace = data.GetString(8);
                }
            }
            else
            {
                MessageBox.Show("Brak kartoteki: " + customerID, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            data.Close();
        }
        public void LoadBillData(string table, string customerID)
        {
            ConnectionString connect = new ConnectionString();
            connect.Connect();
            connect.con.Open();
            MySqlCommand select = new MySqlCommand("SELECT * FROM " + table + " WHERE ID=@ID", connect.con);
            select.Parameters.AddWithValue("@ID", customerID);
            MySqlDataReader idata = select.ExecuteReader();
            if (idata.HasRows)
            {
                while (idata.Read())
                {
                    jurnal = idata.GetInt32(1);
                    sesion = idata.GetInt32(2);
                    engag = idata.GetInt32(3);
                    engagPaid = idata.GetString(4);
                    photobook = idata.GetInt32(5);
                    extraPhotobook = idata.GetInt32(6);
                    paint = idata.GetInt32(7);
                    prints = idata.GetInt32(8);
                    guestPaid = idata.GetInt32(9);
                    guestToPay = idata.GetInt32(10);
                    travel = idata.GetInt32(11);
                    wedPaid = idata.GetString(12);
                    toPay = jurnal + sesion + engag + photobook + extraPhotobook + paint + prints + guestToPay + travel;
                }
                idata.Close();
            }
        }
        public void LoadCostsData(string table, string customerID)
        {
            ConnectionString connect = new ConnectionString();
            connect.Connect();
            connect.con.Open();
            MySqlCommand select = new MySqlCommand("SELECT * FROM " + table + " WHERE ID=@ID", connect.con);
            select.Parameters.AddWithValue("@ID", customerID);
            MySqlDataReader idata = select.ExecuteReader();
            if (idata.HasRows)
            {
                while (idata.Read())
                {
                    photobook = idata.GetInt32(1);
                    extraPhotobook = idata.GetInt32(2);
                    paint = idata.GetInt32(3);
                    prints = idata.GetInt32(4);
                    pase = idata.GetInt32(5);
                    travel = idata.GetInt32(6);
                    pendrive = idata.GetInt32(7);
                    costs = photobook + extraPhotobook + paint + prints + pase + travel + pendrive;
                }
                idata.Close();
            }
        }
        public void LoadStatisticData(string table, string customerID)
        {
            ConnectionString connect = new ConnectionString();
            connect.Connect();
            connect.con.Open();
            MySqlCommand select = new MySqlCommand("SELECT * FROM " + table + " WHERE ID=@ID", connect.con);
            select.Parameters.AddWithValue("@ID", customerID);
            MySqlDataReader data = select.ExecuteReader();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    year = data.GetInt32(1);
                    month = data.GetString(2);
                    source = data.GetString(3);
                    date = data.GetString(4);
                    qoute = data.GetInt32(5);
                    meeting = data.GetString(6);
                    contract = data.GetString(7);
                    name = data.GetString(8);
                }
                data.Close();
            }
        }
        public void LoadPaseData(string table, string customerID)
        {
            ConnectionString connect = new ConnectionString();
            connect.Connect();
            connect.con.Open();
            MySqlCommand select = new MySqlCommand("SELECT * FROM " + table + " WHERE ID=@ID", connect.con);
            select.Parameters.AddWithValue("@ID", customerID);
            MySqlDataReader data = select.ExecuteReader();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    size = data.GetString(1);
                    estate = data.GetInt32(2);
                    reserv = data.GetInt32(3);
                    av = data.GetInt32(4);
                }
            }
        }
        public void LoadVoucherData(string table, string customerID)
        {
            ConnectionString connect = new ConnectionString();
            connect.Connect();
            connect.con.Open();
            MySqlCommand select = new MySqlCommand("SELECT * FROM " + table + " WHERE ID=@ID", connect.con);
            select.Parameters.AddWithValue("@ID", customerID);
            MySqlDataReader data = select.ExecuteReader();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    name = data.GetString(1);
                    type = data.GetString(2);
                    content = data.GetString(3);
                    price = data.GetInt32(4);
                    expired = data.GetString(5);
                    realised = data.GetString(6);
                }
            }
        }
        public void GeneralCusomer(string table)
        {
            ConnectionString connect = new ConnectionString();
            connect.Connect();
            connect.con.Open();
            MySqlCommand select = new MySqlCommand("SELECT * FROM " + table, connect.con);
            
            MySqlDataReader data = select.ExecuteReader();
            if (data.HasRows)
            {
                while (data.Read())
                {
                    bride = data.GetString(1);
                    brideAdress = data.GetString(2);
                    bridePhone = data.GetString(3);
                    groom = data.GetString(4);
                    groomAdress = data.GetString(5);
                    groomPhone = data.GetString(6);
                    weddingDate = data.GetString(7);
                    weddingPlace = data.GetString(8);
                }
            }
            else
            {
                MessageBox.Show("Brak kartoteki!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            data.Close();
        }
    }
}
