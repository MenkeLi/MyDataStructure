using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure.Chapter9
{
    public static class Application9
    {
        public static void TestDic()
        {
            SortedListMy<string, string> sortedListMy = new SortedListMy<string, string>();
            sortedListMy.Add("and", "与");
            sortedListMy.Add("or", "或");
            sortedListMy.Add("not", "否");
            sortedListMy.Add("test", "测试");
            sortedListMy.Add("Dic", "词典");
            //sortedListMy.Add("dhdhkjkjkjdjkajkkjfdkjsafjkd", "ces");

            for (int i = 0; i < sortedListMy.Count; i++)
            {
                Console.Write(("找到的单词是:" + sortedListMy.GetKey(i)).PadRight(20));
                Console.WriteLine("它的意思是:{0}", sortedListMy[sortedListMy.GetKey(i)]);
            }
        }

        public static void SearchWordsNum(string sentence)
        {
            DictionaryMy<string, int> dictionaryMy = new DictionaryMy<string, int>();
            Dictionary<string, int> pairs = new Dictionary<string, int>();
            

            string[] words = sentence.Split(new char[]{',',' ','?'},StringSplitOptions.RemoveEmptyEntries);//系统String自带的Split()函数，无法处理连续空格的问题
            for (int i = 0; i < words.Length; i++)
            {
                if (dictionaryMy.ContainsKey(words[i]))
                {
                    dictionaryMy[words[i]]++;
                }
                else
                {
                    dictionaryMy.Add(words[i], 1);
                }
            }

            foreach (string key in dictionaryMy.Keys)
            {
                Console.WriteLine("单词\"{0}\"共计出现了{1}次",key,dictionaryMy[key]);
            }
        }

        public static void SearchCharNum(string sentence)
        {
            DictionaryMy<char, int> dictionaryMy = new DictionaryMy<char, int>();



            string[] words = sentence.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);//系统String自带的Split()函数，无法处理连续空格的问题
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (dictionaryMy.ContainsKey(words[i][j]))
                    {
                        dictionaryMy[words[i][j]]++;
                    }
                    else
                    {
                        dictionaryMy.Add(words[i][j], 1);
                    }
                }

            }

            foreach (char key in dictionaryMy.Keys)
            {
                Console.WriteLine("字母\"{0}\"共计出现了{1}次", key, dictionaryMy[key]);
            }
        }
    }
}
