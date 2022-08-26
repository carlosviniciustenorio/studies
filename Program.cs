using Azure.Storage.Blobs.Specialized;
using studies.Colecoes.Pilha;
using studies.Record;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using static studies.Iterator.Class1;

namespace studies
{
    class Program
    {
        static void Main()
        {
            decimal cambio = 123.308M;
            decimal absoluto = -19.69M;
            decimal absoluto2 = 19.69M;
            
            Console.WriteLine("Decimais com métodos da classe Math C#");
            Console.WriteLine("Valor do decimal: 123.308");
            Console.WriteLine("Truncate:" + Math.Truncate(cambio));
            Console.WriteLine("Abs:" + Math.Abs(cambio));
            Console.WriteLine("Valor absoluto: -19.69M");
            Console.WriteLine("Abs:" + Math.Abs(absoluto));
            Console.WriteLine("Valor absoluto2: 19.69M");
            Console.WriteLine("Abs:" + Math.Abs(absoluto2));
            Console.ReadLine();
        }
    }
}