/* Ana Mendes
 * anamendes23@gmail.com
 * github.com/anamendes23
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

namespace String_Functions
{
    /*
     String Class
     -----------------------------
      
      
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGetLength_Click(object sender, EventArgs e)
        {

        }

        private void BtnNumOfOccurences_Click(object sender, EventArgs e)
        {
            //find out the number of occurences of char 'a'
            //since an string is considered as an array of characters
            //you can use a for loop or a foreach loop
            string inputString = richTextBox1.Text;
            int counter = 0;
            foreach (char ch in inputString)
            {
                if (ch == 'a')
                    counter++;
            }
            richTextBox2.Text = $"There are {counter} 'a's in the string";
        }

        private void BtnCountLetters_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string inputString = richTextBox1.Text;
            //for (int i = 0; i < inputString.Length; i++)
            //{
            //    if (Char.IsLetter(inputString, i))
            //        counter++;
            //}
            //or

            foreach (char ch in inputString)
            {
                if (Char.IsLetter(ch))
                    counter++;
            }

            richTextBox2.Text = $"There are {counter} letters in the input string";
        }

        private void BtnCountDigitsPunctuations_Click(object sender, EventArgs e)
        {

        }
    }
}
///Exercise:
///add a button that counts the number of digits and the number
///of punctuations in the input string. Display results
