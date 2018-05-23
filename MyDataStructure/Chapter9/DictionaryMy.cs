using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDataStructure.Chapter2;

namespace MyDataStructure.Chapter9
{
    public class DictionaryMy<TKey, TValue>
    {
        private ListMy<TKey> _listMyKeys;
        private ListMy<TValue> _listMyValues;

        public int Count
        {
            get { return _listMyKeys.Count; }
        }

        public ListMy<TKey> Keys
        {
            get { return _listMyKeys; }
        }

        public ListMy<TValue> Values
        {
            get { return _listMyValues; }
        }

        public DictionaryMy()
        {
            _listMyKeys = new ListMy<TKey>();
            _listMyValues = new ListMy<TValue>();
        }

        public DictionaryMy(string textFile)
        {
            string line;
            string[] words;
            StreamReader streamReader = new StreamReader(textFile);
            while (streamReader.Peek()!=-1)
            {
                line = streamReader.ReadLine();
                words = line.Split(',');
                Add((TKey)(object)words[0], (TValue)(object)words[1]);
            }
        }


        public void Add(TKey key, TValue value)
        {
            _listMyKeys.Add(key);
            _listMyValues.Add(value);
        }

        //public TValue Item(TKey key)
        //{
        //    int index = _listMyKeys.IndexOf(key);
        //    return _listMyValues[index];
        //}

        public void Remove(TKey key)
        {
            int index = _listMyKeys.IndexOf(key);
            _listMyKeys.RemoveAt(index);
            _listMyValues.RemoveAt(index);
        }

        public void CopyTo(DictionaryEntry[] dictionaryEntries,int startIndex)
        {
            for (int i = 0; i < Count; i++)
            {
                dictionaryEntries[i+startIndex].Key = _listMyKeys[i];
                dictionaryEntries[i + startIndex].Value = _listMyValues[i];
            }
        }

        public TKey GetKey(TValue value)
        {
            return _listMyKeys[_listMyValues.IndexOf(value)];
        }

        public bool ContainsKey(TKey key)
        {
            if (_listMyKeys.Count==0)
            {
                return false;
            }
            return _listMyKeys.Contains(key);
        }

        public bool ContainsValue(TValue value)
        {
            if (_listMyValues.Count==0)
            {
                return false;
            }
            return _listMyValues.Contains(value);
        }

        public TValue this[TKey key]
        {
            //实现索引器的get方法
            get
            {
                if (key!=null)
                {
                    return _listMyValues[_listMyKeys.IndexOf(key)];
                }
                return default(TValue);
            }

            //实现索引器的set方法
            set { _listMyValues[_listMyKeys.IndexOf(key)] = value; }
        }
    }

    public class  SortedListMy<TKey,TValue>
    {
        private ListMy<TKey> _listMyKeys;
        private ListMy<TValue> _listMyValues;

        public int Count
        {
            get { return _listMyKeys.Count; }
        }

        public SortedListMy()
        {
            _listMyKeys = new ListMy<TKey>();
            _listMyValues = new ListMy<TValue>();
        }

        public void Add(TKey key,TValue value)
        {
            int lowIndex = 0;
            int upperIndex = Count;
            int middleIndex = (lowIndex + upperIndex) / 2;
            while (lowIndex<upperIndex)
            {
                
                if (String.CompareOrdinal(key.ToString(),_listMyKeys[middleIndex].ToString())>0)
                {
                    lowIndex = middleIndex + 1;
                }
                else
                {
                    upperIndex = middleIndex;
                }
                middleIndex = (lowIndex + upperIndex) / 2;
            }

            _listMyKeys.Insert(middleIndex, key);
            _listMyValues.Insert(middleIndex, value);
        }



        public TKey GetKey(TValue value)
        {
            return _listMyKeys[_listMyValues.IndexOf(value)];
        }

        public TKey GetKey(int index)
        {
            return _listMyKeys[index];
        }

        public TValue this[TKey key]
        {
            //实现索引器的get方法
            get { return _listMyValues[_listMyKeys.IndexOf(key)]; }

            //实现索引器的set方法
            set { _listMyValues[_listMyKeys.IndexOf(key)] = value; }
        }

    }
}
