using System;
using System.IO;

namespace Bride_Zilla
{
    
        class Read
        {
            public string read { get; set; }
            public void GetRead()
            {
                string path = @"C:\Program Files\Bride_Zilla\string.txt";
                StreamReader open = File.OpenText(path);
                read = open.ReadLine();
                open.Close();
            }
        }
    
}
