using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp11;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           Dieta dieta = new Dieta();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => dieta.Init(-10, 9, 1000, 100, 5));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Dieta dieta = new Dieta();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => dieta.Init(0, 9, 1000, 100, 5));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Dieta dieta = new Dieta();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => dieta.Init(10, -2, 1000, 100, 5));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Dieta dieta = new Dieta();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => dieta.Init(10, 0, 5000, 100, 5));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Dieta dieta = new Dieta();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => dieta.Init(10, 2, -4, 6000, 5));
        }
        [TestMethod]
        public void TestMethod6()
        {
            Dieta dieta = new Dieta();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => dieta.Init(10, 2, 0, 6000, 5));
        }
        [TestMethod]
        public void TestMethod7()
        {
            Dieta dieta = new Dieta();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => dieta.Init(10, 2, 100, -3, 5));
        }
        [TestMethod]
        public void TestMethod8()
        {
            Dieta dieta = new Dieta();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => dieta.Init(10, 2, 1000, 0, 5));
        }
        [TestMethod]
        public void TestMethod9()
        {
            Dieta dieta = new Dieta();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => dieta.Init(10, 2, 1000, 100, -4));
        }
        [TestMethod]
        public void TestMethod10()
        {
            Dieta dieta = new Dieta();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => dieta.Init(10, 2, 1000, 100, 0));
        }
    }
}