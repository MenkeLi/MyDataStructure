using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDataStructure.Chapter2;

namespace MyDataStructure.Chapter5
{
    public class QueueMy<T>
    {
        protected ListMy<T> _queueData;

        public int Count
        {
            get { return _queueData.Count; }
        }

        public QueueMy()
        {
            _queueData = new ListMy<T>();
        }

        public QueueMy(int capacity)
        {
            _queueData = new ListMy<T>(capacity);
        }

        public void EnQueue(T t)
        {
            _queueData.Add(t);
        }

        public virtual T DeQueue()
        {
            T temp = _queueData[0];
            _queueData.RemoveAt(0);
            return temp;
        }

        public T Peek()
        {
            return _queueData[0];
        }

        public void Clear()
        {
            _queueData.Clear();
        }

        public void CopyTo(T[] items, int index)
        {
            for (int i = 0; i < Count; i++)
            {
                items[i + index] = _queueData[i];
            }
        }

        public T[] ToArray()
        {
            T[] tempItems = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                tempItems[i] = _queueData[i];
            }
            return tempItems;
        }

    }
}
