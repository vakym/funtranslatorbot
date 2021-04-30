using funtranslatorbot;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class CalculatorServiceTest
    {
        private CalculatorService calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new CalculatorService();
        }

        [Test]
        public void AddTest()
        {
            var expected = 4;
            var actual = calculator.Add(2, 4);
            Assert.AreEqual(expected, actual);
        }
    }
}
