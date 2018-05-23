using System;
using System.Collections;

//在写下某个功能之前，先考虑好在实现这个功能的时候，物理内存中到底发生了什么事，有没有出现内存运用不合理和过多浪费时间的问题。
namespace MyDataStructure.Chapter2
{
    public class ListMy<T>:IEnumerable

    {
        private T[] _listMyData;
        private int _count = 0;
        private int _capacity = 0;

        public int Count
        {
            get { return _count; }
        }

        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if (value == Capacity)
                {
                    return;
                }
                if (value < Count)
                {
                    throw new Exception("设定容量过小");
                }

                T[] tempList1 = new T[value];

                for (int i = 0; i < Count; i++)
                {
                    tempList1[i] = _listMyData[i];
                }


                _listMyData = tempList1;
                _capacity = value;
            }
        }

        public ListMy()
        {
            _listMyData = new T[16];
            _capacity = 16;
        }

        public ListMy(int capacity)
        {
            _listMyData = new T[capacity];
            Capacity = capacity;
            _count = capacity;
        }


        public void ExtendCapacityToMinSecondPower(int length)
        {
            int temp = 2;
            while (length>temp)
            {
                temp = temp * 2;
            }
            Capacity = temp;
            //ExtendCapacity(temp);
        }
        public void Add(T item)
        {
            if (_count+1>_listMyData.Length)
            {
                Capacity = _listMyData.Length * 2;
                //ExtendCapacity(_listMyData.Length * 2);
            }
            _listMyData[_count] = item;
            _count++;
        }

        public void AddRange(ListMy<T> items)
        {
            ExtendCapacityToMinSecondPower(Count+items.Count);
            for (int i = 0; i < items.Count ; i++)
            {
                _listMyData[_count + i] = items[i];
            }
            _count = Count + items.Count;
        }

        public void Insert(int index, T item)
        {
            if (_count + 1 > _listMyData.Length)
            {
                Capacity = _listMyData.Length * 2;
                //ExtendCapacity(_listMyData.Length * 2);
            }
            for (int i = _count - 1; i >= index; i--)
            {
                _listMyData[i + 1] = _listMyData[i];
            }
            _listMyData[index] = item;
            _count++;
        }

        public void InsertRange(int index, ListMy<T> items)
        {
            ExtendCapacityToMinSecondPower(Count+items.Count);
            for (int i = Count-1; i >= index; i--)
            {
                _listMyData[i + items.Count] = _listMyData[i];
            }
            for (int i = 0; i < items.Count; i++)
            {
                _listMyData[i + index] = items[i];
            }
            _count = Count + items.Count;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_listMyData[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_listMyData[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public void RemoveAt(int index)
        {
            for (int i = index; i < _count-1; i++)
            {
                _listMyData[i] = _listMyData[i + 1];
            }
            _count--;
        }

        public void Remove(T item)
        {
            int temp = IndexOf(item);
            if (temp!=-1)
            {
                RemoveAt(temp);
            }
        }

        public void Clear()
        {
            _listMyData = new T[_listMyData.Length];
            //_count = 0;
        }

        public ListMy<T> GetRange(int index)
        {
            ListMy<T> tempList = new ListMy<T>(Count);
            for (int i = 0; i < Count; i++)
            {
                tempList[i] = _listMyData[i];
            }
            return tempList;
        }

        public void Reverse()
        {
            ListMy<T> tempList = new ListMy<T>();
            
        }

        public T[] ToArray()
        {
            T[] temp = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                temp[i] = this[i];
            }
            return temp;
        }
        public T this[int index]
        {
            //实现索引器的get方法
            get
            {
                if (index<0)
                {
                    return default(T);
                }
                return _listMyData[index];
            }

            //实现索引器的set方法
            set { _listMyData[index] = value; }
        }

        //public IEnumerator GetEnumerator()
        //{

        //}

       
        public IEnumerator GetEnumerator()
        {
            int current = 0;
            while (_listMyData[current] != null)
            {
                yield return _listMyData[current];
                current++;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

    //public class EnumMy <T> : IEnumerator
    //{
    //    private T[] _listDataMy;
    //    private int position = -1;

    //    public EnumMy(T[] listData)
    //    {
    //        _listDataMy = new T[listData.Length];
    //        for (int i = 0; i < listData.Length; i++)
    //        {
    //            _listDataMy[i] = listData[i];
    //        }
    //    }

    //    public bool MoveNext()
    //    {
    //        position++;
    //        if (position<_listDataMy.Length&&_listDataMy[position]!=null)
    //        {
    //            return true;
    //        }
    //        return false;
    //        //return (position < _listDataMy.Length);
    //    }

    //    public void Reset()
    //    {
    //        position = -1;
    //    }

    //    public object Current
    //    {
    //        get { return _listDataMy[position]; }
    //    }
    //}
}
