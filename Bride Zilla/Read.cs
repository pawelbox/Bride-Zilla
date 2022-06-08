using System;
using System.IO;

namespace Bride_Zilla
{
    
        class Read
        {
            public string read { get; set; }
            public void GetRead()
            {
                string path = @"C:\Users\firma\Desktop\Weselne-CRM\Bride-Zilla\Bride Zilla\pliki\string.txt";
                StreamReader open = File.OpenText(path);
                read = open.ReadLine();
                open.Close();
            }
        }
    
}
