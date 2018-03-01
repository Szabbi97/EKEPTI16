using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kancsok
{
    /// <summary>
    /// A backtrack gráfkereső algoritmust megvalósító osztály.
    /// A három alap backtrack algoritmust egyben tartalmazza. Ezek
    /// - az alap backtrack
    /// - mélységi korlátos backtrack
    /// - emlékezetes backtrack
    /// Az ág-korlátos backtrack nincs megvalósítva.
    /// </summary>
    class BackTrack : GráfKereső
    {
        int korlát; // Ha nem nulla, akkor mélységi korlátos kereső.
        bool emlékezetes; // Ha igaz, emlékezetes kereső.
        public BackTrack(Csúcs startCsúcs, int korlát, bool emlékezetes) : base(startCsúcs)
        {
            this.korlát = korlát;
            this.emlékezetes = emlékezetes;
        }
        // nincs mélységi korlát, se emlékezet
        public BackTrack(Csúcs startCsúcs) : this(startCsúcs, 0, false) { }
        // mélységi korlátos kereső
        public BackTrack(Csúcs startCsúcs, int korlát) : this(startCsúcs, korlát, false) { }
        // emlékezetes kereső
        public BackTrack(Csúcs startCsúcs, bool emlékezetes) : this(startCsúcs, 0, emlékezetes) { }
        // A keresés a start csúcsból indul.
        // Egy terminális csúcsot ad vissza. A start csúcsból el lehet jutni ebbe a terminális csúcsba.
        // Ha nincs ilyen, akkor null értéket ad vissza.
        public override Csúcs Keresés() { return Keresés(GetStartCsúcs()); }
        // A kereső algoritmus rekurzív megvalósítása.
        // Mivel rekurzív, ezért a visszalépésnek a "return null" felel meg.
        private Csúcs Keresés(Csúcs aktCsúcs)
        {
            int mélység = aktCsúcs.GetMélység();
            // mélységi korlát vizsgálata
            if (korlát > 0 && mélység >= korlát) return null;
            // emlékezet használata kör kiszűréséhez
            Csúcs aktSzülő = null;
            if (emlékezetes) aktSzülő = aktCsúcs.GetSzülő();
            while (aktSzülő != null)
            {
                // Ellenőrzöm, hogy jártam-e ebben az állapotban. Ha igen, akkor visszalépés.
                if (aktCsúcs.Equals(aktSzülő)) return null;
                // Visszafelé haladás a szülői láncon.
                aktSzülő = aktSzülő.GetSzülő();
            }
            if (aktCsúcs.TerminálisCsúcsE())
            {
                // Megvan a megoldás, vissza kell adni a terminális csúcsot.
                return aktCsúcs;
            }
            // Itt hívogatom az alapoperátorokat a szuper operátoron
            // keresztül. Ha valamelyik alkalmazható, akkor új csúcsot
            // készítek, és meghívom önmagamat rekurzívan.
            for (int i = 0; i < aktCsúcs.OperátorokSzáma(); i++)
            {
                // Elkészítem az új gyermek csúcsot.
                // Ez csak akkor lesz kész, ha alkalmazok rá egy alkalmazható operátort is.
                Csúcs újCsúcs = new Csúcs(aktCsúcs);
                // Kipróbálom az i.dik alapoperátort. Alkalmazható?
                if (újCsúcs.SzuperOperátor(i))
                {
                    // Ha igen, rekurzívan meghívni önmagam az új csúcsra.
                    // Ha nem null értéket ad vissza, akkor megvan a megoldás.
                    // Ha null értéket, akkor ki kell próbálni a következő alapoperátort.
                    Csúcs terminális = Keresés(újCsúcs);
                    if (terminális != null)
                    {
                        // Visszaadom a megoldást képviselő terminális csúcsot.
                        return terminális;
                    }
                    // Az else ágon kellene visszavonni az operátort.
                    // Erre akkor van szükség, ha az új gyermeket létrehozásában nem lenne klónozást.
                    // Mivel klónoztam, ezért ez a rész üres.
                }
            }
            // Ha kipróbáltam az összes operátort és egyik se vezetett megoldásra, akkor visszalépés.
            // A visszalépés hatására eggyel feljebb a következő alapoperátor kerül sorra.
            return null;
        }
    }
}
