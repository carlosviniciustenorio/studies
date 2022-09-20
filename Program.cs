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
            Console.WriteLine("O método foi chamado:" + DateTime.Now);
            GetLimitRequest();
            Console.WriteLine("O método foi retornado:" + DateTime.Now);
        }

        public static TimeSpan GetLimitRequest() => TimeSpan.FromMilliseconds(500);
    }
}