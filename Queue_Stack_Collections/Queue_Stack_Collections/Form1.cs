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
        //----------------------------GLOBALS---------------------------
        Queue<int> queue1 = new Queue<int>(50);
        Queue<int> queue2 = new Queue<int>(50);
        Queue<int> queue3 = new Queue<int>(100);

        Stack<int> stack1 = new Stack<int>(50);

        public Form1()
        {
            InitializeComponent();
        }
        //----------------------------EVENTS----------------------------
        //----------------------------QUEUE-----------------------------
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
            if(queue1.Count > 0)
            {
                int x = queue1.Dequeue();
                //display the removed value
                MessageBox.Show($"Item dequeued: {x}");
                //display queue1
                Display(queue1);
            }            
            else
                MessageBox.Show("Illegal Operation: queue is empty");
        }

        private void BtnPeek_Click(object sender, EventArgs e)
        {
            //use the Peek method, which returns the first object in line
            //without removing it
            int x = queue1.Peek();
            //display the removed value
            MessageBox.Show($"First item is: {x}");
            //display queue1
            Display(queue1);
        }

        private void BtnRemoveOdds_Click(object sender, EventArgs e)
        {
            RemoveOdds(queue1);
            Display(queue1);
        }

        private void BtnEnqueueValue2_Click(object sender, EventArgs e)
        {
            //add value from textbox
            try
            {
                int value = int.Parse(txtAddValue.Text);
                //use Enqueue method to add to the back of the queue
                queue2.Enqueue(value);
                //display to see the outcome
                Display(queue2);
                //optional
                txtAddValue.Focus();
                txtAddValue.SelectAll();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        private void BtnEnqueueRandomValue2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(-999, 1000);
            queue2.Enqueue(x);
            Display(queue2);
        }

        private void BtnDequeue2_Click(object sender, EventArgs e)
        {
            //use the Dequeue method, which removes and returns the
            //first object in line
            if (queue2.Count > 0)
            {
                int x = queue2.Dequeue();
                //display the removed value
                MessageBox.Show($"Item dequeued: {x}");
                //display queue2
                Display(queue2);
            }
            else
                MessageBox.Show("Illegal Operation: queue is empty");
        }

        private void BtnPeek2_Click(object sender, EventArgs e)
        {
            //use the Peek method, which returns the first object in line
            //without removing it
            int x = queue2.Peek();
            //display the removed value
            MessageBox.Show($"First item is: {x}");
            //display queue2
            Display(queue2);
        }

        private void BtnRemoveOdds2_Click(object sender, EventArgs e)
        {
            RemoveOdds(queue2);
            Display(queue2);
        }

        private void BtnMerge_Click(object sender, EventArgs e)
        {
            queue3 = SimpleMerge(queue1, queue2);
            Display(queue3);
        }
        //----------------------------STACK-----------------------------
        private void BtnPush_Click(object sender, EventArgs e)
        {
            //add new value to the top of the stack
            try
            {
                int value = int.Parse(txtStackAddValue.Text);
                //use Push method to add to the top of the stack
                stack1.Push(value);
                //display to see the outcome
                Display(stack1);
                //optional
                txtStackAddValue.Focus();
                txtStackAddValue.SelectAll();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }

        }

        private void BtnPushRandomValue_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(-999, 1000);
            stack1.Push(x);
            Display(stack1);
        }

        private void BtnPop_Click(object sender, EventArgs e)
        {
            //pop a value from the stack
            //the value at the top of the stack is removed and
            //returned
            if (stack1.Count > 0)
            {
                int x = stack1.Pop();
                //display the removed value
                MessageBox.Show($"{x} was popped out of the stack");
                //display stack1
                Display(stack1);
            }
            else
                MessageBox.Show("Illegal Operation: stack is empty");
        }
        //----------------------------METHODS----------------------------
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

        private void Display(Stack<int> stack)
        {
            //display in listbox2
            listBox2.Items.Clear();
            foreach (int x in stack)
            {
                listBox2.Items.Add(x);
                //scroll down
                listBox2.TopIndex = listBox2.Items.Count - 1;
            }
        }

        private Queue<int> SimpleMerge(Queue<int> queue1, Queue<int> queue2)
        {
            Queue<int> queue3 = new Queue<int>(100);

            while(queue1.Count != 0 || queue2.Count != 0)
            {
                if(queue1.Count != 0)
                if(queue1.Count != 0)
                    {
                    int x = queue1.Dequeue();
                    queue3.Enqueue(x);
                }

                if (queue2.Count != 0)
                {
                    int x = queue2.Dequeue();
                    queue3.Enqueue(x);
                }
            }

            return queue3;
        }

        private void RemoveOdds(Queue<int> queue)
        {
            int[] intArray = queue.ToArray();
            queue.Clear();

            foreach (int number in intArray)
            {
                if (number % 2 == 0)
                    queue.Enqueue(number);
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
///     
///Exercise
///Define a method that takes 2 stacks and merge them
///(don't assume that both stacks have the same number of items)
///
///define a method "ConvertStackToQueue" that takes a stack and returns a queue with
///all the items from the stack
///
///Reverse a stack using another stack
///
///Remove all the odd values from a stack while maintaining the same original sequence
