using studies.Colecoes.Pilha;
using studies.Record;
using System;
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
            LinkedList<string> lk = new();
            LinkedListNode<string> node;
            lk.AddFirst("primeiro");
            lk.AddLast("ultimo");
            node = lk.FindLast("ultimo");
            lk.AddBefore(node, "penultimo");
            node = lk.FindLast("primeiro");
            lk.AddAfter(node, "antipenultimo");

            foreach (var item in lk)
            {
                Console.WriteLine("posicao: " + item);
            }
            
            Console.ReadLine();
        }
    }
}