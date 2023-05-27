using Faker;

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

        [Test]
        public void Test3()
        {
            var phone = Faker.Internet.Email();
            var name = Faker.Name.FullName();

            var t = new Rieltor(name, "John", "jsmith@gmail.com", "http://www.jsmith.com", 50.00);


            List<Rieltor> rieltors = new List<Rieltor>()
            {
              new Rieltor("Smith", "John", "jsmith@gmail.com", "http://www.jsmith.com" ,50.00)

            };

            var rieltor = rieltors.FirstOrDefault();
            var email = rieltor.Email;

            List<List<string>> attributes = new List<List<string>>()
            {
                new List<string> { "Smith", "John", "jsmith@gmail.com", "$50.00", "http://www.jsmith.com" },
                new List<string> { "Bach", "Frank", "fbach@yahoo.com", "$51.00", "http://www.frank.com" },
                new List<string> { "Doe", "Jason", "jdoe@hotmail.com", "$100.00", "http://www.jdoe.com" },
                new List<string> { "Conway", "Tim", "tconway@earthlink.net", "$50.00", "http://www.timconway.com" },
            };

            var rieltorString = attributes.FirstOrDefault();

        }
    }
}