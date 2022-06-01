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
        public void Insert(string value)
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
            insert.Insert("statistic", value);
        }
        public void Update(string value)
        {
            DataOperations edit = new DataOperations();

            edit.ID = int.Parse(txtID.Text);
            edit.year = int.Parse(txtYear.Text);
            edit.month = int.Parse(txtMonth.Text);
            edit.source = txtSource.Text;
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
             Update(" SET `ID`=@ID,`Rok`=@year,`Miesiąc`=@month,`Źródło`=@source,`Data ślubu`=@date," +
                "`Kwota oferty`=@quote,`Spotkanie`=@meeting,`Umowa`=@contract,`Dane`=@name WHERE ID=@ID");
            ReloadGrid();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Length >=4)
            {
                LoadData load = new LoadData();
                
            }
        }
    }
}
