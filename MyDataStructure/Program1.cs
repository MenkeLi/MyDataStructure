using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MyDataStructure.Chapter2;
using MyDataStructure.Chapter3;
using MyDataStructure.Chapter4;
using MyDataStructure.Chapter5;
using MyDataStructure.Chapter6;
using MyDataStructure.Chapter7;
using MyDataStructure.Chapter9;
using MyDataStructure.Chapter9_11;
using MyDataStructure.Chapter9_12;
using MyDataStructure.Chapter9_16;
using MyDataStructure.Chapter9_17;
using MyDataStructure.Others;

namespace MyDataStructure
{
    class Program1
    {
        //我只是来做实验的
        static void Main(string[] args)
        {
            #region 第一章测试

            //int[] nums = new int[100000];
            //BuildArray(nums);
            //Timing timeTest = new Timing();
            //timeTest.StartTime();
            //Display(nums);
            //timeTest.StopTime();
            //double temp = timeTest.Result().TotalSeconds;
            //Console.WriteLine(timeTest.Result().TotalSeconds);

            //timeTest.Reset();
            //timeTest.StartTime();
            //Display(nums);
            //timeTest.StopTime();
            //Console.Write(temp+"   ");
            //Console.WriteLine(timeTest.Result().TotalSeconds);
            //Console.Read();

            #endregion

            #region 第二章测试


            //ArrayListMy arrayListMy = new ArrayListMy();
            //DisplayArrayListMy(arrayListMy);
            //arrayListMy.Add("Beijing");
            //DisplayArrayListMy(arrayListMy);
            //arrayListMy.Add("Shanghai");
            //DisplayArrayListMy(arrayListMy);
            //arrayListMy.Add("Guangzhou");
            //DisplayArrayListMy(arrayListMy);
            //Console.WriteLine("我现在的容量是:{0}",arrayListMy.Capacity);
            //Console.WriteLine("我现在的个数是:{0}", arrayListMy.Count);

            //arrayListMy.Clear();
            //DisplayArrayListMy(arrayListMy);
            //Console.WriteLine("我现在的容量是:{0}", arrayListMy.Capacity);
            //Console.WriteLine("我现在的个数是:{0}", arrayListMy.Count);

            //DisplayArrayListMy(arrayListMy);
            //arrayListMy.Add("Beijing");
            //arrayListMy.Add("Shanghai");
            //arrayListMy.Add("Guangzhou");
            //Console.WriteLine(arrayListMy.Contains("Guangzhou"));
            //Console.WriteLine(arrayListMy.Contains("Shenzhen"));

            //var tempData = arrayListMy.CopyTo(0);
            //DisplayShuzu(tempData);
            //var tempData1 = arrayListMy.CopyTo(2);
            //DisplayShuzu(tempData1);

            //var tempArray1 = arrayListMy.GetRange(0,1);
            //DisplayArrayListMy(tempArray1);
            //var tempArray2 = arrayListMy.GetRange(1, 2);
            //DisplayArrayListMy(tempArray2);

            //Console.WriteLine(arrayListMy.IndexOf("Beijing"));
            //Console.WriteLine(arrayListMy.IndexOf("Guangzhou"));
            //Console.WriteLine(arrayListMy.IndexOf("Shenzhen"));

            //ArrayListMy tempArray = new ArrayListMy();
            //tempArray.Add("Wei");
            //tempArray.Add("Shu");
            //tempArray.Add("Wu");

            //arrayListMy.AddRange(tempArray);
            //DisplayArrayListMy(arrayListMy);
            //Console.WriteLine("我现在的容量是:{0}", arrayListMy.Capacity);
            //Console.WriteLine("我现在的个数是:{0}", arrayListMy.Count);
            //arrayListMy.Insert(1, "Shenzhen");
            //DisplayArrayListMy(arrayListMy);
            //Console.WriteLine("我现在的容量是:{0}", arrayListMy.Capacity);
            //Console.WriteLine("我现在的个数是:{0}", arrayListMy.Count);
            //arrayListMy.InsertRange(2, tempArray);
            //DisplayArrayListMy(arrayListMy);
            //Console.WriteLine("我现在的容量是:{0}", arrayListMy.Capacity);
            //Console.WriteLine("我现在的个数是:{0}", arrayListMy.Count);
            //arrayListMy.InsertRange(6, tempArray);
            //DisplayArrayListMy(arrayListMy);
            //Console.WriteLine("我现在的容量是:{0}", arrayListMy.Capacity);
            //Console.WriteLine("我现在的个数是:{0}", arrayListMy.Count);

            ////var tempArray3 = arrayListMy;
            ////tempArray.AddRange(tempArray3);
            //tempArray.InsertRange(1,tempArray);
            //arrayListMy.InsertRange(6,tempArray);

            //DisplayArrayListMy(arrayListMy);
            //Console.WriteLine("我现在的容量是:{0}", arrayListMy.Capacity);
            //Console.WriteLine("我现在的个数是:{0}", arrayListMy.Count);

            ////arrayListMy.InsertRange(1, tempArray);
            ////DisplayArrayListMy(arrayListMy);
            ////Console.WriteLine("我现在的容量是:{0}", arrayListMy.Capacity);
            ////Console.WriteLine("我现在的个数是:{0}", arrayListMy.Count);


            ////arrayListMy.AddRange(tempArray);
            ////DisplayArrayListMy(arrayListMy);
            ////Console.WriteLine("我现在的容量是:{0}", arrayListMy.Capacity);
            ////Console.WriteLine("我现在的个数是:{0}", arrayListMy.Count);

            //Console.Read();

            #endregion

            #region 第三章测试

            //int[] temp = GetRandomNumbers(1, 500, 20);
            //var temp1 = (int[])temp.Clone();
            //var temp2 = (int[]) temp.Clone();

            ////SortYuMy.DisplayElement(temp);
            ////SortYuMy.BubbleSort(temp);
            ////Console.WriteLine("----------------------------------------------------------------");
            ////SortYuMy.DisplayElement(temp1);
            ////SortYuMy.SelectionSort(temp1);
            ////Console.WriteLine("----------------------------------------------------------------");
            //SortYuMy.DisplayElement(temp2);
            //SortYuMy.InsertionSort(temp2);



            ////int a = 10;
            ////int b = 20;
            ////Console.WriteLine("{0} {1}", a, b);
            ////SortYuMy.Swap(a, b);
            ////Console.WriteLine("{0} {1}", a, b);


            //Console.Read();

            #endregion

            #region 第四章测试

            //int[] tempList = GetRandomNumbers(50, 100, 20);
            //SortYuMy.DisplayElement(tempList);
            //Console.WriteLine("顺序查找结果——数组中值88所在的位置是：{0}", SearchMy.SeqSearchFirstIndex(tempList, 88));
            //SortYuMy.SelectionSort(tempList);
            //Console.WriteLine("数组中最小的值为：{0}",SearchMy.FindMin(tempList));
            //Console.WriteLine("二叉查找结果——数组中值88所在的位置是：{0}", SearchMy.BinSearch(tempList,88));
            //Console.WriteLine("递归二叉查找结果——数组中值88所在的位置是：{0}", SearchMy.RecursiveBinSearch(tempList,88,0,tempList.Length-1));

            //Console.Read();

            #endregion

            #region 第五章测试

            //while (true)
            //{
            //    Console.Write("请输入单词:");
            //    string temp = Console.ReadLine();
            //    if (ApplicationChapter5.IsPalindrome(temp))
            //    {
            //        Console.WriteLine("输入的单词" + "'" + temp + "'" + " 是 回文");
            //    }
            //    else
            //    {
            //        Console.WriteLine("输入的单词" + "'" + temp + "'" + " 不是 回文");
            //    }

            //    Console.WriteLine();
            //}


            //*****************************************************************************************
            //while (true)
            //{
            //    Console.Write("请输入十进制数字:");
            //    string temp = Console.ReadLine();

            //    Console.WriteLine("转换成二进制为：{0}", ApplicationChapter5.ConvertPositiveIntegerFromDecimalToOtherForms(Convert.ToInt32(temp), 2));
            //    Console.WriteLine("转换成八进制为：{0}", ApplicationChapter5.ConvertPositiveIntegerFromDecimalToOtherForms(Convert.ToInt32(temp), 8));
            //    Console.WriteLine("转换成十六进制为：{0}", ApplicationChapter5.ConvertPositiveIntegerFromDecimalToOtherForms(Convert.ToInt32(temp), 16));
            //    Console.WriteLine();
            //}


            //*****************************************************************************************
            //int[] temp = GetRandomNumbers(0, 100, 20);
            //ApplicationChapter5.DoubleDigitQueueSort(temp);


            //*****************************************************************************************
            //PriorityQueue<ProcessMy> items = new PriorityQueue<ProcessMy>();
            //ProcessMy[] processeS = new ProcessMy[3];
            //processeS[0].Priority = 10;
            //processeS[0].Name = "S10";
            //processeS[1].Priority = 6;
            //processeS[1].Name = "S6";
            //processeS[2].Priority = 8;
            //processeS[2].Name = "S8";

            //for (int i = 0; i < processeS.Length; i++)
            //{
            //    items.EnQueue(processeS[i]);
            //}

            //while (items.Count>0)
            //{
            //    Console.WriteLine("{0}",items.DeQueue().Name);
            //}




            //*****************************************************************************************
            //Stack<int> stack = new Stack<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    stack.Push(i);
            //}

            //int[] temp = new int[stack.Count];
            //stack.CopyTo(temp,0);
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.Write("{0} ",temp[i]);
            //}

            //Console.WriteLine();
            //int[] temp1 = stack.ToArray();
            //for (int i = 0; i < temp1.Length; i++)
            //{
            //    Console.Write("{0} ",temp1[i]);
            //}





            //Console.Read();

            #endregion

            #region 第六章测试

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormChapter6());


            //**********************************************************************************
            //byte[] bytes = new byte[] { 1,2,3,4,5};
            //BitArrayMy bitArrayMy = new BitArrayMy(bytes);

            //StackMy<string> tempStack = new StackMy<string>();
            //for (int i = 0; i < bitArrayMy.Count; i++)
            //{
            //    if (bitArrayMy.Get(i))
            //    {
            //        tempStack.Push("1");
            //    }
            //    else
            //    {
            //        tempStack.Push("0");
            //    }

            //    if ((i+1)%8==0)
            //    {
            //        for (int j = 0; j < 8; j++)
            //        {
            //            Console.Write(tempStack.Pop());
            //        }
            //        Console.WriteLine();
            //    }
            //}


            //**********************************************************************************
            //Console.WriteLine("标准数组寻找的结果是：");
            //DisplayShuzu(ApplicationChapter6.SearchPrimes(100, 1000));
            //Console.WriteLine("BitArray数组寻找的结果是：");
            //DisplayShuzu(ApplicationChapter6.SearchPrimesUseBitArray(100, 1000));
            //Console.WriteLine("改进算法寻找的结果是：");
            //DisplayShuzu(ApplicationChapter6.SearchPrimesUseBitArrayGaijin(100, 1000));


            //Timing timing = new Timing();

            //timing.StartTime();
            //ApplicationChapter6.SearchPrimes(0, 100000);
            //timing.StopTime();
            //DisplayShuzu(ApplicationChapter6.SearchPrimes(0, 100000));
            //Console.WriteLine("标准数组寻找消耗的时间是：{0}", timing.Result().TotalSeconds);

            //timing.Restart();
            //ApplicationChapter6.SearchPrimesUseBitArray(0, 100000);
            //timing.StopTime();
            //Console.WriteLine("BitArray数组寻找消耗的时间是：{0}", timing.Result().TotalSeconds);

            //timing.Restart();
            //ApplicationChapter6.SearchPrimesUseBitArrayGaijin(0, 100000);
            //timing.StopTime();
            //DisplayShuzu(ApplicationChapter6.SearchPrimesUseBitArrayGaijin(0, 100000));
            //Console.WriteLine("改进算法寻找消耗的时间是：{0}", timing.Result().TotalSeconds);


            //Console.Read();


            #endregion

            #region 第七章测试

            //string stringMy = "Now you are good";
            //char[] delimiter = new char[] {' '};
            //var temp = stringMy.Split(delimiter);
            //for (int i = 0; i < temp.Length; i++)
            //{
            //    Console.WriteLine(temp[i]);
            //}
            //String.Join()
            //String.Concat()
            //Console.Write("  hello".Trim(new char[]{' ','h','e'}));
            //Console.WriteLine("hello".ToUpper());

            //**********************************************************************************
            //StringBuilder stringBuilder = new StringBuilder("Ken Thompson");
            //stringBuilder[]
            //Console.WriteLine(@"length:{0},\n capacity:{1},\n maxCapacity{2}",stringBuilder.Length,stringBuilder.Capacity,stringBuilder.MaxCapacity);

            //**********************************************************************************
            //string stringMy = "Now you are good";
            //Console.WriteLine(stringMy);
            //stringMy = ApplicationChapter7.ReverseWords(stringMy);
            //Console.WriteLine(stringMy);


            //**********************************************************************************
            //string stringTemp = "and on and on adn on";
            //StringBuilder stringBuilder = new StringBuilder("and on on on on and an and");
            //Console.WriteLine(ApplicationChapter7.WordNums(stringTemp,"and"));
            //Console.WriteLine(ApplicationChapter7.WordNums(stringTemp, "on"));

            //Console.WriteLine(ApplicationChapter7.WordNums(stringBuilder, "and"));
            //Console.WriteLine(ApplicationChapter7.WordNums(stringBuilder, "on"));

            //**********************************************************************************
            //while (true)
            //{
            //    Console.Write("请输入一个大于19的两位数：");
            //    Console.WriteLine("您输入的数字是：{0}",
            //        ApplicationChapter7.ConvertDoubleDigitToString(Convert.ToInt32(Console.ReadLine())));
            //}


            //Console.Read();


            #endregion

            #region 第八章测试

            //Regex regex = new Regex("the");
            //string str1 = "quick brown fox the jumped over the lazy dog";
            //Match match;
            //int matchPos;
            //match = regex.Match(str1);
            //if (match.Success)
            //{
            //    matchPos = match.Index;
            //    Console.WriteLine(matchPos);
            //}

            //**********************************************************************************
            //string[] words = new string[] { "bad", "boy", "baad", "bd", "baaad", "baaam", "adsds", "dss" };
            //foreach (var word in words)
            //{
            //if (Regex.IsMatch(word, "a*d"))
            //    {
            //        Console.WriteLine(word);
            //    }
            //}


            //**********************************************************************************
            //string[] words = new string[] {"sfrdre>", "<bnj>hjfk</sdrds>"};
            //string regEx = "d*";
            //MatchCollection matchCollection;
            //foreach (var word in words)
            //{
            //    if (Regex.IsMatch(word, regEx))
            //    {
            //        matchCollection = Regex.Matches(word, regEx);
            //        for (int i = 0; i < matchCollection.Count; i++)
            //        {
            //            Console.WriteLine(matchCollection[i].Value);
            //        }
            //    }
            //}


            //**********************************************************************************
            //string words = "08/14/57 46 89/45/45 78 "+"12/34/54 67 45/65/67 45";
            //string regExp = "(?<datas>(\\d{2}/\\d{2}/d{2}))\\s(?<ages>(\\d{2}))\\s";
            //MatchCollection matchCollection = Regex.Matches(words, regExp);

            //foreach (Match match in matchCollection)
            //{
            //    foreach (Capture capture in match.Groups["datas"].Captures)
            //    {
            //        Console.WriteLine(capture);
            //    }
            //    foreach (Capture capture in match.Groups["ages"].Captures)
            //    {
            //        Console.WriteLine(capture);
            //    }
            //}



            //Console.Read();

            #endregion

            #region 循环打印测试

            //Timing timing = new Timing();
            //while (true)
            //{
            //    Console.Write("请输入要绘制的图形的行数：");
            //    int row = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("请输入要绘制的图形的列数：");
            //    int col = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine();
            //    Console.WriteLine("为您绘制您所想要的图形如下图：");
            //    Console.WriteLine();

            //    timing.Restart();
            //    OtherExercise.PrintImage(row, col);
            //    timing.StopTime();
            //    Console.WriteLine("本次打印耗费的时间是 {0} ms",timing.Result().TotalMilliseconds);
            //    Console.WriteLine();
            //}



            //Console.Read();

            #endregion

            #region 第九章测试

            //DictionaryMy<string, string> ss = new DictionaryMy<string, string>();
            //Application9.TestDic();


            //**********************************************************************************
            //while (true)
            //{
            //    Console.Write("Please input a sentence:");
            //    string input = Console.ReadLine();
            //    Application9.SearchWordsNum(input);
            //    Console.WriteLine();
            //}


            //**********************************************************************************
            //while (true)
            //{
            //    Console.Write("Please input a sentence:");
            //    string input = Console.ReadLine();
            //    Application9.SearchCharNum(input);
            //    Console.WriteLine();
            //}



            //Console.Read();

            #endregion

            #region 第十章测试

            //Hashtable hashtable = new Hashtable(25);
            //hashtable.Add("salary", 100000);
            //hashtable.Add("name", "David Durr");
            //hashtable.Add("age", 43);
            //hashtable.Add("dept", "Information Technology");
            //hashtable["sex"] = "Male";
            //foreach (var key in hashtable.Keys)
            //{
            //    var ss = hashtable[key];
            //    Console.WriteLine(key);
            //}



            //Console.WriteLine();

            //foreach (var value in hashtable.Values)
            //{
            //    Console.WriteLine(value);
            //}


            //Console.Read();

            #endregion

            #region 第十一章测试

            //*****************************最基本的链表*****************************************************
            //LinkedListObjectMy linkedListBiDirectionMy = new LinkedListObjectMy();

            //linkedListBiDirectionMy.Insert("first", "header");
            //linkedListBiDirectionMy.Insert("second", "first");
            //linkedListBiDirectionMy.Insert("third", "second");

            //linkedListBiDirectionMy.PrintLinkedList();

            //Console.ReadLine();
            //**********************************************************************************

            //*****************************泛型链表*****************************************************
            //LinkedListBiDirectionMy<string> linkedListBiDirectionMy = new LinkedListBiDirectionMy<string>("header");
            //linkedListBiDirectionMy.Insertion("one", "header");
            //linkedListBiDirectionMy.Insertion("two", "one");
            //linkedListBiDirectionMy.Insertion("three", "two");
            //linkedListBiDirectionMy.Insertion("four", "three");
            //linkedListBiDirectionMy.Insertion("five", "four");

            //linkedListBiDirectionMy.PrintLinkedList();
            //Console.WriteLine("******************");
            //linkedListBiDirectionMy.Remove("three");
            //linkedListBiDirectionMy.PrintReverse();
            //Console.ReadLine();
            //**********************************************************************************

            #endregion

            #region 第十二章测试

            //**********************************************************************************
            //BinarySearchTreeMy binarySearchTreeMy = new BinarySearchTreeMy(50);
            //binarySearchTreeMy.Insert(10);
            //binarySearchTreeMy.Insert(70);
            //binarySearchTreeMy.Insert(60);
            //binarySearchTreeMy.Insert(15);
            //binarySearchTreeMy.Insert(80);
            //binarySearchTreeMy.Insert(5);

            //Console.WriteLine("中序遍历的结果是：");
            //binarySearchTreeMy.InOrder();
            //Console.WriteLine("先序遍历的结果是：");
            //binarySearchTreeMy.PreOrder();
            //Console.WriteLine("后序遍历的结果是：");
            //binarySearchTreeMy.PostOrder();

            //Console.WriteLine("最小值是：{0}", binarySearchTreeMy.FindMin());
            //Console.WriteLine("最大值是：{0}", binarySearchTreeMy.FindMax());
            //Console.WriteLine("查找：{0}", binarySearchTreeMy.Contained(75));
            //Console.WriteLine("查找：{0}", binarySearchTreeMy.Contained(60));
            //Console.ReadLine();

            //**********************************************************************************
            //BinarySearchTreeMy binarySearchTreeMy = new BinarySearchTreeMy();
            //binarySearchTreeMy.Insert(8);
            //binarySearchTreeMy.Insert(4);
            //binarySearchTreeMy.Insert(2);
            //binarySearchTreeMy.Insert(6);
            //binarySearchTreeMy.Insert(1);
            //binarySearchTreeMy.Insert(3);
            //binarySearchTreeMy.Insert(5);
            //binarySearchTreeMy.Insert(7);
            //binarySearchTreeMy.Insert(12);
            //binarySearchTreeMy.Insert(14);
            //binarySearchTreeMy.Insert(10);
            //binarySearchTreeMy.Insert(9);
            //binarySearchTreeMy.Insert(11);
            //binarySearchTreeMy.Insert(15);
            //binarySearchTreeMy.Insert(13);

            ////binarySearchTreeMy.Delete(8);
            //binarySearchTreeMy.Delete(4);

            //Console.WriteLine("中序遍历的结果是：");
            //binarySearchTreeMy.InOrder();
            //Console.WriteLine("先序遍历的结果是：");
            //binarySearchTreeMy.PreOrder();
            //Console.WriteLine("后序遍历的结果是：");
            //binarySearchTreeMy.PostOrder();



            //Console.ReadLine();
            #endregion

            #region 第十六章测试

            //*****************拓扑排序测试一*****************************************************************
            //GraphMy<string> graphMy = new GraphMy<string>(4);

            //graphMy.AddVertex("A");
            //graphMy.AddVertex("B");
            //graphMy.AddVertex("C");
            //graphMy.AddVertex("D");

            //graphMy.AddEdge(0, 1);
            //graphMy.AddEdge(1, 2);
            //graphMy.AddEdge(2, 3);

            //graphMy.TopSort();
            //Console.ReadLine();

            //*****************拓扑排序测试二*****************************************************************
            //GraphMy<string> graphMy = new GraphMy<string>(6);

            //graphMy.AddVertex("0");
            //graphMy.AddVertex("1");
            //graphMy.AddVertex("2");
            //graphMy.AddVertex("3");
            //graphMy.AddVertex("4");
            //graphMy.AddVertex("5");

            //graphMy.AddEdge(0, 1);
            //graphMy.AddEdge(1, 2);
            //graphMy.AddEdge(1, 5);
            //graphMy.AddEdge(2, 3);
            //graphMy.AddEdge(2, 4);

            //graphMy.TopSort();
            //Console.ReadLine();

            //*****************深度，广度优先搜索测试*****************************************************************
            //GraphMy<string> graphMy = new GraphMy<string>(13);
            //graphMy.AddVertex("A");
            //graphMy.AddVertex("B");
            //graphMy.AddVertex("C");
            //graphMy.AddVertex("D");
            //graphMy.AddVertex("E");
            //graphMy.AddVertex("F");
            //graphMy.AddVertex("G");
            //graphMy.AddVertex("H");
            //graphMy.AddVertex("I");
            //graphMy.AddVertex("J");
            //graphMy.AddVertex("K");
            //graphMy.AddVertex("L");
            //graphMy.AddVertex("M");

            //graphMy.AddEdge(0, 1);
            //graphMy.AddEdge(1, 2);
            //graphMy.AddEdge(2, 3);
            //graphMy.AddEdge(0, 4);
            //graphMy.AddEdge(4, 5);
            //graphMy.AddEdge(5, 6);
            //graphMy.AddEdge(0, 7);
            //graphMy.AddEdge(7, 8);
            //graphMy.AddEdge(8, 9);
            //graphMy.AddEdge(0, 10);
            //graphMy.AddEdge(10, 11);
            //graphMy.AddEdge(11, 12);

            //Console.WriteLine("深度优先的搜索结果为：");
            //graphMy.DepthFirstSearch();
            //Console.WriteLine();

            //Console.WriteLine("广度优先的搜索结果为：");
            //graphMy.WidthFirstSearch();

            //Console.ReadLine();

            //****************Dijkstra最短路径测试*****************************************************************
            //GraphWeightMy<string> graphWeightMy = new GraphWeightMy<string>(7);
            //graphWeightMy.AddVertex("A");
            //graphWeightMy.AddVertex("B");
            //graphWeightMy.AddVertex("C");
            //graphWeightMy.AddVertex("D");
            //graphWeightMy.AddVertex("E");
            //graphWeightMy.AddVertex("F");
            //graphWeightMy.AddVertex("G");

            //graphWeightMy.AddEdge(0, 1, 2);
            //graphWeightMy.AddEdge(0, 3, 1);
            //graphWeightMy.AddEdge(1, 3, 3);
            //graphWeightMy.AddEdge(1, 4, 10);
            //graphWeightMy.AddEdge(2, 5, 5);
            //graphWeightMy.AddEdge(2, 0, 4);
            //graphWeightMy.AddEdge(3, 2, 2);
            //graphWeightMy.AddEdge(3, 5, 8);
            //graphWeightMy.AddEdge(3, 4, 2);
            //graphWeightMy.AddEdge(3, 6, 4);
            //graphWeightMy.AddEdge(4, 6, 6);
            //graphWeightMy.AddEdge(6, 5, 1);

            //graphWeightMy.DijkltraPath(0);

            //Console.ReadLine();

            #endregion

            #region 第十七章测试
            //*****************寻找最长公共子串*****************************************************************

            while (true)
            {
                Console.Write("请输入两个字符串，中间用空格隔开：");
                string inputString = Console.ReadLine();
                string[] tempStringS = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string temp = Application17.GetLargestCommonSubString(tempStringS[0], tempStringS[1]);
                if (temp == null)
                {
                    Console.WriteLine("您输入的两个字符串没有公共子字符串！");
                }
                else
                {
                    Console.WriteLine("您输入的两个字符串的公共子字符串是：" + temp);
                    //Console.WriteLine("");
                }

                Console.WriteLine();
                //Console.ReadLine();
            }

            //*****************背包问题的动态规划解法*****************************************************************
            //Application17.Beibao();
            //Console.ReadLine();



            #endregion
        }

        #region 第一章测试用辅助函数

        //static void BuildArray(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = i;
        //    }
        //}

        //static void Display(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //}

        #endregion

        #region 第二章测试用辅助函数

        //static void DisplayArrayListMy(ArrayListMy arrayListMy)
        //{
        //    Console.WriteLine();
        //    var temp = arrayListMy.ToArray();
        //    for (int i = 0; i < temp.Length; i++)
        //    {
        //        Console.Write(temp[i] + " ");
        //    }

        //    Console.WriteLine();
        //}

        //static void DisplayShuzu(object[] data)
        //{
        //    Console.WriteLine();
        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        Console.Write(data[i] + " ");
        //    }

        //    Console.WriteLine();
        //}

        #endregion

        #region 第三章测试用辅助函数

        //static int[] GetRandomNumbers(int min, int max,int length)
        //{
        //    Random random = new Random();
        //    int[] temp = new int[length];
        //    for (int i = 0; i < length; i++)
        //    {
        //        temp[i] = random.Next(min,max);
        //    }
        //    return temp;
        //}

        #endregion

        #region 第四章测试用辅助函数

        //static int[] GetRandomNumbers(int min, int max, int length)
        //{
        //    Random random = new Random();
        //    int[] temp = new int[length];
        //    for (int i = 0; i < length; i++)
        //    {
        //        temp[i] = random.Next(min, max);
        //    }
        //    return temp;
        //}

        #endregion

        #region 第五章测试用辅助函数

        //static int[] GetRandomNumbers(int min, int max, int length)
        //{
        //    Random random = new Random();
        //    int[] temp = new int[length];
        //    for (int i = 0; i < length; i++)
        //    {
        //        temp[i] = random.Next(min, max);
        //    }
        //    return temp;
        //}

        #endregion

        #region 第六章测试用辅助函数

        static void DisplayShuzu(int[] data)
        {
            //Console.WriteLine();
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }

            Console.WriteLine();
        }

        #endregion

        #region 循环打印辅助函数

        //static void PrintImage(int row, int col)
        //{
        //    byte[] temp = new byte[1];
        //    string tempString;
            
        //    for (int i = 0; i < row; i++)
        //    {
        //        Console.Write("     ");
        //        for (int j = 0; j < col; j++)
        //        {
        //            temp[0] = (byte)(CalculateNum(i+1, j+1, row, col)%26);
        //            if (temp[0]==0)
        //            {
        //                temp[0] = 26;
        //            }

        //            temp[0] += 64;
        //            Console.Write(ASCIIEncoding.ASCII.GetString(temp) + "    ");
        //        }

        //        Console.WriteLine();
        //        Console.WriteLine();
        //    }
           
        //}

        //public static int CalculateNum(int row, int col, int rowMax, int colMax)
        //{
        //    int cal = 0;
        //    int k = Math.Min(Math.Min(row, colMax - col + 1), Math.Min(rowMax - row + 1, col));
        //    for (int i = 1; i < k; i++)
        //    {
        //        cal += 2 * (colMax - 2 * (i - 1) - 1) + 2 * (rowMax - 2 * (i - 1) - 1);
        //    }

        //    if (k == row)
        //    {
        //        cal += col - (k - 1);
        //    }
        //    else if (k == colMax - col + 1)
        //    {
        //        cal += colMax - 2 * (k - 1) + row - k;
        //    }
        //    else if (k == rowMax - row + 1)
        //    {
        //        cal += 2 * (colMax - 2 * (k - 1) - 1) + rowMax - 2 * (k - 1) - 1 + k - (col - 1);
        //    }
        //    else if (k == col)
        //    {
        //        cal += 2 * (colMax - 2 * (k - 1) - 1) + 2 * (rowMax - 2 * (k - 1) - 1) + k - (row - 1);
        //    }
        //    return cal;
        //}
        #endregion
    }

}
