using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_LebegopontosSzamabrazolas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = HexToBin(258.6875,5);
        }

        private string HexToBinEgeszresz(int szam)
        {
            StringBuilder result = new StringBuilder();
            do
            {
                result.Append((szam % 2).ToString());
                szam = szam / 2;
                
            }
            while (szam != 0);

            StringBuilder result2 = new StringBuilder();
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result2.Append(result[i]);
            }
            return result2.ToString();
        }
        private string HexToBinTortresz(double szam, int korlat)
        {
            if(szam < 0 || 1 <= szam)
            {
                throw new Exception("Nulla és egy közé eső számot kell megadni");
            }
            StringBuilder result = new StringBuilder();
            int szJegyek = 0;
            do
            {
                szam = szam * 2;
                result.Append(((int)szam).ToString());
                szJegyek++;
                if(1 < szam)
                {
                    szam -= 1;
                }
            } while (szam != 0 && szJegyek != korlat);

            return result.ToString();
        }
        private string HexToBin(double szam,int korlat)
        {
            return HexToBinEgeszresz((int)szam) + "," + HexToBinTortresz(szam - (int)szam, korlat);
        }
        private int Kitevo(string BinarisSzam)
        {
            if (BinarisSzam.Split(',')[0] != "0")
            {
                for (int i = 0; i < BinarisSzam.Length; i++)
                {
                    if (BinarisSzam[i] == ',')
                        return i - 1;
                }
            }
            else
            {
                int kitevo = 0;
                for (int i = 0; i < BinarisSzam.Split(',')[1].Length; i++)
                {
                    kitevo--;
                    if (BinarisSzam.Split(',')[1][i] == 1)
                        return kitevo;
                }
            }
            return -1;
        }
        private int Karakterisztika(string BinarisSzam)
        {
            if (binarisSzam.Split(',')[0] != "0")
            {
                for (int i = 0; i < binarisSzam.Length; i++)
                {
                    if (binarisSzam[i] == ',')
                        return i - 1;
                }
            }
            else
            {
                int kitevo = 0;
                for (int i = 0; i < binarisSzam.Split(',')[1].Length; i++)
                {
                    kitevo--;
                    if (binarisSzam.Split(',')[1][i] == 1)
                        return kitevo;
                }
            }
            return -1;
        }
        private int EltoltKarakterisztika(int Karakterisztika)
        {
            return Karakterisztika + 127;
        }
        private string Mantissza(string BinarisSzam)
        {
            //0 és 1 közé eső szám
            //BinarisSzam = BinarisSzam.Replace(",", string.Empty);
            if (BinarisSzam.Split(',')[0] != "0")
            {
                while(BinarisSzam.Split(',')[0] != "1")
                {
                    BinarisSzam = BinarisSzam.Substring(1);
                }
                return BinarisSzam.Substring(1);
            }
            else
            {
                return BinarisSzam.Substring(1).Replace(",", "");
            }
        }
    }
}