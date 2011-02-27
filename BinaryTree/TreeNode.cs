// By: Erik Hanchett
// Date:2/21/2011
// Assignment: #2
// Exercise 26.8

//This class came from the book, it stores the tree node data structure.
// Fig. 26.23: BinaryTreeLibrary.cs
// Declaration of class TreeNode and class Tree.
using System;

namespace BinaryTree
{
    // class TreeNode declaration
    
    public class TreeNode<T>:IComparable<TreeNode<T>>
    {
        // automatic property LeftNode
        public TreeNode<T> LeftNode { get; set; }

        // automatic property Data
        public IComparable Data { get; set; }

        // automatic property RightNode
        public TreeNode<T> RightNode { get; set; }

        private const string NUMBER_ERROR ="Number already exists! Please choose again!";
        // initialize Data and make this a leaf node
        public TreeNode(IComparable nodeData)
        {
            Data = nodeData;
            LeftNode = RightNode = null; // node has no children
        } // end constructor

        public int CompareTo(TreeNode<T> t)
        {
            return (this.Data.CompareTo(t.Data));
        }
        
        // insert TreeNode into Tree that contains nodes;
        // ignore duplicate values
        public void Insert(IComparable insertValue)
        {
            if (insertValue.CompareTo(Data) < 0) // insert in left subtree
            {
                // insert new TreeNode
                if (LeftNode == null)
                    LeftNode = new TreeNode<T>(insertValue);
                else // continue traversing left subtree
                    LeftNode.Insert(insertValue);
            } // end if
            else if (insertValue.CompareTo(Data) > 0) // insert in right
            {
                // insert new TreeNode
                if (RightNode == null)
                    RightNode = new TreeNode<T>(insertValue);
                else // continue traversing right subtree
                    RightNode.Insert(insertValue);
            } // end else if
            else
                throw new NotFiniteNumberException(NUMBER_ERROR);
        } // end method Insert
    } // end class TreeNode

}