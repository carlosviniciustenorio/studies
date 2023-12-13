using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Newtonsoft.Json;
using studies.Arrays;
using studies.HackerHank;

namespace studies
{
    class Program
    {
        static void Main()
        {
            // new ArrayTwoD().GetTwoDArray();
            // new MultiDimensionalArray().GetMultiDimensionalArray();
            // Console.WriteLine(Tests.GetDiagonalDifference());
            // SomeTests.timeConversion("07:05:45PM");
            SomeTests.MinMaxValues(new(){2,1,3,4,5});
        }
    }

    // [MemoryDiagnoser]
    // public class BenchMarkDemo
    // {
    //     [Benchmark]
    //     public string SerializeWithTextJson() => System.Text.Json.JsonSerializer.Serialize(new
    //     {
    //         Name = "Carlos Tenorio",
    //         Age = 25,
    //         Role = "Software Engineer"
    //     });

    //     [Benchmark]
    //     public string SerializeWithNewtonSoftJson() => JsonConvert.SerializeObject(new
    //     {
    //         Name = "Carlos Tenorio",
    //         Age = 25,
    //         Role = "Software Engineer"
    //     });
    // }
}