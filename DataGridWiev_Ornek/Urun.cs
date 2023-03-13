using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridWiev_Ornek
{
    public class Urun
    {
        public int id { get; set; }
        public string UrunTanim { get; set; }
        public string ResimYol { get; set; }
        public Image  Urunresim { 
            get { 
                if(!string.IsNullOrEmpty(ResimYol))
                {
                    return Image.FromFile(ResimYol);
                }
                else
                {
                    return Image.FromFile(@"C:\Users\pc\Desktop\kilit2.png");
                }
            } 
        }
    }
}
