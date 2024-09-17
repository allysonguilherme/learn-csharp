namespace CalculateGPACLI;

public static class Utils
{
    public static string FormatString(this string value, int length)
    {
        int comparer = value.Length - length;

        if (comparer == 0)
            return value;
        if (comparer > 0)
            return value.Substring(0, length);

        for (int i = comparer; i < 0; i++)
        {
            value += " ";
        }

        return value;
    }
}