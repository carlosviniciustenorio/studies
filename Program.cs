using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using static studies.Serialize.Class1;

namespace studies
{
    class Program
    {
        static void Main()
        {
            // Create the second data source.
            List<Teacher> teachers = new List<Teacher>()
            {
            new Teacher { First="Ann", Last="Beebe", ID=945 },
            new Teacher { First="Alex", Last="Robinson", ID=956 },
            new Teacher { First="Michiyo", Last="Sato", ID=972 }
            };

            
            FileStream fs = new FileStream(@"C:\studies\temp/archive.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, teachers);
            fs.Close();

            List<Teacher> tea = new();
            FileStream f = new FileStream(@"C:\studies\temp/archive.bin", FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            tea = (List<Teacher>)b.Deserialize(f);
            
            fs.Close();

            Console.WriteLine(tea[0].City);
            Console.ReadKey();
        }
    }
}
