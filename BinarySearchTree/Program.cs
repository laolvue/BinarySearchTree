using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree test = new Tree();
            test.Add(10);
            test.Add(5);
            test.Add(8);
            test.Add(15);
            test.Add(3);
            test.Add(20);
            bool findItem = test.Search(3);
            if (findItem)
            {
                Console.WriteLine("Item Found");
            }
            else
            {
                Console.WriteLine("Item not Found");
            }
            Console.ReadLine();
        }
    }
}
