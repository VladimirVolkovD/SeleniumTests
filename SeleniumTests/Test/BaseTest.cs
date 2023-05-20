using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Test
{
    [TestFixture]
    public class BaseTest
    {
        protected int numberOne = 0;
        protected int numberTwo = 0;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            numberOne = 1;
            Console.WriteLine("- OneTimeSetUp");
        }

        [SetUp]
        public void Setup()
        {
            numberTwo++;
            Console.WriteLine("---- SetUp");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("---- TearDown");
        }

        [OneTimeTearDown]
        public void OneTImeTearDown()
        {
            Console.WriteLine("- OneTimeTearDown");
        }

    }
}
