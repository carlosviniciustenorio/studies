using System;
using studies.Strings;

namespace studies
{
    class Program
    {
        static void Main()
        {
            if(Palindromo.IsPalindromo("TRURT"))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}