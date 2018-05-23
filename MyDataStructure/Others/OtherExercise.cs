using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure.Others
{
    public static class OtherExercise
    {
       public  static void PrintImage(int row, int col)
        {
            byte[] temp = new byte[1];
            string tempString;

            for (int i = 0; i < row; i++)
            {
                Console.Write("     ");
                for (int j = 0; j < col; j++)
                {
                    temp[0] = (byte)(CalculateNum(i + 1, j + 1, row, col) % 26);
                    if (temp[0] == 0)
                    {
                        temp[0] = 26;
                    }

                    temp[0] += 64;
                    Console.Write(ASCIIEncoding.ASCII.GetString(temp) + "    ");
                }

                Console.WriteLine();
                Console.WriteLine();
            }

        }

        public static int CalculateNum(int row, int col, int rowMax, int colMax)
        {
            int cal = 0;
            int k = Math.Min(Math.Min(row, colMax - col + 1), Math.Min(rowMax - row + 1, col));
            for (int i = 1; i < k; i++)
            {
                cal += 2 * (colMax - 2 * (i - 1) - 1) + 2 * (rowMax - 2 * (i - 1) - 1);
            }

            if (k == row)
            {
                cal += col - (k - 1);
            }
            else if (k == colMax - col + 1)
            {
                cal += colMax - 2 * (k - 1) + row - k;
            }
            else if (k == rowMax - row + 1)
            {
                cal += 2 * (colMax - 2 * (k - 1) - 1) + rowMax - 2 * (k - 1) - 1 + k - (col - 1);
            }
            else if (k == col)
            {
                cal += 2 * (colMax - 2 * (k - 1) - 1) + 2 * (rowMax - 2 * (k - 1) - 1) + k - (row - 1);
            }
            return cal;
        }
    }
}
