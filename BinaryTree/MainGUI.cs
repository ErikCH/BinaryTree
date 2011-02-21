// By: Erik Hanchett
// Date:2/21/2011
// Assignment: #2
// Exercise 26.8

//This is the mani GUI class. It displays the output for the tree and interacts with the business class.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BinaryTree
{
    public partial class MainGUI : Form
    {
        //fields
        private Business business;
        
        //constructor, instantiates the business class
        public MainGUI()
        {
            InitializeComponent();
            business = new Business();
        }

        
        //Opens edit form and displays new dialog after it is closed.
        private void editBtn_Click(object sender, EventArgs e)
        {
            EditBox ed = new EditBox(business, editFirstUpDownBx.Value);
            ed.ShowDialog();
            display();
        }

        //adds new node
        private void addNodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                business.addNode(addDeleteUpDwn.Value);
            }
            catch (NotFiniteNumberException ex)
            {
                MessageBox.Show(ex.Message);
            }
            display();
        }

       //Displays nodes
        private void display()
        {
            outputRTB.Text = business.displayTree();
        }

        //deletes nodes
        private void deleteNodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                business.deleteNode(addDeleteUpDwn.Value);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
                display();
        }
    }
}
