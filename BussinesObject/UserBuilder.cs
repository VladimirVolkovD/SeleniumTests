using Bogus;
using NUnit.Framework;
using SeleniumTests.SwagLabs;

namespace SeleniumTests.Core
{
    public class UserBuilder
    {
        static Faker Faker = new (); 

        public static UserModel GetStandartUser()
        {
            return new UserModel
            {
                Name = TestContext.Parameters.Get("StandartUserName"),
                Password = TestContext.Parameters.Get("StandartUserPassword"),
            };

        }

        public static UserModel GetSalesForceUser()
        {
            return new UserModel
            {
                Name = "vladimirvolkov@internetkeno.com",
                Password = "1qaz@WSX",
            };

        }

        public static UserModel GetStandartUserWithoutName()
        {
            return new UserModel
            {
                Name = " ",
                Password = TestContext.Parameters.Get("StandartUserPassword"),
            };

        }

        public static UserModel GetRandomUser()
        {
            return new UserModel
            {
                Name = Faker.Name.FullName(),
                Password = Faker.Hacker.Verb(),
            };

        }

        public static UserModel GetRandomUserWithPassword(string password) => new()
        {
            Name = Faker.Name.FullName(),
            Password = password,
        };


    }
}
