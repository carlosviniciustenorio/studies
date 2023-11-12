using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Newtonsoft.Json;

namespace studies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Usando BenchmarkDotNet  ###\n");
            Console.WriteLine("Pressione algo para iniciar\n");
            Console.ReadLine();
            var resultado = BenchmarkRunner.Run<BenchMarkDemo>();
        }

        
    }

    [MemoryDiagnoser]
    public class BenchMarkDemo
    {
        [Benchmark]
        public string SerializeWithTextJson() => System.Text.Json.JsonSerializer.Serialize(new
        {
            Name = "John",
            Age = 19,
            Role = "Engineer"
        });

        [Benchmark]
        public string SerializeWithNewtonSoftJson() => JsonConvert.SerializeObject(new
        {
            Name = "John",
            Age = 19,
            Role = "Engineer"
        });
    }
}