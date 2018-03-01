using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kancsok
{
    /// <summary>
    /// A VakÁllapot csak a szemléltetés kedvért van itt.
    /// Megmutatja, hogy kell az operátorokat megírni és bekötni a szuper operátorba.
    /// </summary>
    abstract class VakÁllapot : AbsztraktÁllapot
    {
        // Itt kell megadni azokat a mezőket, amelyek tartalmazzák a belső állapotot.
        // Az operátorok belső állapot átmenetet hajtanak végre.
        // Először az alapoperátorokat kell megírni.
        // Minden operátornak van előfeltétele.
        // Minden operátor utófeltétele megegyezik az ÁllapotE predikátummal.
        // Az operátor igazat ad vissza, ha alkalmazható, hamisat, ha nem alkalmazható.
        // Egy operátor alkalmazható, ha a belső állapotra igaz
        // az előfeltétele és az állapotátmenet után igaz az utófeltétele.
        // Ez az első alapoperátor.
        private bool op1()
        {
            // Ha az előfeltétel hamis, akkor az operátor nem alkalmazható.
            if (!preOp1()) return false;
            // állapot átmenet
            //
            // TODO: Itt kell kiegészíteni a kódot!
            //
            // Utófeltétel vizsgálata, ha igaz, akkor alkalmazható az operátor.
            if (ÁllapotE()) return true;
            // Egyébként vissza kell vonni a belső állapot átmenetet,
            //
            // TODO: Itt kell kiegészíteni a kódot!
            //
            // és vissza kell adni, hogy nem alkalmazható az operátor.
            return false;
        }
        // Az első alapoperátor előfeltétele. Az előfeltétel neve általában ez: pre+operátor neve.
        // Ez segíti a kód megértését, de nyugodtan eltérhetünk ettől.
        private bool preOp1()
        {
            // Ha igaz az előfeltétel, akkor igazat ad vissza.
            return true;
        }
        // Egy másik operátor.
        private bool op2()
        {
            if (!preOp2()) return false;
            // Állapot átmenet:
            // TODO: Itt kell kiegészíteni a kódot!
            if (ÁllapotE()) return true;
            // Egyébként vissza kell vonni a belső állapot átmenetet:
            // TODO: Itt kell kiegészíteni a kódot!
            return false;
        }
        private bool preOp2()
        {
            // Ha igaz az előfeltétel, akkor igazat ad vissza.
            return true;
        }
        // Nézzük, mi a helyzet, ha az operátornak van paramétere.
        // Ilyenkor egy operátor több alapoperátornak felel meg.
        private bool op3(int i)
        {
            // Az előfeltételt ugyanazokkal a pereméterekkel kell hívni, mint magát az operátort.
            if (!preOp3(i)) return false;
            // Állapot átmenet:
            // TODO: Itt kell kiegészíteni a kódot!
            if (ÁllapotE()) return true;
            // egyébként vissza kell vonni a belső állapot átmenetet
            // TODO: Itt kell kiegészíteni a kódot!
            return false;
        }
        // Az előfeltétel paraméterlistája megegyezik az operátor paraméterlistájával.
        private bool preOp3(int i)
        {
            // Ha igaz az előfeltétel, akkor igazat ad vissza. Az előfeltétel függ a paraméterektől.
            return true;
        }
        // Ez a szuper operátor. Ezen keresztül lehet hívni az alapoperátorokat.
        // Az i paraméterrel mondjuk meg, hanyadik operátort akarjuk hívni.
        // Általában egy for ciklusból hívjuk, ami 0-tól az OperátorokSzáma()-ig fut.
        public override bool SzuperOperátor(int i)
        {
            switch (i)
            {
                // Itt kell felsorolnom az összes alapoperátort.
                // Ha egy új operátort veszek fel, akkor ide is fel kell venni.
                case 0: return op1();
                case 1: return op2();
                // A paraméteres operátorok több alap operátornak megfelelnek, ezért itt több sor is tartozik hozzájuk.
                // Hogy hány sor, az feladat függő.
                case 3: return op3(0);
                case 4: return op3(1);
                case 5: return op3(2);
                default: return false;
            }
        }
        // Visszaadja az alap operátorok számát.
        public override int OperátorokSzáma()
        {
            // Az utolsó case számát kell itt visszaadni.
            // Ha bővítjük az operátorok számát, ezt a számot is növelni kell.
            return 5;
        }
    }
}
