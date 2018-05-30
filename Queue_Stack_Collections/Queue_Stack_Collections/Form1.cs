/* Ana Mendes
 * anamendes23@gmail.com
 * github.com/anamendes23s
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_Stack_Collections
{
    public partial class Form1 : Form
    {
        Queue<int> queue1 = new Queue<int>(50);

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEnqueueValue_Click(object sender, EventArgs e)
        {
            //add value from textbox
            try
            {
                int value = int.Parse(txtAddValue.Text);
                //use Enqueue method to add to the back of the queue
                queue1.Enqueue(value);
                //display to see the outcome
                Display(queue1);
                //optional
                txtAddValue.Focus();
                txtAddValue.SelectAll();
            }
            catch(FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void BtnEnqueueRandomValue_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(-999, 1000);
            queue1.Enqueue(x);
            Display(queue1);
        }

        private void BtnDequeue_Click(object sender, EventArgs e)
        {
            //use the Dequeue method, which removes and returns the
            //first object in line
            int x = queue1.Dequeue();
            //display the removed value
            MessageBox.Show($"Item dequeued: {x}");
            //display queue1
            Display(queue1);
        }
        //helper methods
        private void Display(Queue<int> queue)
        {
            //display in listbox1
            listBox1.Items.Clear();
            foreach (int x in queue)
            {
                listBox1.Items.Add(x);
                //scroll down
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }                
        }
    }
}
///Exercise
///1. add button to use the Peek method
///2. create a second queue: queue2 and provide button to
///     enqueue and dequeue queue2
///3. add button to merge both queues into a single queue: queue3
///     prefer that you define a method 'SimpleMerge' that takes
///     two queues as parameter and return a merged queue
///     then from the button call this method and display the new queue
///4. write a method 'RemoveOdds' that take a queue and removes
///     only the odd values while maintaining the rest in their
///     original sequence
///     have a button that calls this method and display the queue again
