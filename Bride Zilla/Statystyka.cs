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
        public void ClearText()
        {
            txtYear.Clear();
            txtDate.Clear();
            txtMonth.Clear();
            txtName.Clear();
            txtQuote.Clear();
            
        }
        public void Insert(string value)
        {
            DataOperations insert = new DataOperations();

            insert.customerID = null;
            insert.year = int.Parse(txtYear.Text);
            insert.month = txtMonth.Text;
            insert.source = comSource.Text;
            insert.date = txtDate.Text;
            insert.qoute = int.Parse(txtQuote.Text);
            insert.meeting = comMeeting.Text;
            insert.contract = comContract.Text;
            insert.name = txtName.Text;
            insert.Insert("INSERT INTO ","statistic", value);
        }
        public void Update(string value)
        {
            DataOperations edit = new DataOperations();

            edit.ID = int.Parse(txtID.Text);
            edit.year = int.Parse(txtYear.Text);
            edit.month = txtMonth.Text;
            edit.source = comSource.Text;
            edit.date = txtDate.Text;
            edit.qoute = int.Parse(txtQuote.Text);
            edit.meeting = comMeeting.Text;
            edit.contract = comContract.Text;
            edit.name = txtName.Text;
            edit.Update("statistic", value);
        }
        DataOperations edit = new DataOperations();

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
            Insert(" VALUES(@ID,@year,@month,@source, @date, @qoute,@meeting,@contract,@name)");
            ReloadGrid();
            ClearText();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Update(" SET `ID`=@ID,`Rok`=@year,`Miesiąc`=@month,`Źródło`=@source,`Data ślubu`=@date," +
               "`Kwota oferty`=@qoute,`Spotkanie`=@meeting,`Umowa`=@contract,`Dane`=@name WHERE ID=@ID");
            ReloadGrid();
            ClearText();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Length >= 4)
            {
                LoadData load = new LoadData();

                load.LoadStatisticData("statistic", txtID.Text);
                txtYear.AppendText(load.year.ToString());
                txtMonth.AppendText(load.month.ToString());
                txtQuote.AppendText(load.qoute.ToString());
                txtName.AppendText(load.name);
                txtDate.AppendText(load.date);
            }
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
    }
}
