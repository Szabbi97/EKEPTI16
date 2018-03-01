using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kancsok
{
    /// <summary>
    /// Minden gráfkereső algoritmus őse.
    /// A gráfkeresőknek csak a Keresés metódust kell megvalósítaniuk.
    /// Ez visszaad egy terminális csúcsot, ha talált megoldást, egyébként null értékkel tér vissza.
    /// A terminális csúcsból a szülő referenciákon felfelé haladva áll elő a megoldás.
    /// </summary>
    abstract class GráfKereső
    {
        private Csúcs startCsúcs; // A start csúcs csúcs.
                                  // Minden gráfkereső a start csúcsból kezd el keresni.
        public GráfKereső(Csúcs startCsúcs)
        {
            this.startCsúcs = startCsúcs;
        }
        // Jobb, ha a start csúcs privát, de a gyermek osztályok lekérhetik.
        protected Csúcs GetStartCsúcs() { return startCsúcs; }
        /// Ha van megoldás, azaz van olyan út az állapottér gráfban,
        /// ami a start csúcsból egy terminális csúcsba vezet,
        /// akkor visszaad egy megoldást, egyébként null.
        /// A megoldást egy terminális csúcsként adja vissza.
        /// Ezen csúcs szülő referenciáin felfelé haladva adódik a megoldás fordított sorrendben.
        public abstract Csúcs Keresés();
        /// <summary>
        /// Kiíratja a megoldást egy terminális csúcs alapján.
        /// Feltételezi, hogy a terminális csúcs szülő referenciáján felfelé haladva eljutunk a start csúcshoz.
        /// A csúcsok sorrendjét megfordítja, hogy helyesen tudja kiírni a megoldást.
        /// Ha a csúcs null, akkor kiírja, hogy nincs megoldás.
        /// </summary>
        /// <param name="egyTerminálisCsúcs">
        /// A megoldást képviselő terminális csúcs vagy null.
        /// </param>
        public void megoldásKiírása(Csúcs egyTerminálisCsúcs)
        {
            if (egyTerminálisCsúcs == null)
            {
                Console.WriteLine("Nincs megoldás");
                return;
            }
            // Meg kell fordítani a csúcsok sorrendjét.
            Stack<Csúcs> megoldás = new Stack<Csúcs>();
            Csúcs aktCsúcs = egyTerminálisCsúcs;
            while (aktCsúcs != null)
            {
                megoldás.Push(aktCsúcs);
                aktCsúcs = aktCsúcs.GetSzülő();
            }
            // Megfordítottuk, lehet kiírni.
            foreach (Csúcs akt in megoldás) Console.WriteLine(akt);
        }
    }
}
