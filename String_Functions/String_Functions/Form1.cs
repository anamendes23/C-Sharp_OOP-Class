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
     defines properties and methods that allow you to manipulate
     strings.
     A string is considered an array of characters
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGetLength_Click(object sender, EventArgs e)
        {
            //Use the Length property to find out the number of chars
            //in a string
            string inputString = richTextBox1.Text;
            int numOfChars = inputString.Length;
            richTextBox2.Text =
                $"The input string has {numOfChars} characters";
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
            //count the number of digits and the number of punctuations
            //in the input string. Display results
            string inputString = richTextBox1.Text;
            int dcounter = 0;
            int pcounter = 0;
            foreach (char ch in inputString)
            {
                if (Char.IsDigit(ch))
                    dcounter++;
                else if (Char.IsPunctuation(ch))
                    pcounter++;
            }

            richTextBox2.Text = $"There are {dcounter} digits & {pcounter} punctuations" +
                "in the input string";
        }

        private void BtnCountUpperCase_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string inputString = richTextBox1.Text;

            foreach (char ch in inputString)
            {
                if (Char.IsUpper(ch))
                    counter++;
            }

            richTextBox2.Text = $"There are {counter} upper case letters in the input string";
        }

        private void BtnIndexFirstSpace_Click(object sender, EventArgs e)
        {
            string inputString = richTextBox1.Text;
            int index = 0;

            foreach (char ch in inputString)
            {
                if (ch == ' ')
                    index = inputString.IndexOf(ch);
            }

            richTextBox2.Text = $"The index of the first space is {index}";
        }

        private void BtnIndexSecondSpace_Click(object sender, EventArgs e)
        {
            string inputString = richTextBox1.Text;
            int index1 = 0;

            foreach (char ch in inputString)
            {
                if (ch == ' ')
                {
                    index1 = inputString.IndexOf(ch);
                    break;
                }                    
            }

            int index2 = 0;
            string newString = inputString.Remove(0, index1 + 1);

            foreach (char ch in newString)
            {
                if (ch == ' ')
                {
                    index2 = newString.IndexOf(ch);
                    break;
                }
            }

            index2 += index1 + 1;

            richTextBox2.Text = $"The index of the second space is {index2}";
        }

        private void BtnReplaceFirstSpace_Click(object sender, EventArgs e)
        {
            string inputString = richTextBox1.Text;

            richTextBox1.Text = inputString.Replace("Eat too", "Eat-too");
        }
    }
}
///Exercise:
///add a button that counts the number of digits and the number
///of punctuations in the input string. Display results
///
///add a button to count the number of characters that are upper case
///Use IndexOf method to determine the index of the first space
///Use IndexOf (version2) method to determine the index of the second space
///Use the replace method to replace the first space with a '-'
