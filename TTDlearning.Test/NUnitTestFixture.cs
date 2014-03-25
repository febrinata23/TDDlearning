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
        TDDlearning.NumbersInWords numbersInWords = null;
        TDDlearning.FibonacciSequence fibonacciSequence = null;
        [SetUp]
        public void Init()
        {
            mathOperation = new TDDlearning.MathsOperation();
            numbersInWords = new TDDlearning.NumbersInWords();
            fibonacciSequence = new TDDlearning.FibonacciSequence();
        }

        [TearDown]
        public void CleanUp()
        {
            mathOperation = null;
            numbersInWords = null;
            fibonacciSequence = null;
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
            string result = numbersInWords.IntegerToString(0);
            Assert.AreEqual("zero", result);
        }

        [TestCase]
        public void ConvertFiveToString()
        {
            string result = numbersInWords.IntegerToString(5);
            Assert.AreEqual("five", result);
        }

        [TestCase]
        public void ConvertTenToString()
        {
            string result = numbersInWords.IntegerToString(10);
            Assert.AreEqual("ten", result);
        }

        [TestCase]
        public void ConvertNineteenToString()
        {
            string result = numbersInWords.IntegerToString(19);
            Assert.AreEqual("nineteen", result);
        }

        [TestCase]
        public void ConvertTwentyToString()
        {
            string result = numbersInWords.IntegerToString(20);
            Assert.AreEqual("twenty", result);
        }

        [TestCase]
        public void ConvertTwentyfiveToString()
        {
            string result = numbersInWords.IntegerToString(25);
            Assert.AreEqual("twenty five", result);
        }

        [TestCase]
        public void ConvertNegativTwentyfiveToString()
        {
            string result = numbersInWords.IntegerToString(-25);
            Assert.AreEqual("negative twenty five", result);
        }

        [TestCase]
        public void ConvertNegativeNinetyynineToString()
        {
            string result = numbersInWords.IntegerToString(-99);
            Assert.AreEqual("negative ninety nine", result);
        }

        [TestCase]
        public void TestDisplayFibonacciSequenceOneNumber()
        {
            string result = fibonacciSequence.DisplayFibonacciSequence(1);
            Assert.AreEqual("1", result);
        }

        [TestCase]
        public void TestDisplayFibonacciSequenceTwoNumbers()
        {
            string result = fibonacciSequence.DisplayFibonacciSequence(2);
            Assert.AreEqual("11", result);
        }

        [TestCase]
        public void TestDisplayFibonacciSequencefourNumbers()
        {
            string result = fibonacciSequence.DisplayFibonacciSequence(4);
            Assert.AreEqual("1123", result);
        }

        [TestCase]
        public void TestDisplayFibonacciSequenceNineNumbers()
        {
            string result = fibonacciSequence.DisplayFibonacciSequence(9);
            Assert.AreEqual("112358132134", result);
        }
    }
}

