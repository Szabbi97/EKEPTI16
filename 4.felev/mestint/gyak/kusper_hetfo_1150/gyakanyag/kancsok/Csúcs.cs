using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kancsok
{
    /// <summary>
    /// A csúcs tartalmaz egy állapotot, a csúcs mélységét, és a csúcs szülőjét.
    /// Így egy csúcs egy egész utat reprezentál a start csúcsig.
    /// </summary>
    class Csúcs
    {
        // A csúcs tartalmaz egy állapotot, a mélységét és a szülőjét
        AbsztraktÁllapot állapot;
        int mélység;
        Csúcs szülő; // A szülőkön felfelé haladva a start csúcsig jutok.
                     // Konstruktor:
                     // A belső állapotot beállítja a start csúcsra.
                     // A hívó felelőssége, hogy a kezdő állapottal hívja meg.
                     // A start csúcs mélysége 0, szülője nincs.
        public Csúcs(AbsztraktÁllapot kezdőÁllapot)
        {
            állapot = kezdőÁllapot;
            mélység = 0;
            szülő = null;
        }
        // Egy új gyermek csúcsot készít.
        // Erre még meg kell hívni egy alkalmazható operátor is, csak azután lesz kész.
        public Csúcs(Csúcs szülő)
        {
            állapot = (AbsztraktÁllapot)szülő.állapot.Clone();
            mélység = szülő.mélység + 1;
            this.szülő = szülő;
        }
        public Csúcs GetSzülő() { return szülő; }
        public int GetMélység() { return mélység; }
        public bool TerminálisCsúcsE() { return állapot.CélÁllapotE(); }
        public int OperátorokSzáma() { return állapot.OperátorokSzáma(); }
        public bool SzuperOperátor(int i) { return állapot.SzuperOperátor(i); }
        public override bool Equals(Object obj)
        {
            Csúcs cs = (Csúcs)obj;
            return állapot.Equals(cs.állapot);
        }
        public override int GetHashCode() { return állapot.GetHashCode(); }
        public override String ToString() { return állapot.ToString(); }
        // Alkalmazza az összes alkalmazható operátort.
        // Visszaadja az így előálló új csúcsokat.
        public List<Csúcs> Kiterjesztes()
        {
            List<Csúcs> újCsúcsok = new List<Csúcs>();
            for (int i = 0; i < OperátorokSzáma(); i++)
            {
                // Új gyermek csúcsot készítek.
                Csúcs újCsúcs = new Csúcs(this);
                // Kiprobálom az i.dik alapoperátort. Alkalmazható?
                if (újCsúcs.SzuperOperátor(i))
                {
                    // Ha igen, hozzáadom az újakhoz.
                    újCsúcsok.Add(újCsúcs);
                }
            }
            return újCsúcsok;
        }
    }
}
