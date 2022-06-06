using System;
using System.IO;
using System.Windows.Forms;

namespace Bride_Zilla
{
    class ConnectionReader
    {
        
        public static void ReadString()
        {
            string path = @"string.txt";
            StreamReader read = new StreamReader(path);
            if (File.Exists(path))
            {
                try
                {

                    while (read.Peek() > 0)
                    {
                        read.ReadLine();
                    }
                }
                catch (Exception)
                {

                }
            }

            
        }
        
    }
}
