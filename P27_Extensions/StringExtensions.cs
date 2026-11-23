namespace P27_Extensions;

static class P27_Extensions
{
    public static string ToTitleCase(this string text)=>
    string.Join(' ',text.Split(' ',StringSplitOptions.RemoveEmptyEntries)
    .Select(w=>char.ToUpper(w[0])+w[1..].ToLower()));

    public static int WordCount(this string text)=>text.Split(' ',StringSplitOptions.RemoveEmptyEntries).Length;

    public static string Truncate(this string text, int max)=>
    text.Length<=max?text:text[..max]+"..";
}
