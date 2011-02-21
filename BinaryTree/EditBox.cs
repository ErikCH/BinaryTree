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
        public EditBox()
        {
            InitializeComponent();
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
