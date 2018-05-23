using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure.Chapter9_12
{
    public class BinarySearchTreeMy
    {
        public NodeTreeMy<int> Root { get; set; }

        public BinarySearchTreeMy()
        {
            Root = null;
        }

        public BinarySearchTreeMy(int root)
        {
            Root = new NodeTreeMy<int>(root);
        }
        public void Insert(int item)
        {
            NodeTreeMy<int> newNode = new NodeTreeMy<int>(item);
            if (Root==null)
            {
                Root = newNode;
            }
            else
            {
                NodeTreeMy<int> currentNode = Root;
                while (true)
                {
                    if (item < currentNode.Data)
                    {
                        if (currentNode.Left == null)
                        {
                            currentNode.Left = newNode;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.Left;
                        }
                    }
                    else
                    {
                        if (currentNode.Right==null)
                        {
                            currentNode.Right = newNode;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.Right;
                        }
                    }
                }
            }
        }

        public void InOrder()
        {
            InOrder(Root);
        }

        public void PreOrder()
        {
            PreOrder(Root);
        }

        public void PostOrder()
        {
            PostOrder(Root);
        }

        private void InOrder(NodeTreeMy<int> root)
        {
            if (root!=null)
            {
                InOrder(root.Left);
                root.DisplayNode();
                InOrder(root.Right);
            }
        }

        private void PreOrder(NodeTreeMy<int> root)
        {
            if (root != null)
            {
                root.DisplayNode();
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
        }

        private void PostOrder(NodeTreeMy<int> root)
        {
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                root.DisplayNode();
            }
        }

        public int FindMin()
        {
            if (Root==null)
            {
                return default(int);
            }
            NodeTreeMy<int> currentNode = Root;
            while (currentNode.Left != null)
            {
                currentNode = currentNode.Left;
            }
            return currentNode.Data;
        }

        public int FindMax()
        {
            if (Root == null)
            {
                return default(int);
            }
            NodeTreeMy<int> currentNode = Root;
            while (currentNode.Right != null)
            {
                currentNode = currentNode.Right;
            }
            return currentNode.Data;
        }

        public NodeTreeMy<int> Find(int key)
        {
            NodeTreeMy<int> currentNode = Root;
            while (currentNode!=null)
            {
                if (key==currentNode.Data)
                {
                    break;
                }
                else if (key<currentNode.Data)
                {
                    currentNode = currentNode.Left;
                }
                else
                {
                    currentNode = currentNode.Right;
                }
            }

            return currentNode;
        }

        public bool Contained(int key)
        {
            if (Find(key)!=null)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int key)
        {
            if (Root==null)
            {
                return false;
            }
            NodeTreeMy<int> parentNode = Root;
            NodeTreeMy<int> currentNode = Root;
            bool IsLeftNode = true;
            while (currentNode!=null)
            {
                if (key == currentNode.Data)
                {
                    if (currentNode.Left==null&&currentNode.Right==null)
                    {
                        if (currentNode==Root)
                        {
                            Root = null;
                        }
                        if (IsLeftNode)
                        {
                            parentNode.Left = null;
                        }
                        else
                        {
                            parentNode.Right = null;
                        }
                    }
                    else if (currentNode.Left == null)
                    {
                        if (currentNode==Root)
                        {
                            Root = currentNode.Right;
                        }
                        else
                        {
                            if (IsLeftNode)
                            {
                                parentNode.Left = currentNode.Right;
                            }
                            else
                            {
                                parentNode.Right = currentNode.Right;
                            }
                        }

                        currentNode.Right = null;
                    }
                    else if (currentNode.Right==null)
                    {
                        if (currentNode == Root)
                        {
                            Root = currentNode.Left;
                        }
                        if (IsLeftNode)
                        {
                            parentNode.Left = currentNode.Left;
                        }
                        else
                        {
                            parentNode.Right = currentNode.Left;
                        }
                        currentNode.Left = null;
                    }
                    else
                    {
                        if (currentNode == Root)
                        {
                            Root = currentNode.Left;
                        }
                        if (IsLeftNode)
                        {
                            parentNode.Left = currentNode.Left;
                        }
                        else
                        {
                            parentNode.Right = currentNode.Left;
                        }
                        NodeTreeMy<int> tempNode = currentNode.Left;
                        while (tempNode.Right!=null)
                        {
                            tempNode = tempNode.Right;
                        }
                        tempNode.Right = currentNode.Right;
                        currentNode.Left = null;
                        currentNode.Right = null;
                    }
                    return true;
                }
                else if (key < currentNode.Data)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.Left;
                    IsLeftNode = true;
                }
                else
                {
                    parentNode = currentNode;
                    currentNode = currentNode.Right;
                    IsLeftNode = false;
                }
            }
            return false;
        }
    }
}
