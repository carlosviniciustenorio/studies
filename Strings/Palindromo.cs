namespace studies.Strings
{
    public static class Palindromo
    {
        public static bool IsPalindromo(string text)
        {
            var textFormated = text.Trim().ToLower();

            for(int i = 0, j = textFormated.Length - 1; i < j; i++, j--)
            {
                if(textFormated[i] != textFormated[j])
                    return false;
            }

            return true;
        }
    }
}