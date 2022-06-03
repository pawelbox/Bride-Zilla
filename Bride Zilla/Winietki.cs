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
            this.paseTableAdapter.Update(this.serwer117140_customerDataSet.pase);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
