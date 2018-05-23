using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure.Chapter3
{
    //在对于程序进行语言描述时，一定要按照实际发生了什么来说，不要说一些想当然的东西。同样，在写程序的时候，写出的代码要跟所想的东西一致。
    static class SortYuMy
    {
        /// <summary>
        /// 冒泡排序  有一个需要解决的问题是，有可能减少比较步数吗？
        /// </summary>
        /// <param name="items"></param>
        public static void BubbleSort(int[] items)
        {
            if (items == null || items.Length < 2)
            {
                return;
            }
            for (int outer = items.Length - 1; outer >= 1; outer--)
            {
                for (int inner = 0; inner < outer; inner++)
                {
                    if (items[inner]>items[inner+1])
                    {
                        int temp = items[inner];
                        items[inner] = items[inner + 1];
                        items[inner + 1] = temp;
                    }
                }
                Console.Write("冒泡排序第{0}轮: ",items.Length-outer);
                DisplayElement(items);
            }
        }

        public static void SelectionSort(int[] items)
        {
            if (items==null||items.Length < 2)
            {
                return;
            }
            int temp = 0;
            int minIndex = 0;
            for (int outer = 0; outer < items.Length-1; outer++)
            {
                minIndex = outer;
                int minValue = items[minIndex];
                for (int inner = outer+1; inner < items.Length; inner++)
                { 
                    if (minValue>items[inner])
                    {
                        minIndex = inner;
                        minValue = items[inner];
                    }
                }
                temp = items[minIndex];
                items[minIndex] = items[outer];
                items[outer] = temp;

                Console.Write("选择排序第{0}轮: ", outer+1);
                DisplayElement(items);
            }

        }

        public static void InsertionSort(int[] items)
        {
            if (items == null || items.Length < 2)
            {
                return;
            }
            int temp = 0;
            int positionIndex = 0;
            for (int i = 1; i < items.Length; i++)
            {
                temp = items[i];
                positionIndex = i;
                //for (int j = i-1; j >= 0; j--)
                //{
                //    if (temp<items[j])
                //    {
                //        items[j+1] = items[j];
                //        positionIndex = j;
                //    }
                //}
                while (positionIndex>=1&&temp<items[positionIndex-1] )
                {
                    items[positionIndex] = items[positionIndex-1];
                    positionIndex--;
                }
                items[positionIndex] = temp;

                Console.Write("插入排序第{0}轮: ", i);
                DisplayElement(items);
            }
        }

        public static void DisplayElement(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }

            Console.WriteLine();
        }

    }


}
