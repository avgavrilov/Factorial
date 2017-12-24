using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassFactorial;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Factorial obj = new Factorial();
            int check = obj.count(1);
            Assert.AreEqual(1, check);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Factorial obj = new Factorial();
            int check = obj.count(16);
            Assert.IsTrue(check > 0);
        }
    }
}
