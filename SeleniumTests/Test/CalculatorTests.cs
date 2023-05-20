using NUnit.Framework.Constraints;
using SeleniumTests.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Test
{
    [TestFixture]
    internal class SummTests
    {
        Calculator calculator;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            calculator = new Calculator();
        }


        [Test, Category("Smoke"), Description("Super test")]
        public void HardAssert()
        {
            var random = new Random();
            var expected = 4;
            var actual = calculator.Add(2, 3);

            Assert.That(actual, Is.EqualTo(expected));
            Assert.AreEqual(1, 2);
            Assert.AreEqual(2, 2);
            Assert.AreEqual(3, 2);
            Assert.AreEqual(4, 2);
            Assert.AreEqual(2, 2);
        }

        [Test, Category("Smoke"), Description("Super test")]
        public void SoftAssert()
        {

            Assert.Multiple(() =>
            {
                Assert.AreEqual(1, 2);
                Assert.AreEqual(2, 2);
                Assert.AreEqual(3, 2);
                Assert.AreEqual(4, 2);
                Assert.AreEqual(2, 2);

            });


            //not run
            Assert.Multiple(() =>
            {

                Assert.AreEqual(0, 2);
                Assert.AreEqual(0, 2);
                Assert.AreEqual(0, 2);
                Assert.AreEqual(0, 2);
                Assert.AreEqual(0, 2);

            });
        }

        [Test, Category("Smoke"), Description("Super test")]
        [Retry(5)]
        public void SummTestRerty()
        {
            var random = new Random();
            var expected = 4;
            var actual = calculator.Add(random.NextInt64(0, 10), random.NextInt64(0, 10));

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Category("Smoke")]
        [Description("Super test")]
        public void SummTestRandomRepetead(
            [Random(0, 10, 10)] double operand1,
            [Random(0, 10, 10)] double operand2)
        {
            var expected = 4;
            var actual = calculator.Add(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        [Category("Smoke")]
        [Description("Super test")]
        public void SummTestRandom(
            [Values(1, 2, 3)] double operand1,
            [Random(0, 10, 5)] double operand2)
        {
            var expected = 4;
            var actual = calculator.Add(operand1, operand2);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [TestCase(4, 2, 2)]
        [TestCase(4, -1, 4)]
        [TestCase(4, 4, 0)]
        public void SummNegativeNumbersTest(double expected, double operand1, double operand2)
        {
            Assert.That(
                calculator.Add(operand1, operand2),
                Is.EqualTo(expected));
        }

        [TestCase(2, 2, ExpectedResult = 4)]
        [TestCase(3, 1, ExpectedResult = 4)]
        [TestCase(-2, 5, ExpectedResult = 4)]
        public double SummNegativeNumbersReturnTest(double operand1, double operand2)
        {
            return calculator.Add(operand1, operand2);
        }
    }
}
