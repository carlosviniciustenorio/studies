using studies.Colecoes.Pilha;
using studies.Struct;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using static studies.Iterator.Class1;

namespace studies
{
    class Program
    {
        static void Main()
        {
            // Create the second data source.

            var a = new Point(10, 10);
            var b = a;
            a.x = 100;
            System.Console.WriteLine(b.x);
            Console.ReadLine(); 
        }
    }
}
