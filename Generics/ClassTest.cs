using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace studies.Genericos
{
    // static void Main()
    //     {
    //         PessoaBase pessoa = new Pessoa("Carlos", 24);
    //         var method = ClasseHelper<Pessoa>.GetMethodByName("IsOfAge");

    //         var isOfAge = method.Invoke(pessoa, null);
    //         Console.WriteLine($"Possui maior idade: {isOfAge}");
    //     }

    //     public abstract class PessoaBase {}

    //     public class Pessoa : PessoaBase
    //     {
    //         public Guid Id { get; init; }
    //         public string Name { get; set; }
    //         public int Age { get; set; }
    //         public Pessoa(string name, int age) 
    //         {
    //             Id = Guid.NewGuid();
    //             Name = name;
    //             Age = age;
    //         }

    //         public bool IsOfAge() => Age >= 18;
    //     }
    public static class ClasseHelper<T> where T : class
    {
        public static string GetClassName() => typeof(T).Name;

        public static MethodInfo GetMethodByName(string name) 
        => typeof(T)
           .GetMethods()
           .FirstOrDefault(m => m.Name.Equals(name, System.StringComparison.InvariantCultureIgnoreCase));
    }
}
