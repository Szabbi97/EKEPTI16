using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unitteszt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unitteszt.Tests
{
    [TestClass()]
    public class BankszamlaTests
    {
        Random rnd = new Random();
        [TestMethod()]
        public void BefizetTest()
        {
            Bankszamla target = new Bankszamla();
            double osszeg = 0;
            for (int i = 0; i < 10; i++)
            {
                double help = rnd.NextDouble() * 10000;
                osszeg += help;
                target.Befizet(help);
            }

            Assert.AreEqual(target.Egyenleg, osszeg);
        }

        [TestMethod()]
        public void KivetTest()
        {
            Bankszamla target = new Bankszamla();
            double osszeg = 1204583;
            double kivevendo = 0;
            target.Befizet(osszeg);
            for (int i = 0; i < 10; i++)
            {
                kivevendo = rnd.NextDouble() * 1000000;
                if(osszeg != 0 && kivevendo < osszeg)
                {
                    Assert.AreEqual(kivevendo, target.Kivet(kivevendo));
                    osszeg -= kivevendo;
                }
                else
                {
                    Assert.AreEqual(0, target.Kivet(kivevendo));
                }
            }
            Assert.AreEqual(osszeg, target.Egyenleg);
        }
    }
}