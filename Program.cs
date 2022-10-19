using studies.Switch;
using System;

namespace studies
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(EnumExpression.ToOrientation(Direction.Up));;
            Console.WriteLine(EnumExpression.ToOrientation(Direction.Left));
            Console.WriteLine(EnumExpression.ToOrientation(Direction.Down));
            Console.WriteLine(EnumExpression.ToOrientation(Direction.Right));
            Console.ReadLine();
        }
    }
}