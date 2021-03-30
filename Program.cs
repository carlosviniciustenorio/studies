using studies.Colecoes.Pilha;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using static studies.Iterator.Class1;

namespace studies
{
    class Program
    {
        static void Main()
        {
            // Create the second data source.

            Queue<Teacher> teachers = new Queue<Teacher>();
            teachers.Enqueue(new Teacher { First = "Ann", Last = "Beebe", ID = 945, City = "Seattle" });
            teachers.Enqueue(new Teacher { First = "Alex", Last = "Robinson", ID = 956, City = "Redmond" });
            teachers.Enqueue(new Teacher { First = "Michiyo", Last = "Sato", ID = 972, City = "Tacoma" });

            foreach(var teacher in teachers)
            {
                Console.WriteLine(teacher.ID);
            }

            Console.ReadLine();
        }
    }
}
