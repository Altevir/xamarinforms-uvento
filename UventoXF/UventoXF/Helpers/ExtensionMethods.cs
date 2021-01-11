namespace UventoXF.Helpers
{
    public static class ExtensionMethods
    {
        public static string FirstLetterUpperCase(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            return $"{char.ToUpper(value[0])}{value.Substring(1)}";
        }
    }
}
