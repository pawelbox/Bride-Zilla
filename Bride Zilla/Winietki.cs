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

    public partial class Winietki : Form
    {
        public void ClearText()
        {
            txtAV.Clear();
            txtReserv.Clear();
            txtSize.Clear();
            txtState.Clear();
        }
        public void ReloadGrid()
        {
            try
            {
                LoadData load = new LoadData();
                load.LoadGridData("pase");
                dataGridView1.DataSource = load.data.Tables[0];
            }
            catch(Exception)
            {

            }
        }
        public Winietki()
        {
            InitializeComponent();
        }

        private void Winietki_Load(object sender, EventArgs e)
        {
            ReloadGrid();            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            ClearText();
            txtID.Clear();
            object value = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            id = value.ToString();
            txtID.AppendText(id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataOperations update = new DataOperations();

                update.ID = int.Parse(txtID.Text);
                update.size = txtSize.Text;
                update.estate = int.Parse(txtState.Text);
                update.reserv = int.Parse(txtReserv.Text);
                update.av = update.estate - update.reserv;

                update.Update("pase", " SET `ID`=@ID,`Rodzaj`=@size,`Stan`=@estate,`Zarezerwowane`=@reserv,`Dostępne`=@av WHERE ID=@ID");
              
                ClearText();
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd połączenia z kartoteką!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ReloadGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData load = new LoadData();
            load.LoadPaseData("pase", txtID.Text);

            int left = load.estate - int.Parse(txtRemove.Text);
            int lar = load.reserv - int.Parse(txtRemove.Text);
            DataOperations update = new DataOperations();

            update.ID = int.Parse(txtID.Text);
            update.size = txtSize.Text;
            update.estate = left;
            update.reserv = lar;
            update.av = update.estate - update.reserv;

            update.Update("pase", " SET `ID`=@ID,`Rodzaj`=@size,`Stan`=@estate,`Zarezerwowane`=@reserv,`Dostępne`=@av WHERE ID=@ID");
           
            ClearText();
            ReloadGrid();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Length >= 1)
            {
                try
                {
                    ClearText();
                    LoadData load = new LoadData();
                    load.LoadPaseData("pase", txtID.Text);
                    txtSize.AppendText(load.size);
                    txtState.AppendText(load.estate.ToString());
                    txtReserv.AppendText(load.reserv.ToString());
                    txtAV.AppendText(load.av.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Brak takiego inde!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
