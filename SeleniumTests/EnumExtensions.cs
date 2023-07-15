namespace SeleniumTests
{
    public static class EnumExtensions
    {
        public static string GetString(this Enum value)
        {
            var type = value.GetType();
            var fieldInfo = type.GetField(value.ToString());
            var attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Value;
            }

            return value.ToString();
        }
    }
}
