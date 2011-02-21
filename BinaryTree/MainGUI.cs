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
        
        public MainGUI()
        {
            InitializeComponent();
            business = new Business();
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditBox ed = new EditBox();
            ed.ShowDialog();
        }

        private void addNodeBtn_Click(object sender, EventArgs e)
        {
            business.addNode(addDeleteUpDwn.Value);
            display();
        }

       
        private void display()
        {
            outputRTB.Text = business.displayTree();
        }

        private void deleteNodeBtn_Click(object sender, EventArgs e)
        {
            business.deleteNode(addDeleteUpDwn.Value);
        }
    }
}
