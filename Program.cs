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
            var produto = new
            {
                id = 1,
                nome = "Monitor LED 32 polegadas",
                preco = 1500
            };
            Console.WriteLine("id: {0} {1} - preço: {2:n2}", produto.id, produto.nome, produto.preco);
            Console.ReadKey();
        }
    }
}