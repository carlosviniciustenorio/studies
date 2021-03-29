using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studies.LINQ
{
    public class LINQTransformer
    {
        [Serializable]
        public class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public List<int> Scores;
        }

        [Serializable]
        public class Teacher
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public string City { get; set; }
        }

        // Create the first data source.
        //List<Student> students = new List<Student>()
        //    {
        //    new Student { First="Svetlana",
        //        Last="Omelchenko",
        //        ID=111,
        //        Street="123 Main Street",
        //        City="Seattle",
        //        Scores= new List<int> { 97, 92, 81, 60 } },
        //    new Student { First="Claire",
        //        Last="O’Donnell",
        //        ID=112,
        //        Street="124 Main Street",
        //        City="Redmond",
        //        Scores= new List<int> { 75, 84, 91, 39 } },
        //    new Student { First="Sven",
        //        Last="Mortensen",
        //        ID=113,
        //        Street="125 Main Street",
        //        City="Lake City",
        //        Scores= new List<int> { 88, 94, 65, 91 } },
        //    };

        //// Create the second data source.
        //List<Teacher> teachers = new List<Teacher>()
        //    {
        //    new Teacher { First="Ann", Last="Beebe", ID=945, City="Seattle" },
        //    new Teacher { First="Alex", Last="Robinson", ID=956, City="Redmond" },
        //    new Teacher { First="Michiyo", Last="Sato", ID=972, City="Tacoma" }
        //    };

        //var peoplesWhereLeave =
        //    (from stu in students
        //     where stu.City == "Redmond" || stu.City == "Seattle"
        //     select stu.First).Concat(
        //        from tea in teachers
        //        where tea.City == "Seattle"
        //        select tea.Last
        //        ).ToList();

        //peoplesWhereLeave.ForEach(p => Console.WriteLine("Cidades com alunos ou professores: " + p));
        //Console.ReadLine();

    }
}
