using System;
using System.IO;
using System.Windows.Forms;

namespace Bride_Zilla
{
    public partial class BazaDanych : Form
    {
        public BazaDanych()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Czy jesteś pewien?", "Ta zmiana spowoduje nadpisanie danych dsotępowych do bazy danych!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(DialogResult == DialogResult.Yes)
            {
                StreamWriter zapis;
                string path = @"C:\Users\firma\Desktop\Weselne-CRM\Bride-Zilla\Bride Zilla\pliki\string.txt";
                zapis = File.CreateText(path);
                zapis.WriteLine("server=" + txtServer.Text + "; user=" + txtName.Text + " ; database=" + txtUser.Text + " ; password=" + txtPass.Text + ";");
                zapis.Close();
            }
            
        }
    }
}
