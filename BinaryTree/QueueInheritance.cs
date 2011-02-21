// By: Erik Hanchett
// Date:2/21/2011
// Assignment: #2
// Exercise 26.8

// This class was from the book. It stores the methods dealing with manipulating a Queue.
// Fig. 26.16: QueueInheritanceLibrary.cs
// Implementing a queue by inheriting from class List.
using LinkedListLibrary;
using BinaryTree;

namespace QueueInheritanceLibrary
{
   // class QueueInheritance inherits List's capabilities
   public class QueueInheritance : List
   {
      // pass name "queue" to List constructor
      public QueueInheritance(string obj)
         : base( obj )
      {
      } // end constructor

      // place dataValue at end of queue by inserting 
      // dataValue at end of linked list
      public void Enqueue( TreeNode dataValue )
      {
         InsertAtBack( dataValue );
      } // end method Enqueue

      // remove item from front of queue by removing
      // item at front of linked list
      public object Dequeue()
      {
         return RemoveFromFront();
      } // end method Dequeue
   } // end class QueueInheritance
} // end namespace QueueInheritanceLibrary

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