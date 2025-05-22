using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InputGivesBackTel()
        {
            var valami = new Program();
            string result = "tél";
            Assert.AreEqual(result, 1);

        }
        public void InputGivesBackTavasz()
        {
            var valami = new Program();
            string result = "tavasz";
            Assert.AreEqual(result, 2);
        }
        public void InputGivesBackOsz()
        {
            var valami = new Program();
            string result = "osz";
            Assert.AreEqual(result, 3);
        }
        public void InputGivesBackNyar()
        {
            var valami = new Program();
            string result = "Nyar";
            Assert.AreEqual(result, 4);
        }
    }
}
