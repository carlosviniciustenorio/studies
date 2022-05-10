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
            Hashtable hashtable = new Hashtable();
            hashtable.Add("key", "value");
            hashtable.Add(1, 2);

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine("Chave: {0}, Valor:{1}", item.Key, item.Value);
            }
            Console.ReadLine();
        }
    }
}