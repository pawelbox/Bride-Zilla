using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bride_Zilla
{
    public partial class Klienci : Form
    {
        public void ClearText()
        {
            //txtID.Clear();
            txtBride.Clear();
            txtBrideAdress.Clear();
            txtBridePhone.Clear();
            txtGroom.Clear();
            txtGroomAdress.Clear();
            txtGroomPhone.Clear();
            txtDate.Clear();
            txtPlace.Clear();
        }
        public void ReloadGrid()
        {
            LoadData load = new LoadData();
            load.LoadGridData("customers");
            dataGridView1.DataSource = load.data.Tables[0];
        }
        public void LoadCustomer()
        {
            ClearText();
            try
            {
                string customerID = txtID.Text;
                LoadData load = new LoadData();
                load.LoadCustomerData("customers", customerID);

                txtBride.AppendText(load.bride);
                txtBrideAdress.AppendText(load.brideAdress);
                txtBridePhone.AppendText(load.bridePhone);
                txtGroom.AppendText(load.groom);
                txtGroomAdress.AppendText(load.groomAdress);
                txtGroomPhone.AppendText(load.groomPhone);
                txtDate.AppendText(load.weddingDate);
                txtPlace.AppendText(load.weddingPlace);
            }
            catch (Exception)
            {

            }
        }

        public Klienci()
        {
            InitializeComponent();
        }

        private void Klienci_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations insert = new DataOperations();
                insert.customerID = null;
                insert.bride = txtBride.Text;
                insert.brideAdress = txtBrideAdress.Text;
                insert.bridePhone = txtBridePhone.Text;
                insert.groom = txtGroom.Text;
                insert.groomAdress = txtGroomAdress.Text;
                insert.groomPhone = txtGroomPhone.Text;
                insert.weddingDate = txtDate.Text;
                insert.weddingPlace = txtPlace.Text;

                insert.Insert("customers", " VALUES(@ID,@bride,@brideAdress,@bridePhone, @groom, @groomAdress,@groomPhone,@weddingDate,@weddingPlace)");
                insert.Insert("bill", " VALUES(@ID,'0','0','0','Nie','0','0','0','0','0','0','0','Nie')");
                insert.Insert("costs", " VALUES(@ID,'0','0','0','0','0','0')");

                MessageBox.Show("Utworzyłem kartotekę i rachunek dla klienta:" + txtBride.Text, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ReloadGrid();
                ClearText();
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd połączenia z kartoteką!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length > 0)
            {
                try
                {
                    int ID = int.Parse(txtID.Text);
                    DataOperations del = new DataOperations();
                    del.Delete("customers", ID);
                    del.Delete("bill", ID);
                    del.Delete("costs", ID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Błąd połączenia z kartoteką!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ReloadGrid();
                ClearText();
            }
            else
            {
                MessageBox.Show("Podaj ID klienta, którego chcesz usunąć.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Length >= 4)
            {
                ClearText();
                LoadCustomer();
            }
        }
    }
}

