using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEquitable_Interface_Example
{
    public partial class Form1 : Form
    {
        List<Box> boxList = new List<Box>();
        public Form1()
        {
            InitializeComponent();
            PopulateBoxList();
            DisplayBoxList();
        }
        private void PopulateBoxList()
        {
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                int L = rand.Next(2, 10);
                int W = rand.Next(1, L);
                int H = rand.Next(W, L);
                Box box = new Box(L, W, H);
                boxList.Add(box);
            }            
        }
        private void DisplayBoxList()
        {
            richTextBox1.Clear();
            foreach (Box box in boxList)
            {
                richTextBox1.AppendText(box + "\n");
            }
        }

        private void btnSearchEqualBoxes_Click(object sender, EventArgs e)
        {
            //get box dimensions
            int L = int.Parse(txtLenght.Text);
            int W = int.Parse(txtWidth.Text);
            int H = int.Parse(txtHeight.Text);
            Box box1 = new Box(L, W, H);
            //display all the boxes that are equal (volume wise) to this box
            richTextBox1.Text = "Boxes that are equal to current box: \n";
            foreach (Box other in boxList)
            {
                if (box1.Equals(other))
                    richTextBox1.AppendText(other + "\n");
            }
        }
    }
}
///Exercise
///Define a class Account with accountNumber and balance 
///Inherit the Equality interface
///Create a list of interface
///two accountus are equal if they have the same account number and balance
///Create s list of accounts
///Search the list for a given account, indicate if such account exists
///in the list or not.
