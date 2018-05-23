using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure.Chapter9_11
{
    public class NodeBiDirectionMy<T>
    {
        public T Element { get; set; }
        public NodeBiDirectionMy<T> BLink { get; set; }
        public NodeBiDirectionMy<T> FLink { get; set; }

        public NodeBiDirectionMy()
        {
            Element = default(T);
            BLink = null;
            FLink = null;
        }

        public NodeBiDirectionMy(T element)
        {
            Element = element;
            BLink = null;
            FLink = null;
        }
    }

    public class LinkedListBiDirectionMy<T>
    {
        private NodeBiDirectionMy<T> _header;
        

        public LinkedListBiDirectionMy()
        {
            _header = new NodeBiDirectionMy<T>();
        }

        public LinkedListBiDirectionMy(T header)
        {
            _header = new NodeBiDirectionMy<T>(header);
        }

        private NodeBiDirectionMy<T> Find(T elememt)
        {
            NodeBiDirectionMy<T> currentNodeBiDirection = _header;
            while (currentNodeBiDirection != null && !currentNodeBiDirection.Element.Equals(elememt))
            {
                currentNodeBiDirection = currentNodeBiDirection.FLink;
            }
            return currentNodeBiDirection;
        }

        public void Insertion(T newElement, T after)
        {
            NodeBiDirectionMy<T> newNodeBiDirection = new NodeBiDirectionMy<T>(newElement);
            NodeBiDirectionMy<T> currentNodeBiDirection = Find(after);
            if (currentNodeBiDirection != null)
            {
                if (currentNodeBiDirection.FLink != null)
                {
                    currentNodeBiDirection.FLink.BLink = newNodeBiDirection;
                    newNodeBiDirection.FLink = currentNodeBiDirection.FLink;
                    newNodeBiDirection.BLink = currentNodeBiDirection;
                    currentNodeBiDirection.FLink = newNodeBiDirection;
                }
                else
                {
                    newNodeBiDirection.FLink = null;
                    newNodeBiDirection.BLink = currentNodeBiDirection;
                    currentNodeBiDirection.FLink = newNodeBiDirection;
                }
            }
        }
        public void Remove(T element)
        {
            NodeBiDirectionMy<T> currentNodeBiDirection = Find(element);
            if (currentNodeBiDirection != null)
            {
                if (currentNodeBiDirection.FLink != null)
                {
                    currentNodeBiDirection.FLink.BLink = currentNodeBiDirection.BLink;
                    currentNodeBiDirection.BLink.FLink = currentNodeBiDirection.FLink;
                }
                else
                {
                    currentNodeBiDirection.BLink.FLink = null;
                }
            }
        }

        public void PrintLinkedList()
        {
            NodeBiDirectionMy<T> currentNodeBiDirection = _header;
            while (currentNodeBiDirection.FLink != null)
            {
                Console.WriteLine(currentNodeBiDirection.FLink.Element);
                currentNodeBiDirection = currentNodeBiDirection.FLink;
            }
        }

        private NodeBiDirectionMy<T> FindLastNode()
        {
            NodeBiDirectionMy<T> currentNodeBiDirection = _header;
            while (currentNodeBiDirection.FLink != null)
            {
                currentNodeBiDirection = currentNodeBiDirection.FLink;
            }
            return currentNodeBiDirection;
        }

        public void PrintReverse()
        {
            NodeBiDirectionMy<T> currentNodeBiDirection = FindLastNode();
            while (currentNodeBiDirection.BLink != null)
            {
                Console.WriteLine(currentNodeBiDirection.Element);
                currentNodeBiDirection = currentNodeBiDirection.BLink;
            }
        }

        public NodeBiDirectionMy<T> GetFirst()
        {
            return _header;
        }
    }

    public class LinkedListCircularMy<T>
    {
        private NodeBiDirectionMy<T> _header;

        public LinkedListCircularMy()
        {
            _header = new NodeBiDirectionMy<T>();
        }

        public LinkedListCircularMy(T header)
        {
            _header = new NodeBiDirectionMy<T>(header);
            _header.FLink = _header;
        }

        public bool IsEmpty()
        {
            return _header.FLink == null;
        }

        public void MakeEmpty()
        {
            _header.FLink = null;
        }
    }
}
