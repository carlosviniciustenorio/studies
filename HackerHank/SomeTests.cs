using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studies.HackerHank
{
    public static class SomeTests
    {
        public static string timeConversion(string s)
        {
            var date = Convert.ToDateTime(s).ToString("HH:mm:ss");
            return date.ToString();
        }

        public static void MinMaxValues(List<int> arr)
        {
            long totalSum = 0;
            long min = long.MaxValue;
            long max = long.MinValue;

            foreach (var item in arr)
            {
                totalSum += item;
                
                if (item < min)
                    min = item;

                if (item > max)
                    max = item;
            }

            long totalMin = totalSum - max;
            long totalMax = totalSum - min;

            Console.WriteLine($"{totalMin} {totalMax}");
        }
    }
}