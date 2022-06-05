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
        public Winietki()
        {
            InitializeComponent();
        }

        private void Winietki_Load(object sender, EventArgs e)
        {
            this.paseTableAdapter.Fill(this.serwer117140_customerDataSet.pase);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                this.paseTableAdapter.Update(this.serwer117140_customerDataSet.pase);
                this.paseTableAdapter.Fill(this.serwer117140_customerDataSet.pase);
                ClearText();
            }
            catch (Exception)
            {
               
            }
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
            this.paseTableAdapter.Fill(this.serwer117140_customerDataSet.pase);
            ClearText();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Length >= 1)
            {
                ClearText();
                LoadData load = new LoadData();
                load.LoadPaseData("pase", txtID.Text);
                txtSize.AppendText(load.size);
                txtState.AppendText(load.estate.ToString());
                txtReserv.AppendText(load.reserv.ToString());
                txtAV.AppendText(load.av.ToString());
            }

        }
    }
}
