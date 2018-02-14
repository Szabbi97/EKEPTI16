using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szerzetes_kannibal
{
    class SzKÁllapot
    {
        int kb, szb;
        string cs;
        public bool ÁllapotE()
        {
            return (szb >= kb || szb == 0) && (3 - szb >= 3 - kb || 3 - szb == 0);
        }
    }
}
