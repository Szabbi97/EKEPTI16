using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_BinarisKeresofa
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Insert(40, 40);
            bst.Insert(110, 110);
            bst.Insert(80, 80);
            bst.Insert(70, 70);
            bst.Insert(50, 50);
            bst.Insert(10, 10);
            bst.Insert(30, 30);
            bst.Insert(20, 20);
            bst.Insert(90, 90);
            bst.Insert(100, 100);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inorder");
            bst.Inorder(bst.root);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPreorder");
            bst.Preorder(bst.root);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPostorder");
            bst.Postorder(bst.root);
            Console.ReadLine();
        }
    }
}
