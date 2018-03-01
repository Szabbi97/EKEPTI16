using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kancsok
{
    class Program
    {
        static void Main(string[] args)
        {
            Csúcs startCsúcs;
            GráfKereső kereső;
            startCsúcs = new Csúcs(new KancsósÁllapot());
            kereső = new BackTrack(startCsúcs, 10, true);
            kereső.megoldásKiírása(kereső.Keresés());
            Console.ReadKey();
        }
    }
}
