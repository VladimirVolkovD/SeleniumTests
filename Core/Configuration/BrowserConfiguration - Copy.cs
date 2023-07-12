namespace Core.Configuration
{
    public class DatabaseConfiguration : IConfiguration
    {
        public string SectionName => "Database";

        public string Server { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
    }
}
