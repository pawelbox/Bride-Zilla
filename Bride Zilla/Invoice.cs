using System;
using System.IO;

namespace Bride_Zilla
{
    class Invoice
    {
        public StreamWriter write;
        public string bride { get; set; }
        public string groom { get; set; }
        public int jurnal { get; set; }
        public int sesion { get; set; }
        public int engagment { get; set; }
        public int photobook { get; set; }
        public int extraPhotobook { get; set; }
        public int paint { get; set; }
        public int prints { get; set; }
        public int guestToPay { get; set; }
        public int travel { get; set; }
        public int toPay{ get; set; }
        
        
        public void SaveInvoice(string path)
        {
            
            if(File.Exists(path))
            {
                int toPay = jurnal + sesion + engagment + photobook + extraPhotobook + paint + prints + guestToPay + travel;
                write = File.AppendText(path);
                write.WriteLine(bride);
                write.WriteLine(groom);
                write.WriteLine("Reportaż ślubny {0} zł", jurnal);
                write.WriteLine("Sesja ślubna {0} zł", sesion);
                write.WriteLine("Sesja narzeczeńska {0} zł", engagment);
                write.WriteLine("Album główny {0} zł", photobook);
                write.WriteLine("Albumy dodatkowe {0} zł", extraPhotobook);
                write.WriteLine("Obraz {0} zł", paint);
                write.WriteLine("Wydruki {0} zł", prints);
                write.WriteLine("Zdjęcia dla gości za pobrnaiem {0} zł", guestToPay);
                write.WriteLine("Dojazd {0} zł", travel);
                write.WriteLine("");
                write.WriteLine("Razem do zapłaty: {0} zł", toPay);
                write.Close();
            }
        }

    }
}
