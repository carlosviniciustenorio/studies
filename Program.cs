using Azure.Storage.Blobs.Specialized;
using studies.Colecoes.Pilha;
using studies.Genericos;
using studies.Iterator;
using studies.Record;
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
        // Create the second data source.
        List<Teacher> teachers = new List<Teacher>()
        {
        new Teacher { First="Ann", Last="Beebe", Id=945 },
        new Teacher { First="Alex", Last="Robinson", Id=956 },
        new Teacher { First="Michiyo", Last="Sato", Id=972 }
        };

        foreach (var teacher in BuscarPorId(teachers))
        {
           Console.WriteLine("Retornou o professor de ID:" + teacher);
        }

        Console.ReadLine();
        }
        
        public static System.Collections.IEnumerable BuscarPorId(List<Teacher> teachers)
        {
           foreach (var teacher in teachers)
           {
               Console.WriteLine("Buscando por ID:" + teacher.Id);
               yield return teacher.Id;
               Console.WriteLine($"Teacher ID:{teacher.Id} retornado");
           }
        }
    }
}