using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace studies.Serialize
{
    public class Class1
    {
        [Serializable]
        public class Teacher : IDeserializationCallback
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }

            [NonSerialized]
            public string City;

            public Teacher(string first = "teste", string last = "teste", int id = 0, string city = "teste"){ First = first; Last = last; ID = id; City = city; }

            void IDeserializationCallback.OnDeserialization(Object sender)
            {
                City = "Cidade";
            }

            //// Create the second data source.
            //List<Teacher> teachers = new List<Teacher>()
            //{
            //new Teacher { First="Ann", Last="Beebe", ID=945 },
            //new Teacher { First="Alex", Last="Robinson", ID=956 },
            //new Teacher { First="Michiyo", Last="Sato", ID=972 }
            //};


            //FileStream fs = new FileStream(@"C:\studies\temp/archive.bin", FileMode.Create);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, teachers);
            //fs.Close();

            //List<Teacher> tea = new();
            //FileStream f = new FileStream(@"C:\studies\temp/archive.bin", FileMode.Open);
            //BinaryFormatter b = new BinaryFormatter();
            //tea = (List<Teacher>) b.Deserialize(f);

            //fs.Close();

            //Console.WriteLine(tea[0].City);
            //Console.ReadKey();
        }
    }
}
