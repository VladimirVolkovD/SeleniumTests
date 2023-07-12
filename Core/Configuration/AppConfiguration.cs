using Microsoft.Extensions.Configuration;

namespace Core.Configuration
{
    public class AppConfiguration
    {
        public static BrowserConfiguration Browser => BindConfiguration<BrowserConfiguration>();
        public static DatabaseConfiguration Database => BindConfiguration<DatabaseConfiguration>();
                
        private static IConfigurationRoot configurationRoot;

        static AppConfiguration()
        {
            //Environment.SetEnvironmentVariable("BROWSER", "awesd");

            //var t = Environment.GetEnvironmentVariable("Env");

            //configurationRoot = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            //    .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("Env")}.json", optional: true, reloadOnChange: true)
            //    .Build();

            configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.custom.json", optional: true, reloadOnChange: true)
                .Build();
        }

        private static T BindConfiguration<T>() where T : IConfiguration, new()
        {
            var config = new T();
            configurationRoot.GetSection(config.SectionName).Bind(config);
            return config;
        }

        public static string GetValue(string key)
        {
            return configurationRoot[key];
        }
    }
}
