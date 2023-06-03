using SeleniumTests.SwagLabs;

namespace SeleniumTests.Core
{
    public class UserBuilder
    {
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
                Name = "vladimirwolkov-zgtj@force.com",
                Password = "QeeTwXGTVcXw72@",
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
                Password = Faker.Identification.SocialSecurityNumber(),
            };

        }

        internal static UserModel GetRandomUserWithPassword(string password) => new()
        {
            Name = Faker.Name.FullName(),
            Password = password,
        };


    }
}
