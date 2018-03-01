using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kancsok
{
    /// <summary>
    /// Ez a “éhes huszár” probléma állapottér reprezentációja.
    /// A huszárnak az állomás helyétől, a bal felső sarokból,
    /// el kell jutnia a kantinba, ami a jobb alsó sarokban van.
    /// A táblát egy (N+4)*(N+4) mátrixszal ábrázolom.
    /// A külső 2 széles rész margó, a belső rész a tábla.
    /// A margó használatával sokkal könnyebb megírni az ÁllapotE predikátumot.
    /// A 0 jelentése üres. Az 1 jelentése, itt van a ló.
    /// 3*3-mas tábla esetén a kezdő állapot:
    /// 0,0,0,0,0,0,0
    /// 0,0,0,0,0,0,0
    /// 0,0,1,0,0,0,0
    /// 0,0,0,0,0,0,0
    /// 0,0,0,0,0,0,0
    /// 0,0,0,0,0,0,0
    /// 0,0,0,0,0,0,0
    /// A fenti reprezentációból látszik, hogy elég csak a ló helyét nyilvántartani,
    /// mert a táblán csak a ló van. Így a kezdő állpot (bal felső sarokból indulunk):
    /// x = 2
    /// y = 2
    /// A célállapot (jobb alsó sarokba megyek):
    /// x = N+1
    /// y = N+1
    /// Operátorok:
    /// A lehetséges 8 ló lépés.
    /// </summary>
    class ÉhesHuszárÁllapot : AbsztraktÁllapot
    {
        // Alapértelmezetten egy 3*3-as sakktáblán fut.
        static int N = 3;
        // A belső állapotot leíró mezők.
        int x, y;
        // Beállítja a kezdő állapotra a belső állapotot.
        public ÉhesHuszárÁllapot()
        {
            x = 2; // A bal felső sarokból indulunk, ami a margó
            y = 2; // miatt a (2,2) koordinátán van.
        }
        // Beállítja a kezdő állapotra a belső állapotot.
        // Itt lehet megadni a tábla méretét is.
        public ÉhesHuszárÁllapot(int n)
        {
            x = 2;
            y = 2;
            N = n;
        }
        public override bool CélÁllapotE()
        {
            // A jobb alsó sarok a margó miatt a (N+1,N+1) helyen van.
            return x == N + 1 && y == N + 1;
        }
        public override bool ÁllapotE()
        {
            // a ló nem a margon van
            return x >= 2 && y >= 2 && x <= N + 1 && y <= N + 1;
        }
        private bool preLóLépés(int x, int y)
        {
            // jó lólépés-e, ha nem akkor return false
            if (!(x * y == 2 || x * y == -2)) return false;
            return true;
        }
        /* Ez az operátorom, igaz ad vissza, ha alakalmazható,
        * egyébként hamisat.
        * Paraméterek:
        * x: x irányú elmozdulás
        * y: y irányú elmozdulás
        * Az előfeltétel ellenőrzi, hogy az elmozdulás lólépés-e.
        * Az utófeltétel ellenőrzi, hogy a táblán maradtunk-e.
        * Példa:
        * lóLépés(1,-2) jelentése felfelé 2-öt jobbra 1-et.
        */
        private bool lóLépés(int x, int y)
        {
            if (!preLóLépés(x, y)) return false;
            // Ha az előfeltétel igaz, akkor megcsinálom az
            // állapot átmenetet.
            this.x += x;
            this.y += y;
            // Az utófeltétel mindig megegyezik az ÁllapotE-vel.
            if (ÁllapotE()) return true;
            // Ha az utófeltétel nem igaz, akkor vissza kell csinálni.
            this.x -= x;
            this.y -= y;
            return false;
        }
        public override bool SzuperOperátor(int i)
        {
            switch (i)
            { // itt sorolom fel a lehetséges 8 lólépést
                case 0: return lóLépés(1, 2);
                case 1: return lóLépés(1, -2);
                case 2: return lóLépés(-1, 2);
                case 3: return lóLépés(-1, -2);
                case 4: return lóLépés(2, 1);
                case 5: return lóLépés(2, -1);
                case 6: return lóLépés(-2, 1);
                case 7: return lóLépés(-2, -1);
                default: return false;
            }
        }
        public override int OperátorokSzáma() { return 8; }
        // A kiíratásnál kivonom x-ből és y-ból a margó szélességét.
        public override string ToString() { return (x - 2) + " : " + (y - 2); }
        public override bool Equals(Object a)
        {
            ÉhesHuszárÁllapot aa = (ÉhesHuszárÁllapot)a;
            return aa.x == x && aa.y == y;
        }
        // Ha két példány egyenlő, akkor a hasítókódjuk is egyenlő.
        public override int GetHashCode()
        {
            return x.GetHashCode() + y.GetHashCode();
        }
    }
}
