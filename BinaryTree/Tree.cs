// By: Erik Hanchett
// Date:2/21/2011
// Assignment: #2
// Exercise 26.8

//This class came from the book as well. It has been modified to add in new methods for level order traversal, findparent, edit and delete.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QueueInheritanceLibrary;

namespace BinaryTree
{
    // class Tree declaration
    public class Tree<T>
    {
        public TreeNode<T> root;
        public QueueInheritance<T> que;
        public const string LEVEL_ORDER_TEXT = "Level Order Traversal\n";
        public const string DNE = "Does not exist!";
        public const string ROOT_TEXT = "Root: ";
        public const string LEV_TEXT = "Level ";

        // construct an empty Tree of integers
        public Tree()
        {
            root = null;
        } // end constructor

        // Insert a new node in the binary search tree.
        // If the root node is null, create the root node here.
        // Otherwise, call the insert method of class TreeNode.
        public void InsertNode(IComparable insertValue)
        {
            if (root == null)
                root = new TreeNode<T>(insertValue);
            else
                root.Insert(insertValue);
        } // end method InsertNode

        //finds value and deletes it, uses recursion
        public bool delete(IComparable nodeData, TreeNode<T> current)
        {

            if (current == null)
            {
                throw new NullReferenceException(DNE);
                
            }

            if (nodeData.CompareTo(current.Data) == 0) // on correct node to delete
            {
                TreeNode<T> parent = findParent(nodeData);
                //both children are null
                if (current.LeftNode == null && current.RightNode == null)
                {

                    if (parent == null)
                    {
                        root = null;
                        current = null;

                    }
                    else if (parent.LeftNode == current)
                        parent.LeftNode = null;
                    else
                        parent.RightNode = null;
                    current = null;

                    return true;
                }// end if

                // left node is null, right node is not null
                else if (current.LeftNode == null && current.RightNode != null)
                {
                    if (parent != null)
                    {
                        if (parent.LeftNode == current)
                            parent.LeftNode = current.RightNode;
                        else
                            parent.RightNode = current.RightNode;
                    }
                    else
                        root = root.RightNode;

                    current = null;
                }

                //left node is not null, right node is null
                else if (current.LeftNode != null && current.RightNode == null)
                {
                    if (parent != null)
                    {
                        if (parent.LeftNode == current)
                            parent.LeftNode = current.LeftNode;
                        else
                            parent.RightNode = current.LeftNode;
                    }
                    else
                        root = root.LeftNode;
                }
                //left and right nodes are not null
                else if (current.LeftNode != null && current.RightNode != null)
                {
                    TreeNode<T> temp = current.RightNode;
                    if (temp.LeftNode == null && temp.RightNode == null)
                    {
                        temp.LeftNode = current.LeftNode;
                        if (parent != null)
                        {
                            if (parent.LeftNode == current)
                                parent.LeftNode = temp;
                            else
                                parent.RightNode = temp;
                        }
                        else
                        {
                            temp.LeftNode = root.LeftNode;
                            root = temp;
                        }

                    }
                    else  //right has children locate small element
                    {
                        if (current.RightNode.LeftNode != null)
                        {
                            TreeNode<T> rightNodes;
                            TreeNode<T> leftNodes;
                            leftNodes = current.RightNode;
                            rightNodes = current.RightNode.LeftNode;
                            while (rightNodes.LeftNode != null)
                            {
                                leftNodes = rightNodes;
                                rightNodes = rightNodes.LeftNode;
                            }
                            current.Data = rightNodes.Data;
                            rightNodes = null;
                            leftNodes.LeftNode = null;

                        }
                        else
                        {
                            TreeNode<T> tmp;
                            tmp = current.RightNode;
                            current.Data = tmp.Data;
                            current.RightNode = tmp.RightNode;
                            tmp = null;
                        }
                    }
                }
                return true;
            }

                //else we need to traverse tree
            else if (nodeData.CompareTo(current.Data) < 0)
            {
                return delete(nodeData, current.LeftNode);

            }
            else if (nodeData.CompareTo(current.Data) > 0)
            {
                return delete(nodeData, current.RightNode);

            }
            else
                throw new NullReferenceException(DNE);
                

        }

        //finds Parent of current node
        public TreeNode<T> findParent(IComparable value)
        {
            TreeNode<T> node = root;
            TreeNode<T> last = null;
            while (node != null && node.Data.CompareTo(value) != 0)
            {
                last = node;
                if (value.CompareTo(node.Data) < 0)
                    node = node.LeftNode;
                else
                    node = node.RightNode;
            }
            return last;
        }

        //Edits node, same as deleting and adding.
        public bool editNode(IComparable dst, IComparable src)
        {
            bool result = delete(dst, root);
            if (result)
                InsertNode(src);

            return result;
        }

        //Level order traversal
        public string levelOrderTraversal()
        {
            int level = 0;
            TreeNode<T> temp;
            string result = LEVEL_ORDER_TEXT;
            
            if (root != null)
            {
                que = new QueueInheritance<T>(LEVEL_ORDER_TEXT);
                que.Enqueue(root);
                result += ROOT_TEXT + root.Data;
                TreeNode<T> lastParent = root;
                while (!que.IsEmpty())
                {
                    
                    temp = (TreeNode<T>)que.Dequeue();
                    if (lastParent == findParentLevel(level, temp))
                    {
                        if (level != 0)
                            result += temp.Data.ToString() + " ";
                    }
                    else
                    {
                        level++;
                        result += "\n" + LEV_TEXT + "(" + level + "): " + temp.Data.ToString() + " ";

                    }

                    if (temp.LeftNode != null)
                        que.Enqueue(temp.LeftNode);
                    if (temp.RightNode != null)
                        que.Enqueue(temp.RightNode);

                    lastParent = findParentLevel(level, temp);
                }

            }
            return result;
        }

        public TreeNode<T> findParentLevel(int level, TreeNode<T> temp)
        {
            TreeNode<T> tree = temp; 
            for (int i = 0; i < level; i++)
                tree = findParent(tree.Data);

            return tree;
        }

        // begin preorder traversal
        public void PreorderTraversal()
        {
            PreorderHelper(root);
        } // end method PreorderTraversal

        // recursive method to perform preorder traversal
        private void PreorderHelper(TreeNode<T> node)
        {
            if (node != null)
            {
                // output node Data
                Console.Write(node.Data + " ");

                // traverse left subtree
                PreorderHelper(node.LeftNode);

                // traverse right subtree
                PreorderHelper(node.RightNode);
            } // end if
        } // end method PreorderHelper

        // begin inorder traversal
        public void InorderTraversal()
        {
                 InorderHelper(root);
        } // end method InorderTraversal

        // recursive method to perform inorder traversal
        private void InorderHelper(TreeNode<T> node)
        {
            
            if (node != null)
            {
                // traverse left subtree
                InorderHelper(node.LeftNode);

                // output node data
              
                Console.Write(node.Data + " ");
                

                // traverse right subtree
                InorderHelper(node.RightNode);
            } // end if
            Console.Write("\n");

        } // end method InorderHelper

        // begin postorder traversal
        public void PostorderTraversal()
        {
            PostorderHelper(root);
        } // end method PostorderTraversal

        
        // recursive method to perform postorder traversal
        private void PostorderHelper(TreeNode<T> node)
        {
            if (node != null)
            {
                // traverse left subtree
                PostorderHelper(node.LeftNode);

                // traverse right subtree
                PostorderHelper(node.RightNode);

                // output node Data
                Console.Write(node.Data + " ");
            } // end if
        } // end method PostorderHelper
    } // end class Tree
}

/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/

