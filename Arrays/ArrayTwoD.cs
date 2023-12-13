using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studies.Arrays
{
    public class ArrayTwoD
    {
        public void GetTwoDArray()
        {
            // 2D array = an array, where each element is an entire array
            // useful if you need a matrix, grid, or table of data
            /*
            int[,] numbers = {
                                {1, 2, 3},
                                {4, 5, 6}
                            };
            */

            int[,] numbers = new int[3, 3];

            int rows = numbers.GetLength(0);
            int columns = numbers.GetLength(1);

            Console.WriteLine($"rows: {rows}");
            Console.WriteLine($"columns: {columns}");

            numbers[0, 0] = 1;
            numbers[0, 1] = 2;
            numbers[0, 2] = 3;
            numbers[1, 0] = 4;
            numbers[1, 1] = 5;
            numbers[1, 2] = 6;
            numbers[2, 0] = 7;
            numbers[2, 1] = 8;
            numbers[2, 2] = 9;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numbers[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}