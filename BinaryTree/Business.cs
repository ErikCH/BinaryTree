// By: Erik Hanchett
// Date:2/21/2011
// Assignment: #2
// Exercise 26.8

//This class is the main Business class. It interacts with the tree class and GUI. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QueueInheritanceLibrary;

namespace BinaryTree
{
    public class Business
    {
        //fields
        private Tree<int> treeInt;
        private Tree<double> treeDouble;
        private Tree<string> treeString;
        int val;
        //constructor
        public Business(int val)
        {
            this.val = val;
            if (val == (int)MainGUI.FORMATBOX.INT)
                treeInt = new Tree<int>();
            else if (val == (int)MainGUI.FORMATBOX.DOUBLE)
                treeDouble = new Tree<double>();
            else
                treeString = new Tree<string>();
        }
        //add node
        public void AddNode(IComparable value)
        {

            FindTree().InsertNode(value);
        }

        private Tree<T> FindTree()
        {
            if (val == (int)MainGUI.FORMATBOX.INT)
                return treeInt;
            else if (val == (int)MainGUI.FORMATBOX.DOUBLE)
                return treeDouble;
            else
                return treeString;
            
        }
        //deletes node
        public void DeleteNode(IComparable value)
        {
            FindTree().delete(value, tree.root);
               

            displayTree();
        }

        //edits nodes
        public void EditNode(IComparable dst, IComparable src)
        {
            FindTree().editNode(dst, src);
                
        }

        //shows in order traversal
        public string displayTree()
        {

           

            return FindTree().levelOrderTraversal();
           
      
           
           
        }

    }
}
