using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitteszt
{
    public class Bankszamla
    {
        double _Egyenleg = 0;
        public double Egyenleg
        {
            get
            {
                return _Egyenleg;
            }
        }
        public double Befizet(double Osszeg)
        {
            _Egyenleg += Osszeg;
            return Osszeg;
        }
        public double Kivet(double Osszeg)
        {
            if(_Egyenleg >= Osszeg)
            {
                _Egyenleg -= Osszeg;
                return Osszeg;
            }
            else
            {
                return 0;
            }
        }
    }
}
