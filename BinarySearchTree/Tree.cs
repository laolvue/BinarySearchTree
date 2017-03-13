using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Tree
    {
        public Node top;

        public Tree()
        {
            top = null;
        }
        public Tree(int input)
        {
            top = new Node (input);
        }

        
        public void Add(int input)
        {
            if (top == null)
            {
                top = new Node(input);
                return;
            }
            bool added = false;
            Node currentNode = top;
            do
            {
                if(input >= currentNode.value)
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = new Node(input);
                        added = true;
                    }
                    else
                        currentNode = currentNode.right;
                }
                if (input < currentNode.value)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = new Node(input);
                        added = true;
                    }
                    else
                        currentNode = currentNode.left;
                }
            } while (!added);
        }

        public bool Search(int input)
        {
            Node currentNode = top;
            while(currentNode != null)
            {
                if(input == currentNode.value)
                {
                    return (true);
                }
                if (input > currentNode.value)
                {
                    if (currentNode.right == null)
                    {
                        break;
                    }
                    else
                        currentNode = currentNode.right;
                }
                if (input < currentNode.value)
                {
                    if (currentNode.left == null)
                    {
                        break;
                    }
                    else
                        currentNode = currentNode.left;
                }
            }

            return (false);
        }
    }
}
