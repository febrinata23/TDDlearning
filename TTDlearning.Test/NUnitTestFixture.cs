using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using TTDlearning;


namespace TTDlearning.Test
{
    [TestFixture]
    public class NUnitTestFixture
    {
        TDDlearning.Mathsx TDD = null;
        TDDlearning.covertinttostring Con = null;

        [SetUp]
        public void Init()
        {
            TDD = new TDDlearning.Mathsx();
            Con = new TDDlearning.covertinttostring();
        }

        [TearDown]
        public void CleanUp()
        {
            TDD = null;
            Con = null;
        }

        [TestCase]
        public void AddTest()
        {
            int result = TDD.Add(20, 10);
            Assert.AreEqual(30, result);
        }
        [TestCase]
        public void SubtractTest()
        {
            int result = TDD.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }

        [TestCase]
        public void DevideTest()
        {
            int result = TDD.devide(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestCase]
        public void Convertzerotostring()
        {
            string result = Con.InttoEnglish(0);
            Assert.AreEqual("zero", result);
        }

        [TestCase]
        public void Convertfivetostring()
        {
            string result = Con.InttoEnglish(5);
            Assert.AreEqual("five", result);
        }

        [TestCase]
        public void Converttentostring()
        {
            string result = Con.InttoEnglish(10);
            Assert.AreEqual("ten", result);
        }

        [TestCase]
        public void Convertnineteentostring()
        {
            string result = Con.InttoEnglish(19);
            Assert.AreEqual("nineteen", result);
        }

        [TestCase]
        public void Converttwentytostring()
        {
            string result = Con.InttoEnglish(20);
            Assert.AreEqual("twenty", result);
        }

        [TestCase]
        public void Converttwentyfivetostring()
        {
            string result = Con.InttoEnglish(25);
            Assert.AreEqual("twenty five", result);
        }

        [TestCase]
        public void Convertnegativetwentyfivetostring()
        {
            string result = Con.InttoEnglish(-25);
            Assert.AreEqual("negative twenty five", result);
        }

        [TestCase]
        public void Convertnegativeneityyninetostring()
        {
            string result = Con.InttoEnglish(-99);
            Assert.AreEqual("negative ninety nine", result);
        }
    }
}

