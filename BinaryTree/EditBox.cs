// By: Erik Hanchett
// Date:2/28/2011
// Assignment: #3
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
        private string firstValue;
        private Business business;
        private int box;
        //constructor passed in first value and business class
        public EditBox(Business business, string val, int box)
        {
            InitializeComponent();
            firstValue = val;
            this.business = business;
            this.box = box;
        }

        //this calls the editNode method for business and closes the window.
        private void addEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                switch (box)
                {
                    case ((int)MainGUI.FORMATBOX.INT):
                        business.EditNode(Convert.ToInt32(firstValue), Convert.ToInt32(edit2TextBox.Text));
                        break;
                    case ((int)MainGUI.FORMATBOX.DOUBLE):
                        business.EditNode(Convert.ToDouble(firstValue), Convert.ToDouble(edit2TextBox.Text));
                        break;
                    case ((int)MainGUI.FORMATBOX.STRING):
                        business.EditNode(firstValue, edit2TextBox.Text);
                        break;
                }



            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (NotFiniteNumberException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (FormatException ex)
            {
                MessageBox.Show(MainGUI.FORMAT_EXCEPTION + ex.Message);
            }
            finally
            {
                this.Close();    
            }
                
        }
    }
}
