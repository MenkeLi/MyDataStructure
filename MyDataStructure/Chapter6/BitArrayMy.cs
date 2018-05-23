using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDataStructure.Chapter2;
using MyDataStructure.Chapter3;
using MyDataStructure.Chapter4;
using MyDataStructure.Chapter5;
using MyDataStructure.Chapter6;

namespace MyDataStructure.Chapter6
{
    public class BitArrayMy
    {
        private ListMy<bool> _listMyBit;

        public int Count
        {
            get { return _listMyBit.Count; }
        }

        public BitArrayMy()
        {
            _listMyBit = new ListMy<bool>();
        }

        public BitArrayMy(int capacity)
        {
            _listMyBit = new ListMy<bool>(capacity);
        }

        public BitArrayMy(byte[] bytes)
        {
            _listMyBit = new ListMy<bool>(bytes.Count());
            for (int i = 0; i < bytes.Length; i++)
            {
                string tempString = ConverByteToBitsString(bytes[i]);
                for (int j = 0; j < tempString.Length; j++)
                {
                    bool tempBool=false;
                    if (tempString.Substring(j,1)=="1")
                    {
                        tempBool = true;
                    }

                    _listMyBit.Add(tempBool);
                }
            }
        }

        public bool Get(int index)
        {
            return _listMyBit[index];
        }
        private string ConverByteToBitsString(byte value)
        {
            string tempString=String.Empty;
            int calMask = 1;
            for (int i = 0; i < 8; i++)
            {
                if ((value&calMask)!=0)
                {
                    tempString += '1';
                }
                else
                {
                    tempString += '0';
                }

                value >>= 1;
            }
            return tempString;
        }

        public void Set(int bit,bool value)
        {
            _listMyBit[bit] = value;
        }

        public void SetAll(bool value)
        {
            for (int i = 0; i < Count; i++)
            {
                Set(i, value);
            }
        }

        public BitArrayMy Clone()
        {
            BitArrayMy temp = new BitArrayMy(Count);
            for (int i = 0; i < Count; i++)
            {
                temp.Set(i, Get(i));
            }
            return temp;
        }

        public void CopyTo(bool[] arrBits)
        {
            for (int i = 0; i < Count; i++)
            {
                arrBits[i] = Get(i);
            }
        }

        public BitArrayMy Or(BitArrayMy bitArrayMy)
        {
            BitArrayMy temp = new BitArrayMy(Count);
            for (int i = 0; i < Count; i++)
            {
                temp.Set(i, Get(i) | bitArrayMy.Get(i));
            }
            return temp;
        }

        public BitArrayMy And(BitArrayMy bitArrayMy)
        {
            BitArrayMy temp = new BitArrayMy(Count);
            for (int i = 0; i < Count; i++)
            {
                temp.Set(i, Get(i) & bitArrayMy.Get(i));
            }
            return temp;
        }

        public BitArrayMy Not( )
        {
            BitArrayMy temp = new BitArrayMy(Count);
            for (int i = 0; i < Count; i++)
            {
                temp.Set(i, !Get(i));
            }
            return temp;
        }
    }
}
