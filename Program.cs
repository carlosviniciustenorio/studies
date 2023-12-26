using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Storage.Blobs.Models;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Newtonsoft.Json;
using studies.Arrays;
using studies.HackerHank;
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