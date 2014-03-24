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
        TDDlearning.MathsOperation testDrivenMathOperation = null;
        TDDlearning.CovertIntegerToString testDrivenConverter = null;

        [SetUp]
        public void Init()
        {
            testDrivenMathOperation = new TDDlearning.MathsOperation();
            testDrivenConverter = new TDDlearning.CovertIntegerToString();
        }

        [TearDown]
        public void CleanUp()
        {
            testDrivenMathOperation = null;
            testDrivenConverter = null;
        }

        [TestCase]
        public void AddTest()
        {
            int result = testDrivenMathOperation.Add(20, 10);
            Assert.AreEqual(30, result);
        }
        [TestCase]
        public void SubtractTest()
        {
            int result = testDrivenMathOperation.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }

        [TestCase]
        public void DevideTest()
        {
            int result = testDrivenMathOperation.Devide(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestCase]
        public void Convertzerotostring()
        {
            string result = testDrivenConverter.IntegerToString(0);
            Assert.AreEqual("zero", result);
        }

        [TestCase]
        public void Convertfivetostring()
        {
            string result = testDrivenConverter.IntegerToString(5);
            Assert.AreEqual("five", result);
        }

        [TestCase]
        public void Converttentostring()
        {
            string result = testDrivenConverter.IntegerToString(10);
            Assert.AreEqual("ten", result);
        }

        [TestCase]
        public void Convertnineteentostring()
        {
            string result = testDrivenConverter.IntegerToString(19);
            Assert.AreEqual("nineteen", result);
        }

        [TestCase]
        public void Converttwentytostring()
        {
            string result = testDrivenConverter.IntegerToString(20);
            Assert.AreEqual("twenty", result);
        }

        [TestCase]
        public void Converttwentyfivetostring()
        {
            string result = testDrivenConverter.IntegerToString(25);
            Assert.AreEqual("twenty five", result);
        }

        [TestCase]
        public void Convertnegativetwentyfivetostring()
        {
            string result = testDrivenConverter.IntegerToString(-25);
            Assert.AreEqual("negative twenty five", result);
        }

        [TestCase]
        public void Convertnegativeneityyninetostring()
        {
            string result = testDrivenConverter.IntegerToString(-99);
            Assert.AreEqual("negative ninety nine", result);
        }
    }
}

