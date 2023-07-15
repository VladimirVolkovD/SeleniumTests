namespace SeleniumTests
{
    public class DescriptionAttribute : Attribute
    {
        public string Value { get; set; }

        public DescriptionAttribute(string value)
        {
            Value = value;
        }
    }
}
