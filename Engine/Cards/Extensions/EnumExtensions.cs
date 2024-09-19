using System.Globalization;

public static class EnumExtensions
{
    public static string GetStringRepresentation(this Enum value)
    {
        string stringValue = value.ToString();

        string[] words = stringValue.Split('_');

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words[i].ToLower());
        }

        return string.Join(" ", words);
    }
}
