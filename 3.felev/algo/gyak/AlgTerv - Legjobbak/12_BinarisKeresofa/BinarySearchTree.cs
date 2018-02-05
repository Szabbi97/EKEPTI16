using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_BinarisKeresofa
{
    class BinarySearchTree<T>
    {
        public Node<T> root;
        public void Insert(int Id, T Data)
        {
            Node<T> node = new Node<T>();
            node.Id = Id;
            node.Data = Data;

            if (root == null)
            {
                root = node;
            }
            else
            {
                Node<T> parent;
                Node<T> current = root;
                while (true)
                {
                    parent = current;
                    if (node.Id < current.Id)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = node;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = node;
                            break;
                        }
                    }
                }
            }
        }
        public void Inorder(Node<T> Start)
        {
            if (Start != null)
            {
                Inorder(Start.Left);
                Start.Display();
                Inorder(Start.Right);
            }
        }
        public void Preorder(Node<T> Start)
        {
            if (Start != null)
            {
                Preorder(Start.Left);
                Preorder(Start.Right);
                Start.Display();
            }
        }
        public void Postorder(Node<T> Start)
        {
            if (Start != null)
            {
                Start.Display();
                Postorder(Start.Left);
                Postorder(Start.Right);
            }
        }
    }
}
