using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kancsok
{
    class KancsoAllapot
    {
        int[] kancsok = new int[3];
        int[] maxliter = { 3, 5, 8 };

        public KancsoAllapot()
        {
            kancsok[0] = 0;
            kancsok[1] = 0;
            kancsok[2] = 8;
        }
        public bool AllapotE()
        {
            return (kancsok[0] + kancsok[1] + kancsok[2] == 8) &&
                   (kancsok[0] >= 0) && (kancsok[1] >= 0) && (kancsok[2] >= 0) &&
                   (kancsok[0] <= maxliter[0]) && (kancsok[1] <= maxliter[1]) &&
                   (kancsok[2] <= maxliter[2]);
        }
        public bool CelAllapotE()
        {
            return kancsok[0] == 0 && kancsok[1] == 4 && kancsok[2] == 4;
        }

        public bool Attolt(int i1, int i2)
        {
            if(!PreAttolt(i1,i2))
            {
                return false;
            }
            int mennyiferbele = maxliter[i2] - ;
            bool telelesze =
            if(AllapotE())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool PreAttolt(int i1, int i2)
        {
            throw new NotImplementedException();
        }
    }
}
