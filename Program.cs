using studies.Switch;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace studies
{
    class Program
    {
        static void Main()
        {
            FileStream fs = new FileStream("C://projetos//studies//StreamFile.txt", FileMode.Open);
            var stringRead = "New text to file using .net c#";
            fs.Write(System.Text.Encoding.UTF8.GetBytes(stringRead));
            fs.Close();

            StreamReader sr = new StreamReader("C://projetos//studies//StreamFile.txt");
            Task<string> text = sr.ReadToEndAsync();
            sr.Close();
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}