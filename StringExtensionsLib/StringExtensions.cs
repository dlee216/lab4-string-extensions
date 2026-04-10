namespace StringExtensionsLib;

public static class StringExtensions
{
    public static bool IsStartsWithUpper(this string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return false;
        }

        return char.IsUpper(value[0]);
    }
}
