using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kancsok
{
    /// <summary>
    /// Mélységi keresést megvalósító gráfkereső osztály.
    /// Ez a megvalósítása a mélységi keresésnek felteszi, hogy a start csúcs nem terminális csúcs.
    /// A nyílt csúcsokat veremben tárolja.
    /// </summary>
    class MélységiKeresés : GráfKereső
    {
        // Mélységi keresésnél érdemes a nyílt csúcsokat veremben tárolni,
        // mert így mindig a legnagyobb mélységű csúcs lesz a verem tetején.
        // Így nem kell külön keresni a legnagyobb mélységű nyílt csúcsot, amit ki kell terjeszteni.
        Stack<Csúcs> Nyilt; // Nílt csúcsok halmaza.
        List<Csúcs> Zárt; // Zárt csúcsok halmaza.
        bool körFigyelés; // Ha hamis, végtelen ciklusba eshet.
        public MélységiKeresés(Csúcs startCsúcs, bool körFigyelés) :
        base(startCsúcs)
        {
            Nyilt = new Stack<Csúcs>();
            Nyilt.Push(startCsúcs); // kezdetben csak a start csúcs nyílt
            Zárt = new List<Csúcs>(); // kezdetben a zárt csúcsok halmaza üres
            this.körFigyelés = körFigyelés;
        }
        // A körfigyelés alapértelmezett értéke igaz.
        public MélységiKeresés(Csúcs startCsúcs) : this(startCsúcs, true) { }
        // A megoldás keresés itt indul.
        public override Csúcs Keresés()
        {
            // Ha nem kell körfigyelés, akkor sokkal gyorsabb az algoritmus.
            if (körFigyelés) return TerminálisCsúcsKeresés();
            return TerminálisCsúcsKeresésGyorsan();
        }
        private Csúcs TerminálisCsúcsKeresés()
        {
            // Amíg a nyílt csúcsok halmaza nem nem üres.
            while (Nyilt.Count != 0)
            {
                // Ez a legnagyobb mélységű nyílt csúcs.
                Csúcs C = Nyilt.Pop();
                // Ezt kiterjesztem.
                List<Csúcs> újCsucsok = C.Kiterjesztes();
                foreach (Csúcs D in újCsucsok)
                {
                    // Ha megtaláltam a terminális csúcsot, akkor kész vagyok.
                    if (D.TerminálisCsúcsE()) return D;
                    // Csak azokat az új csúcsokat veszem fel a nyíltak közé,
                    // amik nem szerepeltek még sem a zárt, sem a nyílt csúcsok halmazában.
                    // A Contains a Csúcs osztályban megírt Equals metódust hívja.
                    if (!Zárt.Contains(D) && !Nyilt.Contains(D)) Nyilt.Push(D);
                }
                // A kiterjesztett csúcsot átminősítem zárttá.
                Zárt.Add(C);
            }
            return null;
        }
        // Ezt csak akkor szabad használni, ha biztos, hogy az állapottér gráfban nincs kör!
        // Különben valószínűleg végtelen ciklust okoz.
        private Csúcs TerminálisCsúcsKeresésGyorsan()
        {
            while (Nyilt.Count != 0)
            {
                Csúcs C = Nyilt.Pop();
                List<Csúcs> ujCsucsok = C.Kiterjesztes();
                foreach (Csúcs D in ujCsucsok)
                {
                    if (D.TerminálisCsúcsE()) return D;
                    // Ha nincs kör, akkor felesleges megnézni, hogy D volt-e már nyíltak vagy a zártak közt.
                    Nyilt.Push(D);
                }
                // Ha nincs kör, akkor felesleges C-t zárttá minősíteni.
            }
            return null;
        }
    }
}
