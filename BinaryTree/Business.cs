// By: Erik Hanchett
// Date:2/28/2011
// Assignment: #3
// Exercise 26.8

//This class is the main Business class. It interacts with the tree class and GUI. 
// I also added in code for generics. 
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

            if (val == (int)MainGUI.FORMATBOX.INT)
                treeInt.InsertNode(value);
            else if (val == (int)MainGUI.FORMATBOX.DOUBLE)
                treeDouble.InsertNode(value);
            else
                treeString.InsertNode(value);
            
        }

        
        
        //deletes node
        public void DeleteNode(IComparable value)
        {
            if (val == (int)MainGUI.FORMATBOX.INT)
                treeInt.delete(value,treeInt.root);
            else if (val == (int)MainGUI.FORMATBOX.DOUBLE)
                treeDouble.delete(value, treeDouble.root);
            else
                treeString.delete(value,treeString.root);
            
               

            displayTree();
        }

        //edits nodes
        public void EditNode(IComparable dst, IComparable src)
        {
            if (val == (int)MainGUI.FORMATBOX.INT)
                treeInt.editNode(dst, src);
            else if (val == (int)MainGUI.FORMATBOX.DOUBLE)
                treeDouble.editNode(dst, src);
            else
                treeString.editNode(dst, src);
            
            
                
        }

        //shows in order traversal
        public string displayTree()
        {

            if (val == (int)MainGUI.FORMATBOX.INT)
                return treeInt.levelOrderTraversal();
            else if (val == (int)MainGUI.FORMATBOX.DOUBLE)
                return treeDouble.levelOrderTraversal();
            else
                return treeString.levelOrderTraversal();
            
           
      
           
           
        }

    }
}
