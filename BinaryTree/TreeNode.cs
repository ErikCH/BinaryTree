// Fig. 26.23: BinaryTreeLibrary.cs
// Declaration of class TreeNode and class Tree.
using System;

namespace BinaryTree
{
    // class TreeNode declaration
    public class TreeNode
    {
        // automatic property LeftNode
        public TreeNode LeftNode { get; set; }

        // automatic property Data
        public IComparable Data { get; set; }

        // automatic property RightNode
        public TreeNode RightNode { get; set; }

        // initialize Data and make this a leaf node
        public TreeNode(IComparable nodeData)
        {
            Data = nodeData;
            LeftNode = RightNode = null; // node has no children
        } // end constructor

        
        
        // insert TreeNode into Tree that contains nodes;
        // ignore duplicate values
        public void Insert(IComparable insertValue)
        {
            if (insertValue.CompareTo(Data) < 0) // insert in left subtree
            {
                // insert new TreeNode
                if (LeftNode == null)
                    LeftNode = new TreeNode(insertValue);
                else // continue traversing left subtree
                    LeftNode.Insert(insertValue);
            } // end if
            else if (insertValue.CompareTo(Data) > 0) // insert in right
            {
                // insert new TreeNode
                if (RightNode == null)
                    RightNode = new TreeNode(insertValue);
                else // continue traversing right subtree
                    RightNode.Insert(insertValue);
            } // end else if
        } // end method Insert
    } // end class TreeNode

}