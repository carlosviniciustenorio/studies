using studies.Colecoes.Pilha;
using studies.Record;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using static studies.Iterator.Class1;

namespace studies
{
    class Program
    {
        static void Main()
        {
            var heatingDegreeDays = new HeatingDegreeDays(65, data, 10);
            Console.WriteLine(heatingDegreeDays);

            var coolingDegreeDays = new CoolingDegreeDays(65, data);
            Console.WriteLine(coolingDegreeDays);

            Console.ReadLine();
        }

        // Create the second data source.
        private static DailyTemperature[] data = new DailyTemperature[]
        {
        new DailyTemperature(HighTemp: 57, LowTemp: 30),
        new DailyTemperature(LowTemp: 30, HighTemp: 57),
        new DailyTemperature(60, 35),
        new DailyTemperature(63, 33),
        new DailyTemperature(68, 29),
        new DailyTemperature(72, 47),
        new DailyTemperature(75, 55),
        new DailyTemperature(77, 55),
        new DailyTemperature(72, 58),
        new DailyTemperature(70, 47),
        new DailyTemperature(77, 59),
        new DailyTemperature(85, 65),
        new DailyTemperature(87, 65),
        new DailyTemperature(85, 72),
        new DailyTemperature(83, 68),
        new DailyTemperature(77, 65),
        new DailyTemperature(72, 58),
        new DailyTemperature(77, 55),
        new DailyTemperature(76, 53),
        new DailyTemperature(80, 60),
        new DailyTemperature(85, 66)
        };

    }
}