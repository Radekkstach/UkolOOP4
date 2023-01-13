using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Tahac : NakladniAuto
    {
        private int nosnostVlecky;
        public Tahac(string spz, int nosnost, int nosnostVlecky) : base(spz, nosnost)
        {
            this.nosnostVlecky = nosnostVlecky;
            this.spz= spz;
            this.nosnost = nosnost + nosnostVlecky;
            
            
        }

        

    }
}
