namespace SeleniumTests
{
    internal class Rieltor
    {
        public string Name { get; set; }
        public string SurnameName { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public double Price { get; set; }

        public Rieltor(string name, string surnameName, string email, string webSite, double price)
        {
            Name = name;
            SurnameName = surnameName;
            Email = email;
            WebSite = webSite;
            Price = price;
        }
    }
}
