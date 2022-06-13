using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bride_Zilla
{
    class ContentClick
    {
        public string id { get; set; }

        public void Click(object value)
        {
            value.ToString();
            id = value.ToString();
        }
    }
}
