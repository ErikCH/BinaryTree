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
        private Tree tree;
        
        //constructor
        public Business()
        {
            tree = new Tree();
        }
        //add node
        public void addNode(IComparable value)
        {
            tree.InsertNode(value);
        }

        //deletes node
        public void deleteNode(IComparable value)
        {
            tree.delete(value, tree.root);
               

            displayTree();
        }

        //edits nodes
        public void editNode(IComparable dst, IComparable src)
        {
            tree.editNode(dst, src);
                
        }

        //shows in order traversal
        public string displayTree()
        {

           

            return tree.levelOrderTraversal();
           
      
           
           
        }

    }
}
