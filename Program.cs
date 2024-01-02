using System;
using System.Collections.Generic;
using System.Linq;
using studies.Strings;

namespace studies
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(birthdayCakeCandles(new List<int>() {2, 3, 3, 1}));
        }

        public static int birthdayCakeCandles(List<int> candles)
        {
            var maxCandle = candles.Max();
            var maxCandleCount = candles.Count(d => d == maxCandle);

            return maxCandleCount;
        }
    }
}