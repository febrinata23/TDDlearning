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
        TDDlearning.MathsHelper TDD = null;

        [SetUp]
        public void Init()
        {
            TDD = new TDDlearning.MathsHelper();
        }

        [TearDown]
        public void CleanUp()
        {
            TDD = null;
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
    }
}

