using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDataStructure.Chapter2;

namespace MyDataStructure.Chapter5
{
    public class StackMy<T>
    {
        private ListMy<T> _stackData;
        public int Count
        {
            get { return _stackData.Count; }
        }
        public StackMy()
        {
            Stack<int> test = new Stack<int>();
            
            _stackData = new ListMy<T>();
        }

        public void Push(T item)
        {
            _stackData.Add(item);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("此栈目前为空，无法执行出栈操作");
            }

            T temp = _stackData[_stackData.Count - 1];
            _stackData.RemoveAt(_stackData.Count - 1);
            return temp;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("此栈目前为空，无法执行取数操作");
            }

            return _stackData[_stackData.Count - 1];
        }

        public bool Contains(T item)
        {
            return _stackData.Contains(item);
        }

        public void Clear()
        {
            _stackData.Clear();
        }
        private bool IsEmpty()
        {
            if (_stackData.Count==0)
            {
                return true;
            }
            return false;
        }

        public void CopyTo(T[] items, int index)
        {
            for (int i = 0; i < Count; i++)
            {
                items[i + index] = _stackData[Count - 1 - i];
            }
        }

        public T[] ToArray()
        {
            T[] tempItems = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                tempItems[i] = _stackData[Count - 1 - i];
            }
            return tempItems;
        }
    }
}
