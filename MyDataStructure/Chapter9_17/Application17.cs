using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure.Chapter9_17
{
    public static class Application17
    {
        public static string GetLargestCommonSubString(string word1,string word2)
        {
            char[] charsWord1 = word1.ToArray();
            char[] charsWord2 = word2.ToArray();
            int len1 = charsWord1.Length;
            int len2 = charsWord2.Length;
            int[,] arr = new int[len1+1, len2+1];



            for (int i = 1; i < arr.GetLength(0); i++)
            {
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    if (charsWord1[i-1]==charsWord2[j-1])
                    {
                        arr[i, j] = arr[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                }
            }

            int tempRow = 0;
            int temp = 0;
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j]>temp)
                    {
                        temp = arr[i, j];
                        tempRow = i-1;
                    }
                }
            }

            string subString = word1.Substring(tempRow - temp+1, temp);

            //for (int i = 0; i < temp; i++)
            //{
            //    subString = word1[tempRow - i] + subString;
            //}

            return subString;
        }

        //todo:背包问题  再仔细思考一下，还是没太想明白  目前的方法还存在重复拿的问题！！！（即认为宝物不止一件）
        public static void Beibao()
        {
            int capacity = 15;
            int[] size = new int[] {3, 4, 7, 8, 9};
            int[] values = new int[] {4, 5, 10, 11, 13};
            int[] toval = new int[capacity + 1];
            int[] best = new int[capacity + 1];
            int n = values.Length;

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < capacity+1; i++)
                {
                    if (i>=size[j])
                    {
                        if (toval[i]<toval[i-size[j]]+values[j])
                        {
                            toval[i] = toval[i - size[j]] + values[j];
                            best[i] = j;
                            //break;
                        }
                    }
                }
            }

            Console.WriteLine("The maximum value is: " + toval[capacity]);
        }

    }
}
