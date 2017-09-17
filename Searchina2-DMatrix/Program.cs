using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchina2_DMatrix
{
    class Program
    {
        static bool Findings(int[][] matrix, int value)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int start = 0;
            int end = rows * cols - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                int row = mid / cols;
                int col = mid % cols;
                int v = matrix[row][col];
                if (v == value)
                    return true;
                if (v > value)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[][] Matrix =
            {
               new int[] { 1, 3, 5 },
                new int[]{ 7, 9 ,11},
               new int[] { 13, 15, 17},
            };
            int v = 50;
            System.Console.WriteLine(Findings(Matrix,v));
        }
    }
}
