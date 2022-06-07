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
    public partial class Voucher : Form
    {
        public void ReloadGrid()
        {
            LoadData load = new LoadData();
            load.LoadGridData("voucher");
            dataGridView1.DataSource = load.data.Tables[0];
        }
        public Voucher()
        {
            InitializeComponent();
        }

        private void Voucher_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations add = new DataOperations();
                add.name = txtName.Text;
                add.customerID = txtID.Text;
                add.type = comType.Text;
                add.content = txtContent.Text;
                add.expired = txtExpired.Text;
                add.price = int.Parse(txtPrice.Text);
                add.realised = comRealised.Text;
                add.Insert("INSERT INTO ", "voucher", " VALUES(@ID,@name,@type,@content, @price, @expired,@realised)");
                ReloadGrid();
            }
            catch(Exception)
            {
                MessageBox.Show("Błąd połączenia z kartoteką!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
