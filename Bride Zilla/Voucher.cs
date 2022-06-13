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
        public void ClearText()
        {
            txtContent.Clear();
            txtExpired.Clear();
            txtName.Clear();
            txtPrice.Clear();
            comRealised.Items.Clear();
            comType.Items.Clear();
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
                ClearText();
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd połączenia z kartoteką!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations edit = new DataOperations();

                edit.ID = int.Parse(txtID.Text);
                edit.name = txtName.Text;
                edit.customerID = txtID.Text;
                edit.type = comType.Text;
                edit.content = txtContent.Text;
                edit.expired = txtExpired.Text;
                edit.price = int.Parse(txtPrice.Text);
                edit.realised = comRealised.Text;
                edit.Update("voucher", " SET `ID`=@ID,`Na kogo`=@name,`Rodzaj`=@type,`Zawartość`=@content," +
                            "`Cena`=@price,`Ważność`=@expired,`Zrealizowany`=@realised WHERE ID= @ID");
                ReloadGrid();
                ClearText();
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd połączenia z kartoteką!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadData load = new LoadData();
                load.LoadVoucherData("voucher", txtID.Text);

                txtName.AppendText(load.name);
                txtContent.AppendText(load.content);
                txtExpired.AppendText(load.expired);
                txtPrice.AppendText(load.price.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd połączenia z kartoteką!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearText();
            txtID.Clear();
            ContentClick click = new ContentClick();
            click.Click(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtID.AppendText(click.id);
        }
    }
}
