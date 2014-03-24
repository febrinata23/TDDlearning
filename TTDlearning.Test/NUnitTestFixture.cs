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
        TDDlearning.MathsOperation mathOperation = null;
        TDDlearning.CovertIntegerToString convertIntegerToString = null;

        [SetUp]
        public void Init()
        {
            mathOperation = new TDDlearning.MathsOperation();
            convertIntegerToString = new TDDlearning.CovertIntegerToString();
        }

        [TearDown]
        public void CleanUp()
        {
            mathOperation = null;
            convertIntegerToString = null;
        }

        [TestCase]
        public void AddTest()
        {
            int result = mathOperation.Add(20, 10);
            Assert.AreEqual(30, result);
        }
        [TestCase]
        public void SubtractTest()
        {
            int result = mathOperation.Subtract(20, 10);
            Assert.AreEqual(10, result);
        }

        [TestCase]
        public void DevideTest()
        {
            int result = mathOperation.Devide(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestCase]
        public void ConvertZeroToString()
        {
            string result = convertIntegerToString.IntegerToString(0);
            Assert.AreEqual("zero", result);
        }

        [TestCase]
        public void ConvertFiveToString()
        {
            string result = convertIntegerToString.IntegerToString(5);
            Assert.AreEqual("five", result);
        }

        [TestCase]
        public void ConvertTenToString()
        {
            string result = convertIntegerToString.IntegerToString(10);
            Assert.AreEqual("ten", result);
        }

        [TestCase]
        public void ConvertNineteenToString()
        {
            string result = convertIntegerToString.IntegerToString(19);
            Assert.AreEqual("nineteen", result);
        }

        [TestCase]
        public void ConvertTwentyToString()
        {
            string result = convertIntegerToString.IntegerToString(20);
            Assert.AreEqual("twenty", result);
        }

        [TestCase]
        public void ConvertTwentyfiveToString()
        {
            string result = convertIntegerToString.IntegerToString(25);
            Assert.AreEqual("twenty five", result);
        }

        [TestCase]
        public void ConvertNegativTwentyfiveToString()
        {
            string result = convertIntegerToString.IntegerToString(-25);
            Assert.AreEqual("negative twenty five", result);
        }

        [TestCase]
        public void ConvertNegativeNinetyynineToString()
        {
            string result = convertIntegerToString.IntegerToString(-99);
            Assert.AreEqual("negative ninety nine", result);
        }
    }
}

