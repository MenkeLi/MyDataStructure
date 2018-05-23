using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure.Chapter2
{
    public class ArrayListMy
    {
        private ArrayList _arrayList = new ArrayList();
        //private Array array = new Array();

        private object[] _arrayListData = new object[16];


        private int _count = 0;

        public int Count
        {
            get { return _count; }
        }

        //private int _capacity = 16;

        public int Capacity
        {
            get { return _arrayListData.Length; }
        }
        public ArrayListMy()
        {
            //var rr = _arrayList.ToArray()
            //Array.Sort()
        }
        public int Add(object item)
        {
            if (_count + 1 > _arrayListData.Length)
            {
                object[] temp = new object[_arrayListData.Length];
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = _arrayListData[i];
                }

                _arrayListData = new object[_arrayListData.Length * 2];
                //_capacity = _arrayListData.Length;
                for (int i = 0; i < temp.Length; i++)
                {
                    _arrayListData[i] = temp[i];
                }
                _arrayListData[temp.Length] = item;
            }
            else
            {
                _arrayListData[_count] = item;
            }

            _count++;
            return _count - 1;
        }

        public void AddRange(ArrayListMy listData)
        {
            while (_count + listData._count > _arrayListData.Length)
            {
                object[] temp = new object[_arrayListData.Length];
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = _arrayListData[i];
                }

                _arrayListData = new object[_arrayListData.Length * 2];
                //_capacity = _arrayListData.Length;
                for (int i = 0; i < temp.Length; i++)
                {
                    _arrayListData[i] = temp[i];
                }
            }

            for (int i = 0; i < listData._count; i++)
            {
                _arrayListData[_count + i] = listData._arrayListData[i];
            }
            _count += listData.Count;
        }

        public void Clear()
        {
            _arrayListData = new object[16];
            _count = 0;
            //_capacity = 16;
        }

        public bool Contains(object item)
        {
            for (int i = 0; i < _arrayListData.Length; i++)
            {
                if (_arrayListData[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        public object[] CopyTo(int startIndex)
        {
            object[] temp = new object[_count - startIndex];
            for (int i = 0; i < _count - startIndex; i++)
            {
                temp[i] = _arrayListData[startIndex + i];
            }
            return temp;
        }

        public ArrayListMy GetRange(int startIndex, int count)
        {
            ArrayListMy temp = new ArrayListMy();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                temp.Add(_arrayListData[i]);
            }
            return temp;
        }

        public int IndexOf(object item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (item == _arrayListData[i])
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, object item)
        {
            if (_count + 1 > _arrayListData.Length)
            {
                object[] temp = new object[_arrayListData.Length];
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = _arrayListData[i];
                }

                _arrayListData = new object[_arrayListData.Length * 2];
                for (int i = 0; i < temp.Length; i++)
                {
                    _arrayListData[i] = temp[i];
                }
            }

            for (int i = _count; i > index; i--)
            {
                _arrayListData[i] = _arrayListData[i - 1];
            }
            _arrayListData[index] = item;
            _count++;
        }

        /// <summary>
        /// 在自己插入自己的时候，此函数会引发一系列问题
        /// </summary>
        /// <param name="index"></param>
        /// <param name="listData"></param>
        public void InsertRange(int index, ArrayListMy listData)
        {
            while (_count + listData._count > _arrayListData.Length)
            {
                object[] temp = new object[_arrayListData.Length];
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = _arrayListData[i];
                }

                _arrayListData = new object[_arrayListData.Length * 2];
                //_capacity = _arrayListData.Length;
                for (int i = 0; i < temp.Length; i++)
                {
                    _arrayListData[i] = temp[i];
                }
            }

            for (int i = _count-1; i > index-1; i--)
            {
                _arrayListData[i + listData.Count] = _arrayListData[i];
            }

            _count += listData.Count;

            for (int i = 0; i < listData.Count; i++)
            {
                _arrayListData[index + i] = listData._arrayListData[i];
            }
        }

        public void Remove(object item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_arrayListData[i] == item)
                {
                    for (int j = i; j < _count - 1; j++)
                    {
                        _arrayListData[j] = _arrayListData[j + 1];
                    }

                    _count--;
                    return;
                }
            }
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < _count - 1; i++)
            {
                _arrayListData[i] = _arrayListData[i + 1];
            }

            _count--;
        }

        public void Reverse()
        {
            var temp = _arrayListData;
            for (int i = 0; i < _count; i++)
            {
                _arrayListData[i] = temp[_count - 1 - i];
            }
        }

        public void Sort()
        {

        }

        public object[] ToArray()
        {
            object[] temp = new object[_count];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _arrayListData[i];
            }
            return temp;
        }

        public void TrimToSize()
        {
            var temp = _arrayListData;
            _arrayListData = new object[_count];
            for (int i = 0; i < _count; i++)
            {
                _arrayListData[i] = temp[i];
            }

        }
    }
}
