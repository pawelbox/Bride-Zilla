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
            if (DialogResult == DialogResult.Yes)
            {
                try
                {
                    StreamWriter zapis;
                    string pathFolder = @"C:\Program Files\Bride_Zilla";
                    string path = @"C:\Program Files\Bride_Zilla\string.txt";
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                        zapis = File.CreateText(path);
                    }
                    else
                    {
                        Directory.CreateDirectory(pathFolder);
                        zapis = File.CreateText(path);
                    }
                    zapis.WriteLine("server=" + txtServer.Text + "; user=" + txtName.Text + " ; database=" + txtUser.Text + " ; password=" + txtPass.Text + ";");
                    zapis.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nie mogę znaleźć pliku z właściościami połączenia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
