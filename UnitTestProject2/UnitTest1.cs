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
            kor.SetKerület();
            double vártEredm = 31.4;
        }

        [TestMethod]
        public void Terület_Teszt()
        {
        }
    }
}
