using System;
using System.Windows.Forms;

namespace Bride_Zilla
{
    public partial class Koszty : Form
    {
        public void ClearText()
        {
            txtPhoto.Clear();
            txtExtraPhoto.Clear();
            txtPaint.Clear();
            txtPrints.Clear();
            txtPase.Clear();
            txtTravel.Clear();
            txtBride.Clear();
            txtGroom.Clear();
        }
        public void ReloadGrid()
        {
            LoadData load = new LoadData();
            load.LoadGridData("costs");
            dataGridView1.DataSource = load.data.Tables[0];
        }
        public Koszty()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Length >= 4)
            {
                ClearText();
                string customerID = txtID.Text;
                try
                {
                    LoadData load = new LoadData();
                    load.LoadCostsData("costs", customerID);
                    txtPhoto.AppendText(load.photobook.ToString());
                    txtExtraPhoto.AppendText(load.extraPhotobook.ToString());
                    txtPaint.AppendText(load.paint.ToString());
                    txtPrints.AppendText(load.prints.ToString());
                    txtPase.AppendText(load.pase.ToString());
                    txtTravel.AppendText(load.travel.ToString());

                    LoadData customer = new LoadData();
                    customer.LoadCustomerData("customers", customerID);
                    txtBride.AppendText(customer.bride);
                    txtGroom.AppendText(customer.groom);
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataOperations update = new DataOperations();
            
            update.ID = int.Parse(txtID.Text);
            update.photobook = int.Parse(txtPhoto.Text);
            update.extraPhotobook = int.Parse(txtExtraPhoto.Text);
            update.paint = int.Parse(txtPaint.Text);
            update.prints = int.Parse(txtPrints.Text);
            update.pase = int.Parse(txtPase.Text);
            update.travel = int.Parse(txtTravel.Text);
            update.Update("costs", " SET `ID`=@ID,`Album`=@photobook,`Albumy dodatkowe`=@extraPhoto,`Obrazy`=@paint,`Wydruki`=@prints," +
                "`Winietki`=@pase,`Paliwo`=@travel WHERE ID= @ID");
            ClearText();
            ReloadGrid();
        }
    }
}
