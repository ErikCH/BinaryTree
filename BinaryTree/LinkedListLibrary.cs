// By: Erik Hanchett
// Date:2/21/2011
// Assignment: #2
// Exercise 26.8

// This class came from the book, it hasn't been touched and is used to create lists.
// Fig. 26.4: LinkedListLibrary.cs
// ListNode, List and EmptyListException class declarations.
using System;
using BinaryTree;

namespace LinkedListLibrary
{
   // class to represent one node in a list
   class ListNode
   {
      // automatic read-only property Data
      public object Data { get; private set; }

      // automatic property Next
      public ListNode Next { get; set; }

      // constructor to create ListNode that refers to dataValue
      // and is last node in list
      public ListNode( Object dataValue )
         : this( dataValue, null )
      {
      } // end default constructor

      // constructor to create ListNode that refers to dataValue
      // and refers to next ListNode in List
      public ListNode( Object dataValue, ListNode nextNode )
      {
         Data = dataValue;
         Next = nextNode;
      } // end constructor
   } // end class ListNode

   // class List declaration
   public class List
   {
      private ListNode firstNode;
      private ListNode lastNode;
      private string name; // string like "list" to display
      private const string EMPTY_LIST = "Empty List";

      // construct empty List with specified name
      public List( string listName )
      {
         name = listName;
         firstNode = lastNode = null;
      } // end constructor

      // construct empty List with "list" as its name
      public List()
         : this( "base")
      {
      } // end default constructor

      // Insert object at front of List. If List is empty, 
      // firstNode and lastNode will refer to same object.
      // Otherwise, firstNode refers to new node.
      public void InsertAtFront( Object insertItem )
      {
         if ( IsEmpty() )
            firstNode = lastNode = new ListNode( insertItem );
         else
            firstNode = new ListNode( insertItem, firstNode );
      } // end method InsertAtFront

      // Insert object at end of List. If List is empty, 
      // firstNode and lastNode will refer to same object.
      // Otherwise, lastNode's Next property refers to new node.
      public void InsertAtBack( Object insertItem )
      {
         if ( IsEmpty() )
            firstNode = lastNode = new ListNode( insertItem );
         else
            lastNode = lastNode.Next = new ListNode( insertItem );
      } // end method InsertAtBack

      // remove first node from List
      public object RemoveFromFront()
      {
         if ( IsEmpty() )
            throw new EmptyListException( EMPTY_LIST );

         object removeItem = firstNode.Data; // retrieve data

         // reset firstNode and lastNode references
         if ( firstNode == lastNode )
            firstNode = lastNode = null;
         else
            firstNode = firstNode.Next;

         return removeItem; // return removed data
      } // end method RemoveFromFront

      // remove last node from List
      public object RemoveFromBack()
      {
         if ( IsEmpty() )
            throw new EmptyListException(EMPTY_LIST );

         object removeItem = lastNode.Data; // retrieve data

         // reset firstNode and lastNode references
         if ( firstNode == lastNode )
            firstNode = lastNode = null;
         else
         {
            ListNode current = firstNode;

            // loop while current node is not lastNode
            while ( current.Next != lastNode )
               current = current.Next; // move to next node

            // current is new lastNode
            lastNode = current;
            current.Next = null;
         } // end else

         return removeItem; // return removed data
      } // end method RemoveFromBack

      // return true if List is empty
      public bool IsEmpty()
      {
         return firstNode == null;
      } // end method IsEmpty

      // output List contents
      public void Display()
      {
         if ( IsEmpty() )
         {
            Console.WriteLine( "Empty " + name );
         } // end if
         else
         {
            Console.Write( "The " + name + " is: " );

            ListNode current = firstNode;

            // output current node data while not at end of list
            while ( current != null )
            {
               Console.Write( current.Data + " " );
               current = current.Next;
            } // end while

            Console.WriteLine( "\n" );
         } // end else
      } // end method Display
   } // end class List

   // class EmptyListException declaration
   public class EmptyListException : Exception
   {
      // parameterless constructor
      public EmptyListException()
         : base( "The list is empty" )
      {
         // empty constructor
      } // end EmptyListException constructor

      // one-parameter constructor
      public EmptyListException( string name )
         : base( "The " + name + " is empty" )
      {
         // empty constructor
      } // end EmptyListException constructor

      // two-parameter constructor
      public EmptyListException( string exception, Exception inner )
         : base( exception, inner )
      {
         // empty constructor
      } // end EmptyListException constructor
   } // end class EmptyListException
} // end namespace LinkedListLibrary

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
