using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studies.Record
{
    public record DailyTemperature(double HighTemp, double LowTemp)
    {
        public double Mean => (HighTemp + LowTemp) / 2.0;
    }

    //O registro base declara e inicializa essas propriedades.
    //O registro derivado não os oculta, mas só cria e inicializa Propriedades para parâmetros que não são declarados em seu registro base.
    //Neste exemplo, os registros derivados não adicionam novos parâmetros de Construtor primários.
    public abstract record DegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords) 
    {
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("HeatingDegreeDays");
            stringBuilder.Append(" { ");
            if (PrintMembers(stringBuilder))
            {
                stringBuilder.Append(" ");
            }
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }

        protected virtual bool PrintMembers(StringBuilder stringBuilder)
        {
            stringBuilder.Append($"BaseTemperature = {BaseTemperature}");
            return true;
        }
    };

    public sealed record HeatingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords)
        : DegreeDays(BaseTemperature, TempRecords)
    {
        public double DegreeDays => TempRecords.Where(s => s.Mean < BaseTemperature).Sum(s => BaseTemperature - s.Mean);
    }

    public sealed record CoolingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords)
        : DegreeDays(BaseTemperature, TempRecords)
    {
        public double DegreeDays => TempRecords.Where(s => s.Mean > BaseTemperature).Sum(s => s.Mean - BaseTemperature);
    }

    //CÓDIGO PARA RODAR NO MAIN

    //O código anterior define um registro posicional. Você criou um tipo de referência que contém duas propriedades: HighTemp e LowTemp .
    //Essas propriedades são apenas Propriedades de inicialização, o que significa que elas podem ser 
    //definidas no construtor ou usando um inicializador de propriedade. 

    //O DailyTemperature tipo também tem um Construtor principal que tem dois parâmetros que correspondem às duas propriedades.
    //Você usa o Construtor principal para inicializar um DailyTemperature registro:

    // Create the second data source.
    //private static DailyTemperature[] data = new DailyTemperature[]
    //{
    //    new DailyTemperature(HighTemp: 57, LowTemp: 30),
    //    new DailyTemperature(LowTemp: 30, HighTemp: 57),
    //    new DailyTemperature(60, 35),
    //    new DailyTemperature(63, 33),
    //    new DailyTemperature(68, 29),
    //    new DailyTemperature(72, 47),
    //    new DailyTemperature(75, 55),
    //    new DailyTemperature(77, 55),
    //    new DailyTemperature(72, 58),
    //    new DailyTemperature(70, 47),
    //    new DailyTemperature(77, 59),
    //    new DailyTemperature(85, 65),
    //    new DailyTemperature(87, 65),
    //    new DailyTemperature(85, 72),
    //    new DailyTemperature(83, 68),
    //    new DailyTemperature(77, 65),
    //    new DailyTemperature(72, 58),
    //    new DailyTemperature(77, 55),
    //    new DailyTemperature(76, 53),
    //    new DailyTemperature(80, 60),
    //    new DailyTemperature(85, 66)
    //};



    //TESTS

    //Testei como o compilador iria imprimir os valores no Console.
    //public class DailyTemperature
    //{

    //    public double HighTemp { get; set; }
    //    public double LowTemp { get; set; }
    //    public double Mean { get; set; }

    //    public DailyTemperature(double HighTemp, double LowTemp)
    //    {
    //        this.HighTemp = HighTemp;
    //        this.LowTemp = LowTemp;
    //        Mean = (HighTemp + LowTemp) / 2.0;
    //    }

    //}
}
