using Azure.Storage.Blobs.Specialized;
using studies.Colecoes.Pilha;
using studies.Genericos;
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
        static readonly HttpClient client = new HttpClient();
        static async Task Main()
        {

            try	
            {
                client.Timeout = TimeSpan.FromSeconds(5);
                HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch(HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");	
                Console.WriteLine("Message :{0} ",e.Message);
            }
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