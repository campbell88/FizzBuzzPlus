using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzPlus
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Expected = "1";
            Assert.AreEqual(Expected, FizzBuzzPlus.GetFizzBuzz(1));

        }
        [TestMethod]
        public void TestMethod2()
        {
            string Expected = "2";
            Assert.AreEqual(Expected, FizzBuzzPlus.GetFizzBuzz(2));

        }
        [TestMethod]
        public void TestMethod3()
        {
            string Expected = "Fizz";
            Assert.AreEqual(Expected, FizzBuzzPlus.GetFizzBuzz(3));

        }
        [TestMethod]
        public void TestMethod4()
        {
            string Expected = "4";
            Assert.AreEqual(Expected, FizzBuzzPlus.GetFizzBuzz(4));

        }
        [TestMethod]
        public void TestMethod5()
        {
            string Expected = "Buzz";
            Assert.AreEqual(Expected, FizzBuzzPlus.GetFizzBuzz(5));

        }
        [TestMethod]
        public void TestMethod6()
        {
            string Expected = "Fizz";
            Assert.AreEqual(Expected, FizzBuzzPlus.GetFizzBuzz(6));

        }

        [TestMethod]
        public void TestMethod9()
        {
            string Expected = "Fizz";
            Assert.AreEqual(Expected, FizzBuzzPlus.GetFizzBuzz(9));

        }
        [TestMethod]
        public void TestMethod10()
        {
            string Expected = "Buzz";
            Assert.AreEqual(Expected, FizzBuzzPlus.GetFizzBuzz(10));

        }
        [TestMethod]
        public void TestMethod15()
        {
            string Expected = "FizzBuzz";
            Assert.AreEqual(Expected, FizzBuzzPlus.GetFizzBuzz(15));

        }
        [TestMethod]
        public void TestMethod13()
        {
            string Expected = "Fizz";
            Assert.AreEqual(Expected, FizzBuzzPlus.GetFizzBuzz(13));

        }

        [TestMethod]
        public void TestMethod52()
        {
            string Expected = "Buzz";
            Assert.AreEqual(Expected, FizzBuzzPlus.GetFizzBuzz(52));

        }

        [TestMethod]
        public void TestMethod53()
        {
            string Expected = "FizzBuzz";
            Assert.AreEqual(Expected, FizzBuzzPlus.GetFizzBuzz(53));

        }
        [TestMethod]
        public void TestMethod35()
        {
            string Expected = "FizzBuzz";
            Assert.AreEqual(Expected, FizzBuzzPlus.GetFizzBuzz(35));

        }


    }
}