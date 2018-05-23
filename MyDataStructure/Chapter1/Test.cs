using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyDataStructure.Chapter1
{
    public class StudentsTest
    {
        private Collection _submittedTests;
        private Collection _outForChecking;
        
        public StudentsTest()
        {
            _submittedTests = new Collection();
            _outForChecking = new Collection();
            
        }

        public void Add(TestMy item)
        {
            _submittedTests.Add(item);
            
        }

        public void Check(string name)
        {          
            foreach (TestMy test in _submittedTests)
            {
                if (test.Name==name)
                {
                    _submittedTests.Remove(test);
                    _outForChecking.Add(test);
                }
            }
        }

        public void GetOut()
        {
            foreach (TestMy test in _outForChecking)
            {
                _submittedTests.Add(test);
                _outForChecking.Remove(test);
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class TestMy
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }
    /// <summary>
    /// 作业1.2
    /// </summary>
    public class Collection : CollectionBase
    {
        public void Add(object item)
        {
            InnerList.Add(item);
        }

        public void Remove(object item)
        {
            InnerList.Remove(item);
        }

        public void Clear()
        {
            InnerList.Clear();
        }

        public int Count()
        {
            return InnerList.Count;
        }

        public void Insert(int index, object item)
        {
            InnerList.Insert(index,item);
        }

        public bool Contains(object item)
        {
            return InnerList.Contains(item);
        }

        public int IndexOf(object item)
        {
            return InnerList.IndexOf(item);
        }

        public void RemoveAt(int index)
        {
            InnerList.RemoveAt(index);
        }
    }

    /// <summary>
    /// 作业1.3
    /// </summary>
    public class Zuoye13

    {
        private Timing _time = new Timing();

        public double TimeCollection()
        {
           Collection collection = new Collection();
            _time.StartTime();
            for (int i = 0; i < 1000000; i++)
            {
                collection.Add(i);
            }

            _time.StopTime();
            return _time.Result().TotalSeconds;
        }

        public double TimeArrarList()
        {
            ArrayList arrayList = new ArrayList();
            _time.Reset();
            _time.StartTime();
            for (int i = 0; i < 1000000; i++)
            {
                arrayList.Add(i);
            }

            _time.StopTime();
            return _time.Result().TotalSeconds;
        }
    }

    #region 作业1.4 通过List实现泛型Collection类
    /// <summary>
    /// 自己构建的泛型Collextion类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CollectionMy<T>
    {
        private List<T> _items;

        public CollectionMy()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public int Count()
        {
            return _items.Count;
        }

        public void Insert(int index, T item)
        {
            _items.Insert(index, item);
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public int IndexOf(T item)
        {
            return _items.IndexOf(item);
        }

        public void RemoveAt(int index)
        {
            _items.RemoveAt(index);
        }
    }
    #endregion

}
