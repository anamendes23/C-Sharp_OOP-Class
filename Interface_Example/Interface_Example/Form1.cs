using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Example
{
    public partial class Form1 : Form
    {
        List<IAge> things = new List<IAge>();
        public Form1()
        {
            InitializeComponent();
            PopulateList();
        }
        private void PopulateList()
        {
            Person p1 = new Person("David", new DateTime(1973, 2, 3));
            things.Add(p1);
            Tree t1 = new Tree("Maple", new DateTime(1990, 4, 20));
            things.Add(t1);
            Car c1 = new Car("Mazda", new DateTime(2010, 02, 11));
            things.Add(c1);
        }
        private void BtnDisplayAll_Click(object sender, EventArgs e)
        {
            foreach (IAge obj in things)
            {
                richTextBox1.AppendText(
                                        obj.ToString() + "\t" +
                                        obj.GetAge() + " years old" + "\n");
            }
        }
    }
}
///Exercise
//Define an interface ILocation with a method GetLocation
//Define a class Person that implements the ILocation. Have it
//return the full address of the person
//Define a class Tree that implements the ILocation. Have it 
//return the location where the tree is planted (Tacoma,WA)
//Define a class Car that implements the ILocation. Have it 
//return the plant name and location

//in Form1 create a list of 6 objects or more (2 of each)
//Dislay all
