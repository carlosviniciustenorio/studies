using Azure.Storage.Blobs.Specialized;
using studies.Colecoes.Pilha;
using studies.Genericos;
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
            PessoaBase pessoa = new Pessoa("Carlos", 24);
            var method = ClasseHelper<Pessoa>.GetMethodByName("IsOfAge");

            var isOfAge = method.Invoke(pessoa, null);
            Console.WriteLine($"Possui maior idade: {isOfAge}");
        }

        public abstract class PessoaBase {}

        public class Pessoa : PessoaBase
        {
            public Guid Id { get; init; }
            public string Name { get; set; }
            public int Age { get; set; }
            public Pessoa(string name, int age) 
            {
                Id = Guid.NewGuid();
                Name = name;
                Age = age;
            }

            public bool IsOfAge() => Age >= 18;
        }
    }
}