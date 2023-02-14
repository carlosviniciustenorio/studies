using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace studies
{
    class Program
    {
        static void Main(string[] args)
        {
            var testClass = new Test();
            
            var type = testClass.GetType();
            var property = type.GetProperty("iTest").GetType();
            var method = property.GetMethod("GetForeingString");
            method.Invoke(null, null);
        }
    }

    public class Test
    {
        public ITest iTest { get; set; }
    }

    public interface ITest
    {
        string GetForeingString();
    }

    public class Testing
    {
        public string GetForeingString() => "foreing string returned";
    }
}