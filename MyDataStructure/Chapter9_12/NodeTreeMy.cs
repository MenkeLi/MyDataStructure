using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure.Chapter9_12
{
    public class NodeTreeMy<T>
    {
        public T Data { get; set; }
        public NodeTreeMy<T> Left { get; set; }
        public NodeTreeMy<T> Right { get; set; }

        public NodeTreeMy()
        {
            Data = default(T);
            Left = null;
            Right = null;
        }

        public NodeTreeMy(T item)
        {
            Data = item;
            Left = null;
            Right = null;
        }

        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
}
