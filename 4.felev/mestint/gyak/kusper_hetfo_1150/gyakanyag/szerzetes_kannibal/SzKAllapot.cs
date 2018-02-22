using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szerzetes_kannibal
{
    class SzKAllapot
    {
        int kb, szb;
        string cs;
        public bool AllapotE()
        {
            return (szb >= kb || szb == 0) && (3 - szb >= 3 - kb || 3 - szb == 0);
        }
        public bool CelAllapotE()
        {

            return (szb == 0 && kb == 0 && cs == "jobb");
        }

        /* Az operátor az, ami megváltoztatja az állapotot
         * o1: átviszek a csónakkal a másik partra két kannibált
         * o2: átviszek a csónakkal a másik partra egy kannibált és egy szerzetest
         * o3: átviszek a csónakkal a másik partra két szerzetest
         * o4: átviszek a csónakkal a másik partra egy kannibált
         * O5: átviszek a csónakkal a másik partra egy szerzetest
         */

        public int OperatorSzama()
        {
            return 5;
        }

        public bool SzuperOperator(int i)
        {
            switch(i)
            {
                case 0:
                    return Op(2, 0);
                case 1:
                    return Op(1, 0);
                case 2:
                    return Op(1, 1);
                case 3:
                    return Op(0, 1);
                case 4:
                    return Op(0, 2);
                default: return false;
            }
        }

        public SzKAllapot()
        {
            this.kb = 3;
            this.szb = 3;
            this.cs = "bal";
        }

        public bool Op(int sz, int k)
        {
            if(!PreOp(k,sz))
            {
                return false;
            }
            if (cs == "bal")
            {
                kb -= k;
                szb -= sz;
                cs = "jobb";
            }
            else
            {
                kb += k;
                szb += sz;
                cs = "bal";
            }
            if(AllapotE())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool PreOp(int k, int sz)
        {
            if(cs == "bal")
            {
                return (k <= kb && sz <= szb);
            }
            else
            {
                int kj = 3 - kb, szj = 3 - szb;
                return (k <= kj && sz <= szj);
            }
        }
    }
}
