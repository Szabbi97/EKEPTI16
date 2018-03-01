using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kancsok
{
    /// <summary>
    /// A "3 szerzetes és 3 kannibál" probléma állapottér reprezentációja.
    /// Illetve általánosítása akárhány szerzetesre és kannibálra.
    /// Probléma: 3 szerzet és 3 kannibál van a folyó bal partján.
    /// Át kell juttatni az összes embert a másik partra.
    /// Ehhez rendelkezésre áll egy két személyes csónak.
    /// Egy ember is elég az átjutáshoz, de kettőnél több ember nem fér el.
    /// Ha valaki átmegy a másik oldalra, akkor ki is kell szállni, nem maradhat a csónakban.
    /// A gond ott van, hogy ha valamelyik parton több kannibál van,
    /// mint szerzetes, akkor a kannibálok megeszik a szerzeteseket.
    /// Kezdő állapot:
    /// 3 szerzetes a bal oldalon.
    /// 3 kannibál a bal oldalon.
    /// A csónak a bal parton van.
    /// 0 szerzetes a jobb oldalon.
    /// 0 kannibál a jobb oldalon.
    /// Ezt az állapotot ezzel a rendezett 5-össel írjuk le:
    /// (3,3,'B',0,0)
    /// A célállapot:
    /// (0,0,'J',3,3)
    /// Operátor:
    /// Op(int sz, int k):
    /// sz darab szerzetes átmegy a másik oldalra és
    /// k darab kannibál átmegy a másik oldalra.
    /// Lehetséges paraméterezése:
    /// Op(1,0): 1 szerzetes átmegy a másik oldalra.
    /// Op(2,0): 2 szerzetes átmegy a másik oldalra.
    /// Op(1,1): 1 szerzetes és 1 kannibál átmegy a másik oldalra.
    /// Op(0,1): 1 kannibál átmegy a másik oldalra.
    /// Op(0,2): 2 kanibál átmegy a másik oldalra.
    /// </summary>
    class SzerzetesekÉsKannibálokÁllapot : AbsztraktÁllapot
    {
        int sz; // ennyi szerzetes van összesen
        int k; // ennyi kannibál van összesen
        int szb; // szerzetesek száma a bal oldalon
        int kb; // kannibálok száma a bal oldalon
        char cs; // Hol a csónak? Értéke vagy 'B' vagy 'J'.
        int szj; // szerzetesek száma a jobb oldalon
        int kj; // kannibálok száma a jobb oldalon
        public SzerzetesekÉsKannibálokÁllapot(int sz, int k) // beállítja a kezdő állapotot
        {
            this.sz = sz;
            this.k = k;
            szb = sz;
            kb = k;
            cs = 'B';
            szj = 0;
            kj = 0;
        }
        public override bool ÁllapotE()
        { // igaz, ha a szerzetesek biztonságban vannak
            return ((szb >= kb) || (szb == 0)) &&
            ((szj >= kj) || (szj == 0));
        }
        public override bool CélÁllapotE()
        {
            // igaz, ha mindenki átért a jobb oldalra
            return szj == sz && kj == k;
        }
        private bool preOp(int sz, int k)
        {
            // A csónak 2 személyes, legalább egy ember kell az evezéshez.
            // Ezt végül is felesleges vizsgálni, mert a szuper operátor csak ennek megfelelően hívja.
            if (sz + k > 2 || sz + k < 0 || sz < 0 || k < 0) return false;
            // Csak akkor lehet átvinni sz szerzetest és
            // k kannibált, ha a csónak oldalán van is legalább ennyi.
            if (cs == 'B')
                return szb >= sz && kb >= k;
            else
                return szj >= sz && kj >= k;
        }
        // Átvisz a másik oldalra sz darab szerzetes és k darab kannibált.
        private bool op(int sz, int k)
        {
            if (!preOp(sz, k)) return false;
            SzerzetesekÉsKannibálokÁllapot mentes = (SzerzetesekÉsKannibálokÁllapot)Clone();
            if (cs == 'B')
            {
                szb -= sz;
                kb -= k;
                cs = 'J';
                szj += sz;
                kj += k;
            }
            else
            {
                szb += sz;
                kb += k;
                cs = 'B';
                szj -= sz;
                kj -= k;
            }
            if (ÁllapotE()) return true;
            szb = mentes.szb;
            kb = mentes.kb;
            cs = mentes.cs;
            szj = mentes.szj;
            kj = mentes.kj;
            return false;
        }
        public override int OperátorokSzáma() { return 5; }
        public override bool SzuperOperátor(int i)
        {
            switch (i)
            {
                case 0: return op(0, 1);
                case 1: return op(0, 2);
                case 2: return op(1, 1);
                case 3: return op(1, 0);
                case 4: return op(2, 0);
                default: return false;
            }
        }
        public override string ToString()
        {
            return szb + "," + kb + "," + cs + "," + szj + "," + kj;
        }
        public override bool Equals(Object a)
        {
            SzerzetesekÉsKannibálokÁllapot aa = (SzerzetesekÉsKannibálokÁllapot)a;
            // szj és kj számítható, ezért nem kell vizsgálni
            return aa.szb == szb && aa.kb == kb && aa.cs == cs;
        }
        // Ha két példány egyenlő, akkor a hasítókódjuk is egyenlő.
        public override int GetHashCode()
        {
            return szb.GetHashCode() + kb.GetHashCode() + cs.GetHashCode();
        }
    }
}
