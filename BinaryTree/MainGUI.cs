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
        public enum FORMATBOX{INT, DOUBLE, STRING};
        public static string FORMAT_EXCEPTION = "Incorrect Format! ";
        
        //constructor, instantiates the business class
        public MainGUI()
        {
            InitializeComponent();
            formatComboBox.SelectedIndex = 0;
            business = new Business(formatComboBox.SelectedIndex);
            
        }

        
        //Opens edit form and displays new dialog after it is closed.
        private void editBtn_Click(object sender, EventArgs e)
        {
            EditBox ed = new EditBox(business, editTextBox.Text, (int)formatComboBox.SelectedIndex );
            ed.ShowDialog();
            display();
        }

        //adds new node
        private void addNodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (formatComboBox.SelectedIndex)
                {
                    case ((int)FORMATBOX.INT):
                        business.AddNode(Convert.ToInt16(addDelTextBox.Text));
                        break;
                    case ((int)FORMATBOX.DOUBLE):
                        business.AddNode(Convert.ToDouble(addDelTextBox.Text));
                        break;
                    case ((int)FORMATBOX.STRING):
                        business.AddNode(Convert.ToString(addDelTextBox.Text));
                        break;
                }

            }
            catch (NotFiniteNumberException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(FORMAT_EXCEPTION + ex.Message);
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
                switch (formatComboBox.SelectedIndex)
                {
                    case ((int)FORMATBOX.INT):
                        business.DeleteNode(Convert.ToInt16(addDelTextBox.Text));
                        break;
                    case ((int)FORMATBOX.DOUBLE):
                        business.DeleteNode(Convert.ToDouble(addDelTextBox.Text));
                        break;
                    case ((int)FORMATBOX.STRING):
                        business.DeleteNode(Convert.ToString(addDelTextBox.Text));
                        break;
                }
                
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
                display();
        }

        private void formatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            business = new Business(formatComboBox.SelectedIndex);
        }
    }
}
