using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kancsok
{
    class KancsósÁllapot : AbsztraktÁllapot
    {
        int[] kancsok = new int[3];
        int[] maxliter = { 3, 5, 8 };

        public KancsósÁllapot()
        {
            kancsok[0] = 0;
            kancsok[1] = 0;
            kancsok[2] = 8;
        }

        public override object Clone()
        {
            KancsósÁllapot MyClone = new KancsósÁllapot();
            MyClone.kancsok = this.kancsok.Clone() as int[];
            return MyClone;
        }

        public override bool Equals(object o)
        {
            KancsósÁllapot másik = (KancsósÁllapot)o;
            for (int i = 0; i < kancsok.Length; i++)
            {
                if(kancsok[i] != másik.kancsok[i])
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            string ki = "";
            for (int i = 0; i < 3; i++)
            {
                ki += kancsok[i];
            }
            return ki;
        }

        public override bool CélÁllapotE()
        {
            return kancsok[0] == 0 && kancsok[1] == 4 && kancsok[2] == 4;
        }

        public override int OperátorokSzáma()
        {
            return 6;
        }

        public override bool SzuperOperátor(int i)
        {
            switch (i)
            {
                case 0:
                    return Attolt(2, 1);
                case 1:
                    return Attolt(2, 0);
                case 2:
                    return Attolt(1, 2);
                case 3:
                    return Attolt(1, 0);
                case 4:
                    return Attolt(0, 2);
                case 5:
                    return Attolt(0, 1);
                default:
                    return false;
            }

        }

        public override bool ÁllapotE()
        {
            return (kancsok[0] + kancsok[1] + kancsok[2] == 8) &&
                   (kancsok[0] >= 0) && (kancsok[1] >= 0) && (kancsok[2] >= 0) &&
                   (kancsok[0] <= maxliter[0]) && (kancsok[1] <= maxliter[1]) &&
                   (kancsok[2] <= maxliter[2]);
        }

        public bool Attolt(int i1, int i2)
        {
            if (!PreAttolt(i1, i2))
            {
                return false;
            }
            int mennyiferbele = maxliter[i2] - kancsok[i2];
            bool telelesze = kancsok[i2] + kancsok[i1] >= maxliter[i2];
            if (mennyiferbele >= 0)
            {
                if (telelesze)
                {
                    int osszes = kancsok[i2] + kancsok[i1];
                    kancsok[i2] = maxliter[i2];
                    kancsok[i1] = osszes - maxliter[i2];
                }
                else
                {
                    kancsok[i2] += kancsok[i1];
                    kancsok[i1] = 0;
                }
            }
            return ÁllapotE();
        }
        private bool PreAttolt(int i1, int i2)
        {
            return kancsok[i1] >= 0 && kancsok[i2] != maxliter[i2];
        }

        public override int GetHashCode()
        {
            return kancsok[0].GetHashCode() + kancsok[1].GetHashCode() + kancsok[2].GetHashCode();
        }
    }
}
