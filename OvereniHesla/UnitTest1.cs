using Hesloapp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OvereniHesla
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void OvereniRPR_POSITIVE()
        {
            string obsahovat = "RPR";
            Form1 formular = new Form1();
            formular.heslo = "RPR";
            Assert.AreEqual(obsahovat, formular.heslo);
        }
        [TestMethod]
        public void OvereniRPR_NEGATIVE()
        {
            string obsahovat = "RPR";
            Form1 formular = new Form1();
            formular.heslo = "ahoj";
            Assert.IsTrue(formular.heslo.Contains(obsahovat));
        }
        [TestMethod]
        public void OvereniDelky_POSITIVE()
        {
            int min = 8;
            int max = 20;
            Form1 formular = new Form1();
            formular.heslo = "zdarecRPR!";
            Assert.IsTrue(formular.heslo.Length < max && min < formular.heslo.Length);
        }
        [TestMethod]
        public void OvereniDelky_NEGATIVE()
        {
            int min = 8;
            int max = 20;
            Form1 formular = new Form1();
            formular.heslo = "ahoj";
            Assert.IsTrue(formular.heslo.Length < max && min < formular.heslo.Length);
        }

        [TestMethod]
        public void OvereniPrazdne_NEGATIVE()
        {
            Form1 formular = new Form1();
            formular.heslo = null;
            Assert.IsNotNull(formular.heslo);
        }
        [TestMethod]
        public void OvereniPrazdne_POSITIVE()
        {
            Form1 formular = new Form1();
            formular.heslo = "ahoj";
            Assert.IsNotNull(formular.heslo);
        }

    }
}
