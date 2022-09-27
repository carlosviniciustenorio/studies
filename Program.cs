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
            var tuple = GetTuple();
            Console.WriteLine($"Este é o valor da propriedade {nameof(tuple.n1)}: {tuple.n1}");
            Console.WriteLine("--------------");
            Console.WriteLine($"Este é o valor da propriedade {nameof(tuple.n2)}: {tuple.n2}");
        }

        public static(double n1, double n2) GetTuple()
        {
            var number1 = 1;
            var number2 = 2;

            return (number1, number2);
        }
    }
}