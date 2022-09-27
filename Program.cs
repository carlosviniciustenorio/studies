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
            // Create a 7-tuple.
            var population = Tuple.Create("New York", 7891957, 7781984, 7894862, 7071639, 7322564, 8008278);
            // Display the first and last elements.
            Console.WriteLine("Population of {0} in 2000: {1:N0}",
                            population.Item1, population.Item7);
            // The example displays the following output:
            //       Population of New York in 2000: 8,008,278
        }
    }
}