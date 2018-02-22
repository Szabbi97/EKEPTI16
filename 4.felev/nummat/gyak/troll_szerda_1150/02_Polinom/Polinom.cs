using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Polinom
{
    class Polinom
    {
        public double PoliKiert(double[] sorozat, double x)
        {
            double s = 0;
            for (int i = sorozat.Count(); i > 0; i--)
            {
                s = (s + sorozat[i]) * x;
            }
            return s;
        }
    }
}
