using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDataStructure.Chapter2;

namespace MyDataStructure.Chapter6
{
    public static class ApplicationChapter6
    {
        /// <summary>
        /// 用数组寻找素数的方法
        /// </summary>
        /// <param name = "min" ></ param >
        /// < param name="max"></param>
        /// <returns></returns>
        public static int[] SearchPrimes(int min, int max)
        {
            ListMy<int> tempList = new ListMy<int>();

            int[] tempInts = new int[max];
            tempInts[0] = 0;
            tempInts[1] = 0;
            for (int i = 2; i < max; i++)
            {
                tempInts[i] = 1;
            }

            for (int i = 2; i < max; i++)
            {
                for (int j = i + 1; j < max; j++)
                {
                    if (tempInts[j] == 1 && j % i == 0)
                    {
                        tempInts[j] = 0;
                    }
                }
            }

            //Console.WriteLine("在范围{0}到{1}之间，所有的素数为：",min,max);
            for (int i = min; i < max; i++)
            {
                int temp = tempInts[i];
                if (temp == 1)
                {
                    //Console.Write(i + "  ");
                    tempList.Add(i);
                }
            }

            return tempList.ToArray();
        }

        public static int[] SearchPrimesUseBitArray(int min, int max)
        {
            ListMy<int> tempInts = new ListMy<int>();
            BitArrayMy bitArrayMy = new BitArrayMy(max);
            bitArrayMy.SetAll(true);
            bitArrayMy.Set(0, false);
            bitArrayMy.Set(1, false);

            for (int i = 2; i < max; i++)
            {
                for (int j = i + 1; j < max; j++)
                {
                    if (bitArrayMy.Get(j) && j % i == 0)
                    {
                        bitArrayMy.Set(j, false);
                    }
                }
            }

            for (int i = min; i < max; i++)
            {
                if (bitArrayMy.Get(i))
                {
                    tempInts.Add(i);
                }
            }

            return tempInts.ToArray();
        }

        public static int[] SearchPrimesUseBitArrayGaijin(int min, int max)
        {
            ListMy<int> tempInts = new ListMy<int>();
            BitArrayMy bitArrayMy = new BitArrayMy(max);
            bitArrayMy.SetAll(true);
            bitArrayMy.Set(0, false);
            bitArrayMy.Set(1, false);

            int upper = (int) Math.Sqrt(max);

            for (int i = 2; i < upper + 1; i++)
            {
                for (int j = i + 1; j < max; j++)
                {
                    if (bitArrayMy.Get(j) && j % i == 0)
                    {
                        bitArrayMy.Set(j, false);
                    }
                }
            }

            for (int i = min; i < max; i++)
            {
                if (bitArrayMy.Get(i))
                {
                    tempInts.Add(i);
                }
            }

            return tempInts.ToArray();
        }
    }
}
