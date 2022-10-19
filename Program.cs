using Azure.Storage.Blobs.Specialized;
using studies.Colecoes.Pilha;
using studies.Genericos;
using studies.Iterator;
using studies.Record;
using studies.Switch;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static studies.Iterator.Class1;

namespace studies
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(EnumExpression.ToOrientation(Direction.Up));;
            Console.WriteLine(EnumExpression.ToOrientation(Direction.Left));
            Console.WriteLine(EnumExpression.ToOrientation(Direction.Down));
            Console.WriteLine(EnumExpression.ToOrientation(Direction.Right));
            Console.ReadLine();
        }
    }
}