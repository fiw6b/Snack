using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Snackautomat
{
    public class Geld
    {
        private double wert;
        public double Wert
        {
            get { return wert; }
            set { wert = value; }
        }

        public Geld(double wert)
        {
            Wert = wert;
        }
    }
}
