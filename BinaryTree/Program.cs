// By: Erik Hanchett
// Date:2/28/2011
// Assignment: #3
// Exercise 26.8

//Entry point to MainGUI program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BinaryTree
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainGUI());
        }
    }
}
