using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircularShapesLib;

namespace IntroToInheritance
{
    public partial class Form1 : Form
    {
        /*Inheritance
         * ===============
         * Deals with a class inheriting another class
         * Another term for inheriting is extending (Java uses
         * the therm extending)
         * 
         * if a class A inherits (or extends) class B, then 
         * name class B as the base class or the parent class and
         * class A as the derived class or the child class
         * 
         * Inheritance results in a child-parent relationship
         * 
         * A Parent class can have multiple child classes
         * but a child can have only one parent class
         * 
         * A class has:
         *      private fields, constructor, properties, methods
         * A child class would inherit:
         *      private fields: but has no direct access to them
         *      properties: has access to them because they are public
         *      methods: has access to the public methods
         * A child class DOES NOT inherit the constructor
         * *****There is a DESTRUCTOR, but we never use in C#. It is used in C++
         * *****C# has "Manage Code" -> the system automatically delets what is
         * *****not necessary. Garbage collector class
         * -> DLL classes
         * */
        public Form1()
        {
            InitializeComponent();
            //to use the classes on the CircularShapeLib projet:
            //1- windows app: add a reference to DLL
            //2- using ...
            //now Circle class can be accessed by Form1
            Circle circle = new Circle(20.5d);
        }
        //*****************************EVENTS************************************
        private void btnCreateCircle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();
            //create a Circle
            Circle circle = new Circle(radius);
            //display
            Display(circle);
        }
        private void btnCreateCylinder_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();
            double height = rand.Next(3, 30) + rand.NextDouble();
            //create a Cylinder object
            Cylinder cylinder = new Cylinder(radius, height);

            //display it
            //you could and should use the Display(Circle c) method
            //We are calling a Display method that accepts Circle object
            //but we are passing it a Cylinder object
            //this is possible because a Cylinder object "is a" Circle
            //(of type Circle)
            Display(cylinder);
        }
        private void btnCreateSphere_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();
            //create a Circle
            Sphere sphere = new Sphere(radius);
            //display
            Display(sphere);
        }
        private void btnCreateCone_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double radius = rand.Next(2, 20) + rand.NextDouble();
            double height = rand.Next(3, 30) + rand.NextDouble();
            //create a Cylinder object
            Cone cone = new Cone(radius, height);
            //display it
            Display(cone);
        }
        //*****************************METHODS***********************************
        //method to display a Circle object
        private void Display(Circle c)
        {
            ListViewItem lvi = null;
            if (c is Cylinder)
            {
                //cast c to a Cylinder object
                Cylinder cy = (Cylinder)c;
                //create a listviewitem (one row in a listview)
                string[] item = { cy.GetType().Name, cy.Radius.ToString("f3"),
                            cy.Height.ToString("f3"), cy.Perimeter().ToString("f3"),
                            cy.Area().ToString("f3"), cy.Volume().ToString("f3")};
                lvi = new ListViewItem(item);
            }
            else if (c is Sphere)
            {
                //cast c to a Sphere object
                Sphere s = (Sphere)c;
                //create a listviewitem (one row in a listview)
                string[] item = { s.GetType().Name, s.Radius.ToString("f3"),
                            "0.000", s.Perimeter().ToString("f3"),
                            s.Area().ToString("f3"), s.Volume().ToString("f3")};
                lvi = new ListViewItem(item);
            }
            else if (c is Cone)
            {
                //cast c to a Cone object
                Cone cone = (Cone)c;
                //create a listviewitem (one row in a listview)
                string[] item = { cone.GetType().Name, cone.Radius.ToString("f3"),
                            cone.Height.ToString("f3"), cone.Perimeter().ToString("f3"),
                            cone.Area().ToString("f3"), cone.Volume().ToString("f3")};
                lvi = new ListViewItem(item);
            }
            else
            {
                //create a listviewitem (one row in a listview)
                string[] item = { c.GetType().Name, c.Radius.ToString("f3"), "0.000",
                            c.Perimeter().ToString("f3"), c.Area().ToString("f3"),
                            c.Volume().ToString("f3")};
                lvi = new ListViewItem(item);                
            }
            //add the row to listview
            listView1.Items.Add(lvi);
            //cause the listview1 to scroll down automatically
            //by making the last item visible
            listView1.EnsureVisible(listView1.Items.Count - 1);
        }
    }
}
