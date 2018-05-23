using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure.Chapter9_16
{
    public class GraphMy<T>
    {
        public int NumVertex { get; set; }
        protected VertexMy<T>[] _vertexMys;
        private bool[,] _adjMatrix;

        public  GraphMy(int num)
        {
            NumVertex = 0;
            _vertexMys = new VertexMy<T>[num];
            _adjMatrix = new bool[num, num];
        }

        public GraphMy()
        {
            NumVertex = 0;
            _vertexMys = new VertexMy<T>[4];
            _adjMatrix = new bool[4, 4];
        }

        public virtual void AddVertex(T item)
        {
            //如果个数超过了数组界限，那么对数组进行扩容
            if (NumVertex==_vertexMys.Length)
            {
                bool[,] temp = new bool[NumVertex+1, NumVertex+1];
                for (int i = 0; i < NumVertex; i++)
                {
                    for (int j = 0; j < NumVertex; j++)
                    {
                        temp[i, j] = _adjMatrix[i, j];
                    }
                }
                _adjMatrix = temp;

                VertexMy<T>[] tempVer = new VertexMy<T>[NumVertex+1];
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

        public virtual void AddEdge(int start, int end)
        {
            _adjMatrix[start, end] = true;
        }

        /// <summary>
        /// 目前还存在问题。当我对一个顶点进行删除后，被删除的那个顶点之前的顶点，有可能变成没有后序顶点的顶点。如何处理这种新产生的顶点与之前的顶点的关系
        /// </summary>
        public virtual void TopSort()
        {
            Stack<T> tempStack = new Stack<T>();
            while (NumVertex>0)
            {
                int temp = NoSuccessors();
                tempStack.Push(_vertexMys[temp].Label);
                DeletVertex(temp);
            }

            Console.WriteLine("这个图结构的拓扑排序结果为：");
            while (tempStack.Count>0)
            {
                Console.Write(" "+tempStack.Pop());
            }
        }
        /// <summary>
        /// 删除第几个顶点，从0开始进行计数
        /// </summary>
        /// <param name="vertex"></param>
        private void DeletVertex(int vertex)
        {
            if (vertex!=NumVertex-1)
            {
                //更新边的矩阵
                for (int i = vertex; i < NumVertex-1; i++)
                {
                    for (int j = 0; j < vertex; j++)
                    {
                        _adjMatrix[i, j] = _adjMatrix[i + 1, j];
                    }
                }

                for (int j = vertex; j < NumVertex-1; j++)
                {
                    for (int i = 0; i < vertex; i++)
                    {
                        _adjMatrix[i, j] = _adjMatrix[i, j + 1];
                    }
                }

                for (int i = vertex; i < NumVertex-1; i++)
                {
                    for (int j = vertex; j < NumVertex-1; j++)
                    {
                        _adjMatrix[i, j] = _adjMatrix[i + 1, j + 1];
                    }
                }

                //更新顶点数组
                for (int i = vertex; i < NumVertex-1; i++)
                {
                    _vertexMys[i] = _vertexMys[i + 1];
                }
            }

            //更新最后一行，最后一列，以及数组的最后一个状态
            for (int i = 0; i < NumVertex; i++)
            {
                _adjMatrix[NumVertex - 1, i] = false;
                _adjMatrix[i, NumVertex - 1] = false;
            }
            _vertexMys[NumVertex - 1] = null;

            //更新顶点现在的个数
            NumVertex--;
        }
        /// <summary>
        /// 找出第几个顶点没有后续顶点
        /// </summary>
        /// <returns></returns>
        private int NoSuccessors()
        {
            bool isEdge;
            for (int i = 0; i < NumVertex; i++)
            {
                isEdge = false;
                for (int j = 0; j < NumVertex; j++)
                {
                    if (_adjMatrix[i,j])
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

        public virtual void DepthFirstSearch()
        {
            Stack<int> vertexNum = new Stack<int>();
            int currentNum = 0;

            _vertexMys[currentNum].IsVisited = true;
            ShowVertex(currentNum);
            vertexNum.Push(currentNum);
            
            while (vertexNum.Count>0)
            {
                currentNum = IsHaveUnvisitedAdjVertex(vertexNum.Peek());
                if (currentNum!=-1)
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

        public virtual void WidthFirstSearch()
        {
            Queue<int> vertexNum = new Queue<int>();
            int currentNum = 0;
            ShowVertex(currentNum);
            vertexNum.Enqueue(currentNum);

            while (vertexNum.Count>0)
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

        private  int IsHaveUnvisitedAdjVertex(int ver)
        {
            for (int i = 0; i < NumVertex; i++)
            {
                if (_adjMatrix[ver,i]&&!_vertexMys[i].IsVisited)
                {
                    return i;
                }
            }
            return -1;
        }
        protected void ShowVertex(int index)
        {
            Console.Write(_vertexMys[index].Label + " ");
        }
    }

    public class VertexMy<T>
    {
        public T Label { get; set; }
        public bool IsVisited { get; set; }

        public VertexMy<T> Parent { get; set; }

        public bool IsInTree { get; set; }
        public VertexMy(T label)
        {
            Label = label;
            IsVisited = false;
            Parent = null;
            IsInTree = false;
        }
    }
}
