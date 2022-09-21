using System.Text.RegularExpressions;

namespace Assignment2;

public static class Extensions
{
    public static bool IsSecure(this Uri url) => url.Scheme == "https";

    public static int WordCount(this string sentence) => Regex.Matches(sentence, @"[a-zA-Z]+").Count;
}
