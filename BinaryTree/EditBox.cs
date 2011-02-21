// By: Erik Hanchett
// Date:2/21/2011
// Assignment: #2
// Exercise 26.8

//This class handles the editing of a value. It interacts with the business class. 
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
    public partial class EditBox : Form
    {
        //fields
        private decimal firstValue;
        private Business business;
        //constructor passed in first value and business class
        public EditBox(Business business, decimal val)
        {
            InitializeComponent();
            firstValue = val;
            this.business = business;
        }

        //this calls the editNode method for business and closes the window.
        private void addEditBtn_Click(object sender, EventArgs e)
        {
            try
            {

                business.editNode(firstValue, editSecondUpDwnBx.Value);
                
               
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            catch (NotFiniteNumberException ex)
            {
                MessageBox.Show(ex.Message);
                    
            }
            finally
            {
                this.Close();    
            }
                
        }
    }
}
