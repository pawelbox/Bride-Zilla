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
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            LoadData load = new LoadData();

            load.GeneralCusomer("customers");
            
            cal1.AnnuallyBoldedDates = new System.DateTime[] { new System.DateTime(long.Parse(load.weddingDate)) };
        }
    }
}
