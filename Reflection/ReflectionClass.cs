using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studies.Reflection
{
    public class ReflectionClass
    {
        //Permite trabalhar com o tipo do C# (Com a própria linguagem em si)
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public void Log(object obj)
        {
            var type = obj.GetType();

            foreach(var propertie in type.GetProperties())
            {
                Console.WriteLine($"{propertie.Name} has {propertie.GetValue(obj)}");
            }

            Console.ReadLine();
        }
    }
}