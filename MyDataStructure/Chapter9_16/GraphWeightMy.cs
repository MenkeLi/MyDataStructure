using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDataStructure.Chapter9_16
{
    public class GraphWeightMy<T> : GraphMy<T>
    {
        private int[,] _adjMatrix;

        public GraphWeightMy(int num) : base(num)
        {
            NumVertex = 0;
            _vertexMys = new VertexMy<T>[num];
            _adjMatrix = new int[num, num];
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i==j)
                    {
                        _adjMatrix[i, j] = 0;
                    }
                    else
                    {
                        _adjMatrix[i, j] = int.MaxValue;
                    }
                    
                }
            }
        }

        //public GraphWeightMy()
        //{
           
        //}

        public override void AddVertex(T item)
        {
            //如果个数超过了数组界限，那么对数组进行扩容
            if (NumVertex == _vertexMys.Length)
            {
                int[,] temp = new int[NumVertex + 1, NumVertex + 1];
                for (int i = 0; i < NumVertex; i++)
                {
                    for (int j = 0; j < NumVertex; j++)
                    {
                        temp[i, j] = _adjMatrix[i, j];
                    }
                }

                _adjMatrix = temp;

                VertexMy<T>[] tempVer = new VertexMy<T>[NumVertex + 1];
                for (int i = 0; i < NumVertex; i++)
                {
                    tempVer[i] = _vertexMys[i];
                }

                _vertexMys = tempVer;
            }

            //将最新的顶点加入进来，同时更新现在的顶点个数
            _vertexMys[NumVertex] = new VertexMy<T>(item);
            NumVertex++;
        }

        public void AddEdge(int start, int end, int weight)
        {
            _adjMatrix[start, end] = weight;
        }

        public override void TopSort()
        {
            Stack<T> tempStack = new Stack<T>();
            while (NumVertex > 0)
            {
                int temp = NoSuccessors();
                tempStack.Push(_vertexMys[temp].Label);
                DeletVertex(temp);
            }

            Console.WriteLine("这个图结构的拓扑排序结果为：");
            while (tempStack.Count > 0)
            {
                Console.Write(" " + tempStack.Pop());
            }
        }

        public override void DepthFirstSearch()
        {
            Stack<int> vertexNum = new Stack<int>();
            int currentNum = 0;

            _vertexMys[currentNum].IsVisited = true;
            ShowVertex(currentNum);
            vertexNum.Push(currentNum);

            while (vertexNum.Count > 0)
            {
                currentNum = IsHaveUnvisitedAdjVertex(vertexNum.Peek());
                if (currentNum != -1)
                {
                    _vertexMys[currentNum].IsVisited = true;
                    ShowVertex(currentNum);
                    vertexNum.Push(currentNum);
                }
                else
                {
                    vertexNum.Pop();
                }
            }

            for (int i = 0; i < NumVertex; i++)
            {
                _vertexMys[i].IsVisited = false;
            }
        }

        public override void WidthFirstSearch()
        {
            Queue<int> vertexNum = new Queue<int>();
            int currentNum = 0;
            ShowVertex(currentNum);
            vertexNum.Enqueue(currentNum);

            while (vertexNum.Count > 0)
            {
                currentNum = IsHaveUnvisitedAdjVertex(vertexNum.Peek());
                if (currentNum != -1)
                {
                    _vertexMys[currentNum].IsVisited = true;
                    ShowVertex(currentNum);
                    vertexNum.Enqueue(currentNum);
                }
                else
                {
                    vertexNum.Dequeue();
                }
            }

            for (int i = 0; i < NumVertex; i++)
            {
                _vertexMys[i].IsVisited = false;
            }
        }

        private int IsHaveUnvisitedAdjVertex(int ver)
        {
            for (int i = 0; i < NumVertex; i++)
            {
                if (_adjMatrix[ver, i] < int.MaxValue && !_vertexMys[i].IsVisited)
                {
                    return i;
                }
            }

            return -1;
        }

        private void DeletVertex(int vertex)
        {
            if (vertex != NumVertex - 1)
            {
                //更新边的矩阵
                for (int i = vertex; i < NumVertex - 1; i++)
                {
                    for (int j = 0; j < vertex; j++)
                    {
                        _adjMatrix[i, j] = _adjMatrix[i + 1, j];
                    }
                }

                for (int j = vertex; j < NumVertex - 1; j++)
                {
                    for (int i = 0; i < vertex; i++)
                    {
                        _adjMatrix[i, j] = _adjMatrix[i, j + 1];
                    }
                }

                for (int i = vertex; i < NumVertex - 1; i++)
                {
                    for (int j = vertex; j < NumVertex - 1; j++)
                    {
                        _adjMatrix[i, j] = _adjMatrix[i + 1, j + 1];
                    }
                }

                //更新顶点数组
                for (int i = vertex; i < NumVertex - 1; i++)
                {
                    _vertexMys[i] = _vertexMys[i + 1];
                }
            }

            //更新最后一行，最后一列，以及数组的最后一个状态
            for (int i = 0; i < NumVertex; i++)
            {
                _adjMatrix[NumVertex - 1, i] = int.MaxValue;
                _adjMatrix[i, NumVertex - 1] = int.MaxValue;
            }

            _vertexMys[NumVertex - 1] = null;

            //更新顶点现在的个数
            NumVertex--;
        }

        private int NoSuccessors()
        {
            bool isEdge;
            for (int i = 0; i < NumVertex; i++)
            {
                isEdge = false;
                for (int j = 0; j < NumVertex; j++)
                {
                    if (_adjMatrix[i, j] < int.MaxValue)
                    {
                        isEdge = true;
                        break;
                    }
                }

                if (!isEdge)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Dijkltra最短路径
        /// </summary>
        /// <param name="startIndex"></param>
        public void DijkltraPath(int startIndex)
        {

            if (startIndex >= NumVertex)
            {
                Console.WriteLine("输入了错误的顶点号!!!");
                return;
            }

            int[] distanceMatrix = new int[NumVertex];
            for (int i = 0; i < NumVertex; i++)
            {
                distanceMatrix[i] = int.MaxValue;
            }

            distanceMatrix[startIndex] = 0;

            CalulateDistanceVertex(startIndex, distanceMatrix);
            for (int i = 0; i < NumVertex-1; i++)
            {
                CalulateDistanceVertex(GetMinIndex(distanceMatrix), distanceMatrix);
            }

            DisplayPath(startIndex, distanceMatrix);

            for (int i = 0; i < NumVertex; i++)
            {
                _vertexMys[i].Parent = null; 
            }
        }

        private void CalulateDistanceVertex(int startIndex,int[] distanceMatrix)
        {
            ////计算出目前数组中的最小值的索引值（除去已经确定了最短路径的顶点）
            //int startIndex = 0;
            //for (int i = 0; i < NumVertex; i++)
            //{
            //    if (!_vertexMys[i].IsInTree && distanceMatrix[startIndex] > distanceMatrix[i])
            //    {
            //        startIndex = i;
            //    }
            //}
            //_vertexMys[startIndex].IsInTree = true;

            //刷新距离矩阵
            for (int j = 0; j < NumVertex; j++)
            {
                if (!_vertexMys[j].IsInTree)
                {
                    int temp = _adjMatrix[startIndex, j];
                    if (temp<int.MaxValue)
                    {
                        temp += distanceMatrix[startIndex];
                        if (temp<distanceMatrix[j])
                        {
                            distanceMatrix[j] = temp;
                            _vertexMys[j].Parent = _vertexMys[startIndex];
                        }
                    }
                }
            }
        }

        private int GetMinIndex(int[] distanceMatrix)
        {
            int temp = 0;

            for (int i = 0; i < NumVertex; i++)
            {
                if (!_vertexMys[i].IsInTree)
                {
                    temp = i;
                    break;
                }
            }

            for (int i = temp; i < NumVertex; i++)
            {
                if (!_vertexMys[i].IsInTree && distanceMatrix[temp] > distanceMatrix[i])
                {
                    temp = i;
                }
            }
            _vertexMys[temp].IsInTree = true;
            return temp;
        }

        private void DisplayPath(int startIndex,int[] distanceMatrix)
        {
            for (int i = 0; i < NumVertex; i++)
            {
                Console.Write("从顶点{0}到达顶点{1}的最短路径是：", _vertexMys[startIndex].Label,_vertexMys[i].Label);
                if (distanceMatrix[i]==int.MaxValue)
                {
                    Console.WriteLine("无法到达");
                }
                else
                {
                    VertexMy<T> temp = _vertexMys[i];
                    Console.Write(_vertexMys[startIndex].Label);
                    string tempString = null;
                    while (temp.Parent!=null)
                    {
                        tempString = "--" + temp.Label + tempString;
                        temp = temp.Parent;
                    }
                    Console.Write(tempString);
                    Console.WriteLine("    最短路径的距离为：{0}", distanceMatrix[i]);
                }
            }
        }

    }
}
