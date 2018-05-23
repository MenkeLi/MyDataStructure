using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure.Chapter5
{
    public class PriorityQueue<T>:QueueMy<T>
    {
        
        public override T DeQueue()
        {
            int minPriority = int.MaxValue;
            int minIndex=int.MaxValue;

            for (int i = 0; i < Count; i++)
            {
                int temp = ((ProcessMy) ((object) _queueData[i])).Priority;//此处的类型转换应该如何处理？？？？？？
                if (temp< minPriority)
                {
                    minPriority = temp;
                    minIndex = i;
                }
            }

            T tempData= _queueData[minIndex];
            _queueData.RemoveAt(minIndex);
            return tempData;
        }
    }

    public struct ProcessMy
    {
        public int Priority;
        public string Name;

       
    }
}
