//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Security.Cryptography;
//using System.Text;

//namespace studies
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var result = Test.FrequencyCount(new List<string>() { "1", "1", "1", "1", "1", "1" });

//            var x = result.Count;
//        }
//    }

//    public static class Test
//    {
//        public static Dictionary<T, int> FrequencyCount<T>(IEnumerable<T> data)
//        {
//            var result = new Dictionary<T, int>();
//            foreach (var item in data)
//            {
//                if (result.ContainsKey(item))
//                {
//                    result[item] = result[item] + 1;
//                }
//                else
//                {
//                    result[item] = 1;
//                }
//            }
//            return result;
//        }
//    }
//}