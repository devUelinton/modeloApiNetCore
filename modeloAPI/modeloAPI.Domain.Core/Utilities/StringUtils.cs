namespace modeloAPI.Domain.Core.Utilities
{
    public static class StringUtils
    {
        public static string OnlyNumbers(this string str, string input) => new string(input.Where(new Func<char, bool>(char.IsDigit)).ToArray());
        public static string RemoveCharacters(this string str, string input, string charactersToRemove) => new string(input.Replace(charactersToRemove, ""));
    }
}

