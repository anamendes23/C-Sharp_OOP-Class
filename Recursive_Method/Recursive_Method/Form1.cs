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
            //make a recursive call
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
    }
}
///Exercise

