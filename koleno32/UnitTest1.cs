using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace koleno32
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        //Ze stackOverFlow
    //        More importantly, why would you need to test that a type is abstract or not? Unit tests should test how code works, not how it is written. – 
    //Justin Niessner
    // Jan 7, 2015 at 22:44
        public void TestMethod21()
        {
            Assert.IsTrue(typeof(HerniPostava).IsAbstract());
            

        }
        [TestMethod]
        public void TestMethod1()
        {
            if(Lolendo.HRAC.Jmeno.Length > 10)
            {
                Assert.IsTrue(false);
            }
            Assert.IsTrue(true);

        }
        [TestMethod]
        public void TestMethod2()
        {
            if (Lolendo.NPC.Jmeno.Length > 10)
            {
                Assert.IsTrue(false);
            }
            Assert.IsTrue(true);

        }
        [TestMethod]
        public void TestMethod3()
        {
            if (Lolendo.HRAC.Level <= 0)
            {
                Assert.IsTrue(false);
            }
            
            Assert.IsTrue(true);

        }
        [TestMethod]
        public void TestMethod4()
        {
            switch(Lolendo.HRAC.Specializace)
            {
                case "Kouzelnik": case "Berserker": case "Inzenyr": case "Cizak": Assert.IsTrue(true); break;
                default: Assert.IsTrue(false); break;
            }

        }
        [TestMethod]
        public void TestMethod5()
        {
            if(Lolendo.HRAC.Specializace is String)
            {
                Assert.IsTrue(true);
            }
            Assert.IsTrue(false);

        }
        [TestMethod]
        public void TestMethod6()
        {
            if (Lolendo.HRAC.XP is int)
            {
                Assert.IsTrue(true);
            }
            Assert.IsTrue(false);

        }
        [TestMethod]
        public void TestMethod7()
        {
            if(Lolendo.NPC.Prace is Enum)
            {
                Assert.IsTrue(true);
            }
            Assert.IsTrue(false);
        }
        [TestMethod]
        public void TestMethod8()
        {
            if (Lolendo.NPC.Sila is int)
            {
                Assert.IsTrue(true);
            }
            Assert.IsTrue(false);
        }
        [TestMethod]
        public void TestMethod8()
        {//dobře VŠEDCHNY JSOU TOBŘE!"!!!!!!!!!!!!!!!!768852553285
            if (Lolendo.NPC.Sila >0)
            {
                Assert.IsTrue(true);
            }
            Assert.IsTrue(false);
        }
        [TestMethod]
        public void TestMethod9()
        {//dobře
            if (Lolendo.NPC.Sila is int)
            {
                Assert.IsTrue(true);
            }
            Assert.IsTrue(false);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //dobře
            Assert.IsTrue(!Lolendo.NPC.Jmeno.Contains(" "));
            }
        [TestMethod]
        public void TestMethod11()
        {//dobře
            Assert.IsTrue(Lolendo.HRAC.Jmeno.Contains(" "));
                                                                                                                                                                                                                                                                                                                                                                                                }
        [TestMethod]
        public void TestMethod12()
        {//dobře
            Lolendo.Hrac a = Lolendo.Hrac; 
            Lolendo.HRAC.PridejXP(10);
            Assert.IsTrue(a.XP < Lolendo.HRAC.XP || Lolendo.HRAC.Level > a.Level);
            
        }
        [TestMethod]
        public void TestMethod13()
        {//dobře
            Lolendo.Hrac a = Lolendo.Hrac;
            Lolendo.HRAC.PridejXP(11);
            Assert.IsTrue(a.XP < Lolendo.HRAC.XP || Lolendo.HRAC.Level > a.Level);

        }
        [TestMethod]
        public void TestMethod14()
        {//dobře
            Lolendo.Hrac a = Lolendo.Hrac;
            Lolendo.HRAC.PridejXP(12);
            Assert.IsTrue(a.XP < Lolendo.HRAC.XP || Lolendo.HRAC.Level > a.Level);

        }
        [TestMethod]
        public void TestMethod15()
        {//dobře
            Lolendo.Hrac a = Lolendo.Hrac;
            Lolendo.HRAC.PridejXP(13);
            Assert.IsTrue(a.XP < Lolendo.HRAC.XP || Lolendo.HRAC.Level > a.Level);

        }
        [TestMethod]
        public void TestMethod16()
        {//dobře
            Lolendo.Hrac a = Lolendo.Hrac;
            Lolendo.HRAC.PridejXP(14);
            Assert.IsTrue(a.XP < Lolendo.HRAC.XP || Lolendo.HRAC.Level > a.Level);

        }
        [TestMethod]
        public void TestMethod17()
        {//dobře
            Lolendo.Hrac a = Lolendo.Hrac;
            Lolendo.HRAC.PridejXP(9);
            Assert.IsTrue(a.XP < Lolendo.HRAC.XP || Lolendo.HRAC.Level > a.Level);

        }
        [TestMethod]
        public void TestMethod18()
        {//dobře
            Lolendo.Hrac a = Lolendo.Hrac;
            Lolendo.HRAC.PridejXP(3251);
            Assert.IsTrue(a.XP < Lolendo.HRAC.XP || Lolendo.HRAC.Level > a.Level);

        }
        [TestMethod]
        public void TestMethod19()
        {//dobře
            Lolendo.Hrac a = Lolendo.Hrac;
            Lolendo.HRAC.PridejXP(4);
            Assert.IsTrue(a.XP < Lolendo.HRAC.XP || Lolendo.HRAC.Level > a.Level);

        }
        [TestMethod]
        public void TestMethod20() //dobře
        {
            Lolendo.Hrac a = Lolendo.Hrac;
            Lolendo.HRAC.PridejXP(0);
            Assert.IsTrue(a.XP == Lolendo.HRAC.XP || Lolendo.HRAC.Level == a.Level);

        }
    }
}
