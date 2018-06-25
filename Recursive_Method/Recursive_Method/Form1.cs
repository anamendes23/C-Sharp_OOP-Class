/* Ana Mendes
 * anamendes23@gmail.com
 * github.com/anamendes23
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursive_Method
{
    public partial class Form1 : Form
    {
        /* a recursive method is a method that calls itself
         * 
         * */
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExample1_Click(object sender, EventArgs e)
        {
            int counter = 10;
            //CountDown(counter);
            CountUp(1, 20);
        }

        //this method should display counter values from the
        //initial values down to 1
        private void CountDown(int counter)
        {
            //option 1: use a loop
            //while(counter >= 1)
            //{
            //    //display counter
            //    listBox1.Items.Add($"counter = {counter}");
            //    counter--;
            //}

            //option 2: use recursion
            //base condition to end recursive calls
            if (counter < 1)
                return; //exit this method---> stop recursive calls
            //display counter
            listBox1.Items.Add($"counter = {counter}");
            //make a recursive call making sure that you are
            //converging towards the base condition
            CountDown(/*--counter*/ counter-1);
        }
        //define a second recursive method that counts up from
        //1 to a certain value (that is passed to it)
        private void CountUp(int counter, int topValue)
        {
            if (counter > topValue)
                return;
            //display counter
            listBox1.Items.Add($"counter (up) = {counter}");
            //make a recursive call
            CountUp(counter + 1, topValue);
        }

        private void BtnExample2_Click(object sender, EventArgs e)
        {
            //DisplayStarsHorizontally(10);
            StarCountDown(10);
        }
        //define a recursive method that calls the DisplayStarsHorizontally
        //so that multiple lines of stars are displayed where each next line
        //has one less star, until you reach a single star in one line
        private void StarCountDown(int n)
        {
            //define base condition to stop recursion
            if (n < 1)
                return;
            //call display stars horizontally
            DisplayStarsHorizontally(n);
            //make a recursive call
            StarCountDown(n - 1);
        }

        //given a method to display n stars in a single line
        private void DisplayStarsHorizontally(int n)
        {
            //display n stars on a single line in a richtextbox
            //richTextBox1.Clear();

            for (int i = 1; i <= n; i++)
                richTextBox1.AppendText("*");
            richTextBox1.AppendText("\n");
        }

        //define a graphics object
        Random rand = new Random();
        Graphics g;

        private void BtnExample3_Click(object sender, EventArgs e)
        {
            //create graphics
            g = panel1.CreateGraphics();

            //setup the initial radius to be the max possible given panel size
            // set radius = half of the shortest width and height
            int r = Math.Min(panel1.Width, panel1.Height);
            int xc = panel1.Width / 2;
            int yc = panel1.Height / 2;

            DrawConcentricCircles(r, xc, yc);
            //call the recursive method
            //DrawConcentricCircles(radius, xc, yc);
        }
        //define a method "drawCircle" that draws a circle with center set 
        //in the middle of the panel
        //(this method should have a single parameter radius)
        public void DrawCircle(int r, int xc, int yc)
        {
            Color color = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
            Pen p = new Pen(color, 2);

            int x = xc - r / 2;
            int y = yc - r / 2;

            g.DrawEllipse(p, x, y, r, r);

            //Rectangle rectangle = new Rectangle(0, 0, panel1.Width, panel1.Height);
            //Pen pen = new Pen(Color.Red, 2);

            //image.DrawEllipse(pen, rectangle);
        }
        //define a recursive method that calls the drawCircle to draw
        //another circle with smaller radius. Continue to process until
        //the smallest circle is about 5 pixels radius
        private void DrawConcentricCircles(int r, int xc, int yc)
        {
            g = panel1.CreateGraphics();

            //base condition
            if (r <= 5)
                return;
            //call DrawCircle
            DrawCircle(r, xc, yc);
            //make recursive
            DrawConcentricCircles(r - 1, xc, yc);
        }
    }
}

