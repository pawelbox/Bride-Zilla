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
    public partial class Statystyka : Form
    {
        public void ReloadGrid()
        {
            LoadData load = new LoadData();
            load.LoadGridData("statistic");
            dataGridView1.DataSource = load.data.Tables[0];
        }
        public Statystyka()
        {
            InitializeComponent();
        }

        private void Statystyka_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataOperations insert = new DataOperations();
           
            insert.customerID = null;
            insert.year = int.Parse(txtYear.Text);
            insert.month = int.Parse(txtMonth.Text);
            insert.source = txtSource.Text;
            insert.date = txtDate.Text;
            insert.qoute = int.Parse(txtQuote.Text);
            insert.meeting = comMeeting.Text;
            insert.contract = comContract.Text;
            insert.name = txtName.Text;

            insert.Insert("statistic", " VALUES(@ID,@year,@month,@source, @date, @qoute,@meeting,@contract,@name)");
            ReloadGrid();
        }
    }
}
