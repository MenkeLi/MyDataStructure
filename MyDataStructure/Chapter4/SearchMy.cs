using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure.Chapter4
{
    public static class SearchMy
    {
        public static bool SeqSearch(int[] items, int item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i]==item)
                {
                    return true;
                }
            }
            return false;
        }

        public static int SeqSearchFirstIndex(int[] items, int item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i]==item)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int FindMin(int[] items)
        {
            int min = items[0];
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i]<min)
                {
                    min = items[i];
                }
            }
            return min;
        }

        public static int BinSearch(int[] items, int item)
        {
            int minIndex=0;
            int maxIndex=items.Length-1;
            int middleIndex;
            int temp;

            while (minIndex<=maxIndex)
            {
                middleIndex = (minIndex + maxIndex) / 2;
                temp = items[middleIndex];
                if (item == temp)
                {
                    return middleIndex;
                }
                else if (temp > item)
                {
                    maxIndex = middleIndex - 1;
                }
                else
                {
                    minIndex = middleIndex + 1;
                }
            }
            return -1;
        }

        public static int RecursiveBinSearch(int[] items, int item, int minIndex, int maxIndex)
        {
            if (minIndex>maxIndex)
            {
                return -1;
            }

            int middleIndex = (minIndex + maxIndex) / 2;
            int temp = items[middleIndex];

            if (temp==item)
            {
                return middleIndex;
            }
            else if (temp>item)
            {
                return RecursiveBinSearch(items, item, minIndex, middleIndex - 1);
            }
            else
            {
                return RecursiveBinSearch(items, item, minIndex + 1, maxIndex);
            }
        }
    }


}
