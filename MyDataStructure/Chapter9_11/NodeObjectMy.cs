using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure.Chapter9_11
{
    public class NodeObjectMy
    {
        public Object Element { get; set; }

        public NodeObjectMy Link { get; set; }

        public NodeObjectMy()
        {
            Element = null;
            Link = null;
        }

        public NodeObjectMy(Object element)
        {
            Element = element;
            Link = null;
        }
    }

    public class LinkedListObjectMy
    {
        private NodeObjectMy _header;

        public LinkedListObjectMy()
        {
            _header = new NodeObjectMy("header");
        }

        private NodeObjectMy Find(object item)
        {
            NodeObjectMy currentNodeObject = _header;
            while (currentNodeObject != null && currentNodeObject.Element != item)
            {
                currentNodeObject = currentNodeObject.Link;
            }
            return currentNodeObject;
        }

        public void Insert(object item, object after)
        {
            NodeObjectMy newNodeObject = new NodeObjectMy(item);
            NodeObjectMy currentNodeObject = Find(after);

            newNodeObject.Link = currentNodeObject.Link;
            currentNodeObject.Link = newNodeObject;
        }

        private NodeObjectMy FindPreviousNode(object item)
        {
            NodeObjectMy currentNodeObject = _header;
            while (currentNodeObject.Link != null && currentNodeObject.Link.Element != item)
            {
                currentNodeObject = currentNodeObject.Link;
            }
            return currentNodeObject;
        }
        public void Remove(object item)
        {
            NodeObjectMy currentNodeObject = FindPreviousNode(item);
            if (currentNodeObject.Link != null)
            {
                currentNodeObject.Link = currentNodeObject.Link.Link;
            }
        }

        public void PrintLinkedList()
        {
            NodeObjectMy currentNodeObject = _header;
            while (currentNodeObject.Link != null)
            {
                Console.WriteLine(currentNodeObject.Link.Element);
                currentNodeObject = currentNodeObject.Link;
            }
        }
    }



}