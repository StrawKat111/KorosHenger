using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KörHenger;


namespace KorHengerTeszt
{
    [TestClass]
    public class Kör_Teszt
    {
        [TestMethod]
        public void Kerület_Teszt()
        {
            double sugar = 5;
            Kor kor = new Kor(sugar);
            double vártEredm = 31.42;
            kor.SetKerület();
            double kapottEredm = kor.GetKerület();

            Assert.AreEqual(vártEredm, kapottEredm);
        }

        [TestMethod]
        public void Terület_Teszt()
        {
            double sugar = 10;
            Kor kor = new Kor(sugar);
            double vártEredm = 314.16;
            kor.SetTerület();
            double kapottEredm = kor.GetTerület();

            Assert.AreEqual(vártEredm, kapottEredm);
        }
    }
}
