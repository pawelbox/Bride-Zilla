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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void kartaKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Klienci klienci = new Klienci();
            klienci.Show();
        }

        private void rachunekKlientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rachunek rachunek = new Rachunek();
            rachunek.Show();
        }

        private void kosztyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Koszty koszty = new Koszty();
            koszty.Show();
        }

        private void statystykaZapytańToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statystyka statystyka = new Statystyka();
            statystyka.Show();
        }

        private void winietkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Winietki winietki = new Winietki();
            winietki.Show();
        }

        private void voucheryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voucher voucher = new Voucher();
            voucher.Show();
        }

        private void bazaDanychMySqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySql mySql = new MySql();
            mySql.Show();
        }
    }
}
