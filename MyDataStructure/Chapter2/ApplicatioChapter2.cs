using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure.Chapter2
{
    public static class ApplicatioChapter2
    {
        public static int CalculateNum(int row, int col, int rowMax, int colMax)
        {
            int cal = 0;
            int k = Math.Min(Math.Min(row, colMax - col + 1), Math.Min(rowMax - row + 1, col));
            for (int i = 1; i < k; i++)
            {
                cal += 2 * (colMax - 2 * (i - 1) - 1) + 2 * (rowMax - 2*(i - 1) - 1);
            }

            if (k==row)
            {
                cal += col - (k - 1);
            }
            else if (k==colMax-col+1)
            {
                cal += colMax - 2 * (k - 1) + row - k;
            }
            else if (k==rowMax-row+1)
            {
                cal += 2 * (colMax - 2 * (k - 1) - 1) + rowMax - 2 * (k - 1) - 1 + k - (col - 1);
            }
            else if (k==col)
            {
                cal += 2 * (colMax - 2 * (k - 1) - 1) + 2 * (rowMax - 2 * (k - 1) - 1) + k - (row - 1);
            }
            return cal;
        }
    }
}
