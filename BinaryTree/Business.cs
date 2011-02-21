using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QueueInheritanceLibrary;

namespace BinaryTree
{
    public class Business
    {
        private Tree tree;
        private QueueInheritance que;

        public Business()
        {
            tree = new Tree();
        }
        public void addNode(IComparable value)
        {
            tree.InsertNode(value);
        }

        public void deleteNode(IComparable value)
        {
            if(tree.delete(value, tree.root))
                Console.WriteLine("worked");
            else
                Console.WriteLine("Didn't work");

            displayTree();
        }

        
        public string displayTree()
        {
            tree.InorderTraversal();
            return "string"; 
           
      
           
           
        }

    }
}
