using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyDataStructure.Chapter5
{
    public static class ApplicationChapter5
    {
        public static bool IsPalindrome(string word)
        {
            StackMy<string> stackMy = new StackMy<string>();
            for (int i = 0; i < word.Length; i++)
            {
                stackMy.Push(word.Substring(i,1));
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (word.Substring(i,1)!=stackMy.Pop())
                {
                    return false;
                }
            }
            return true;
        }

        public static int Calculate(string expression)
        {
            StackMy<string> stackNums = new StackMy<string>();
            StackMy<string> stackOps = new StackMy<string>();
            StackMy<string> stackNumsTemp = new StackMy<string>();
            StackMy<string> stackOpsTemp = new StackMy<string>();
            for (int i = 0; i < expression.Length; i++)
            {
                string temp = expression.Substring(i, 1);
                if (IsNumberic(temp))
                {
                    stackNums.Push(temp);
                }
                else
                {
                    stackOps.Push(temp);
                }
            }


            
            return -1;
        }
        /// <summary>
        /// 判断输入的字符串是否为数字
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool IsNumberic(string input)
        {
            string pattern = (@"^\d+$");
            Regex validate = new Regex(pattern);
            if (validate.IsMatch(input))
            {
                return true;
            }
            return false;
        }

        public static string ConvertPositiveIntegerFromDecimalToOtherForms(int num, int form)
        {
            StackMy<int> tempData = new StackMy<int>();

            if (num==0)
            {
                return 0.ToString();
            }

            while (num!=0)
            {
                tempData.Push(num%form);
                num = num / form;
            }

            string temp=null;
            while (tempData.Count>0)
            {
                temp += tempData.Pop()+" ";
            }
            return temp;
        }

        public static void DoubleDigitQueueSort(int[] items)
        {
            QueueMy<int>[] datas = new QueueMy<int>[10];

            for (int i = 0; i < 10; i++)
            {
                datas[i] = new QueueMy<int>();
            }

            RSort(datas, items, DigitType.Ones);
            DisplayShuzu(items);

            RSort(datas, items, DigitType.Tens);
            DisplayShuzu(items);
        }

        private static void RSort(QueueMy<int>[] queues, int[] items, DigitType digitType)
        {
            int num;
            if (digitType==DigitType.Ones)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    var tempdata = items[i];
                    num = tempdata % 10;
                    queues[num].EnQueue(tempdata);
                }
            }
            else
            {
                for (int i = 0; i < items.Length; i++)
                {
                    var tempdata = items[i];
                    num = tempdata /10;
                    queues[num].EnQueue(tempdata);
                }
            }

            int index = 0;
            for (int i = 0; i < 10; i++)
            {
                while (queues[i].Count > 0)
                {
                    items[index] = queues[i].DeQueue();
                    index++;
                }
            }
        }
        private static void DisplayShuzu(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }
    }

    public enum DigitType
    {
        Ones,
        Tens
    }


}
