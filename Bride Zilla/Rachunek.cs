using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bride_Zilla
{
    public partial class Rachunek : Form
    {
        public void ReloadGrid()
        {
            LoadData load = new LoadData();
            load.LoadGridData("bill");
            dataGridView1.DataSource = load.data.Tables[0];
        }
        public void ClearText()
        {
            txtJurnal.Clear();
            txtSesion.Clear();
            txtEngag.Clear();
            txtEngagPaid.Clear();
            txtPhoto.Clear();
            txtExtraPhoto.Clear();
            txtPaint.Clear();
            txtPrints.Clear();
            txtGuestPaid.Clear();
            txtGuestToPay.Clear();
            txtWedPaid.Clear();
            txtTravel.Clear();
            txtProfit.Clear();
            txtToPay.Clear();
            txtBride.Clear();
            txtGroom.Clear();
            txtCosts.Clear();
        }
        public void LoadBill()
        {
            try
            {
                ClearText();
                string customerID = txtID.Text;
                LoadData load = new LoadData();
                load.LoadBillData("bill", customerID);

                txtJurnal.AppendText(load.jurnal.ToString());
                txtSesion.AppendText(load.sesion.ToString());
                txtEngag.AppendText(load.engag.ToString());
                txtEngagPaid.AppendText(load.engagPaid);
                txtPhoto.AppendText(load.photobook.ToString());
                txtExtraPhoto.AppendText(load.extraPhotobook.ToString());
                txtPaint.AppendText(load.paint.ToString());
                txtPrints.AppendText(load.prints.ToString());
                txtGuestPaid.AppendText(load.guestPaid.ToString());
                txtGuestToPay.AppendText(load.guestToPay.ToString());
                txtTravel.AppendText(load.travel.ToString());
                txtWedPaid.AppendText(load.wedPaid.ToString());
                txtToPay.AppendText(load.toPay.ToString());

                LoadData costs = new LoadData();
                costs.LoadCostsData("costs", customerID);
                txtCosts.AppendText(costs.costs.ToString());
                int profit = load.toPay - costs.costs + load.guestPaid;
                txtProfit.AppendText(profit.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd połączenia z kartoteką!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void LoadCustomer()
        {
            try
            {
                string customerID = txtID.Text;
                LoadData load = new LoadData();
                load.LoadCustomerData("customers", customerID);
                txtBride.AppendText(load.bride);
                txtGroom.AppendText(load.groom);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd połączenia z kartoteką!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public Rachunek()
        {
            InitializeComponent();
        }

        private void Rachunek_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ClearText();
            LoadCustomer();
            LoadBill();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

            if (txtID.Text.Length >= 4)
            {
                ClearText();
                LoadBill();
                LoadCustomer();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations edit = new DataOperations();

                edit.ID = int.Parse(txtID.Text);
                edit.jurnal = int.Parse(txtJurnal.Text);
                edit.sesion = int.Parse(txtSesion.Text);
                edit.engag = int.Parse(txtEngag.Text);
                edit.engagPaid = txtEngagPaid.Text;
                edit.photobook = int.Parse(txtPhoto.Text);
                edit.extraPhotobook = int.Parse(txtExtraPhoto.Text);
                edit.paint = int.Parse(txtPaint.Text);
                edit.prints = int.Parse(txtPrints.Text);
                edit.guestPaid = int.Parse(txtGuestPaid.Text);
                edit.guestToPay = int.Parse(txtGuestToPay.Text);
                edit.travel = int.Parse(txtTravel.Text);
                edit.wedPaid = txtWedPaid.Text;

                edit.Update("bill", " SET `ID`=@ID,`Reportaż`=@jurnal,`Sesja`=@sesion,`Sesja narzeczeńska`=@engagment," +
                        "`Zapłacona`=@engPaid,`Album`=@photobook,`Albumy dodatkowe`=@extraPhoto,`Obrazy`=@paint,`Wydruki`=@prints,`Zam. od gości zapł.`=@guestPaid," +
                        "`Zam. od gości do zapł.`=@guestToPay,`Dojazd`=@travel,`Wesele zapłacone`=@wedPaid WHERE ID= @ID");
                ReloadGrid();
                ClearText();
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd połączenia z kartoteką!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();

            invoice.jurnal = int.Parse(txtJurnal.Text);
            invoice.bride = txtBride.Text;
            invoice.groom = txtGroom.Text;
            invoice.sesion = int.Parse(txtSesion.Text);
            invoice.engagment = int.Parse(txtEngag.Text);
            invoice.photobook = int.Parse(txtPhoto.Text);
            invoice.extraPhotobook = int.Parse(txtExtraPhoto.Text);
            invoice.paint = int.Parse(txtPaint.Text);
            invoice.prints = int.Parse(txtPrints.Text);
            invoice.guestToPay = int.Parse(txtGuestToPay.Text);
            invoice.travel = int.Parse(txtTravel.Text);
            invoice.toPay = int.Parse(txtToPay.Text);
            invoice.SaveInvoice(@"C:\Faktury\" + txtBride.Text + " i " + txtGroom.Text + ".txt");
        }
    }
}
