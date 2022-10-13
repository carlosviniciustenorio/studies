using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studies.Iterator
{
    public class Teacher
    {
        public int Id { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string City { get; set; }

        public Teacher() {}

        public IEnumerable<Teacher> CreateTeachers()
        {
            for(var c = 0; c < 100; c++){
                yield return new Teacher { First="Ann", Last="Beebe", Id=c};
                Console.WriteLine($"Teacher criado com id {c}");
            }
        }

    }
    public class Class1
    {
        // public class Teacher
        // {
        //     public int Id { get; set; }
        //     public string First { get; set; }
        //     public string Last { get; set; }
        //     public string City { get; set; }

        //     public Teacher()
        //     {
                
        //     }

        // }

        // Create the second data source.
        //List<Teacher> teachers = new List<Teacher>()
        //{
        //new Teacher { First="Ann", Last="Beebe", ID=945 },
        //new Teacher { First="Alex", Last="Robinson", ID=956 },
        //new Teacher { First="Michiyo", Last="Sato", ID=972 }
        //};

        //foreach (var teacher in BuscarPorId(teachers))
        //{
        //    Console.WriteLine("Retornou o professor de ID:" + teacher);
        //}

        //Console.ReadLine();
        //}
        
        //public static System.Collections.IEnumerable BuscarPorId(List<Teacher> teachers)
        //{
        //    foreach (var teacher in teachers)
        //    {
        //        yield return teacher.ID;
        //    }
        //}
    }
}
