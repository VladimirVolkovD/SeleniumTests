namespace SeleniumTests.Test
{
    [TestFixture]
    public class UnitTest : BaseTest
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine("------ Test1");
            Assert.That(numberTwo, Is.EqualTo(numberOne), $"{numberOne} != {numberTwo}. Something went wrong");
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("------ Test2");
            Assert.AreEqual(numberOne, numberTwo, $"{numberOne} != {numberTwo}. Something went wrong");
        }
    }
}