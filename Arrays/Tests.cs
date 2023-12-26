using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gee.External.Capstone.PowerPc;

namespace studies.Arrays
{
    public static class Tests
    {
        public static int GetDiagonalDifference()
        {
            int[,] arr = new int[4, 3];

            arr[0, 0] = 3;
            arr[1, 0] = 11;
            arr[1, 1] = 2;
            arr[1, 2] = 4;
            arr[2, 0] = 4;
            arr[2, 1] = 5;
            arr[2, 2] = 6;
            arr[3, 0] = 10;
            arr[3, 1] = 8;
            arr[3, 2] = 12;

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            int n = arr.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                primaryDiagonalSum += arr[i, i];
                secondaryDiagonalSum += arr[i, n - 1 - i];
            }

            return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            int n = arr.Count;

            for (int i = 0; i < n; i++)
            {
                primaryDiagonalSum += arr[i][i];
                secondaryDiagonalSum += arr[i][n - 1 - i];
            }

            return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
        }

        public static int Coins(int n)
        {
            var count = 0;

            for(var candidate = 1; candidate <= Math.Sqrt(n); candidate ++){
                if(candidate * candidate == n){
                count ++;
                }else if(n % candidate == 0)
                    count += 2;
            }
            return count;
        }
    }

    
}