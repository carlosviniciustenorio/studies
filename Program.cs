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
            var teachers = new Teacher().CreateTeachers();
            
            foreach (var item in teachers)
            {
                if(item.Id > 4)
                    break;

                Console.WriteLine($"Teacher id {item.Id}");
            }
        }
    }
}