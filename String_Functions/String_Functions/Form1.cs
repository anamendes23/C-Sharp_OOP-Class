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
using System.Globalization;

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
            //string inputString = richTextBox1.Text;
            //int index = 0;

            //foreach (char ch in inputString)
            //{
            //    if (ch == ' ')
            //        index = inputString.IndexOf(ch);
            //}

            //richTextBox2.Text = $"The index of the first space is {index}";

            //------------Lhoucine's------------
            string inputString = richTextBox1.Text;
            //public int IndexOf(string value)
            char blank = ' ';
            int firstIndex = inputString.IndexOf(blank);
            if(firstIndex >= 0)
            {
                //get index of the second blank
                int secondIndex = inputString.IndexOf(blank, firstIndex + 1);
                richTextBox2.Text = $"Index of the first blank is: {firstIndex}";
                if (secondIndex >= 0)
                    richTextBox2.AppendText($"\nIndex of the second blank is: {secondIndex}");
            }
            //get (if any) the index of the last blank
            int lastIndex = inputString.LastIndexOf(blank);
            if (lastIndex >= 0)
                richTextBox2.AppendText($"\nIndex of the last blank is: {lastIndex}");
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
            //--------------Lhoucine----------------
            string inputString = richTextBox1.Text;
            //public int IndexOf(string value)
            char blank = ' ';
            //get index of first blank
            int firstIndex = inputString.IndexOf(blank);
            //make sure that the inputString contains a blank
            if (firstIndex >= 0)
            {
                //remove the blank
                inputString = inputString.Remove(firstIndex, 1);
                //insert at its position a dash
                inputString = inputString.Insert(firstIndex, "-");

                richTextBox1.Text = inputString;
            }


            //---------------Ana-----------------
            //char[] partial = new char[firstIndex + 1];
            //char[] replace = new char[firstIndex + 1];
            //for (int i = 0; i < partial.Length; i++)
            //{
            //    partial[i] = inputString[i];
            //    replace[i] = inputString[i];
            //}
            //replace[firstIndex] = '-';
            //string partialString = new string(partial);
            //string replaceString = new string(replace);
            //richTextBox1.Text = inputString.Replace(partialString, replaceString);
        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            string inputString = richTextBox1.Text;
            char[] separators = { ' ', ',', ':', '.', ';', '!', '?' };
            string[] words = inputString.Split(separators);
            //display
            richTextBox2.Clear();
            foreach (string w in words)
                richTextBox2.AppendText(w + "\n");
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            //Swap the first word with the last word in the inputString
            //get original string
            string inputString = richTextBox1.Text;
            //define separators of words
            char[] separators = { ' ', ',', ':', '.', ';', '!', '?' };
            //put words in array
            string[] words = inputString.Split(separators);
            //get index of last word (-2 because last element in string[] is a blank
            int indexLastWord = words.Length - 2;
            //define old strings
            string firstLetterSwapOld = words[0] + " " + words[1];
            string lastLetterSwapOld = words[indexLastWord - 1] + " " + words[indexLastWord];
            //define new strings
            string firstLetterSwapNew = words[indexLastWord] + " " + words[1];
            string lastLetterSwapNew = words[indexLastWord - 1] + " " + words[0];
            //swap both words by using Replace()
            inputString = inputString.Replace(firstLetterSwapOld, firstLetterSwapNew);
            inputString = inputString.Replace(lastLetterSwapOld, lastLetterSwapNew);
            //display
            richTextBox1.Text = inputString;
        }

        private void BtnReplaceBlanks_Click(object sender, EventArgs e)
        {
            //replace all the blanks with a double dash
            string inputString = richTextBox1.Text;
            inputString = inputString.Replace(" ", "--");
            richTextBox1.Text = inputString;
        }

        private void BtnUppercaseFirst_Click(object sender, EventArgs e)
        {
            //Uppercase the first char or letter of every word in inputString
            string inputString = richTextBox1.Text;
            //char[] separators = { ' ', ',', ':', '.', ';', '!', '?' };
            //string[] words = inputString.Split(separators);

            //for (int i = 0; i < words.Length; i++)
            //{                
            //    if (words[i] != String.Empty)
            //    {
            //        char[] holder = words[i].ToCharArray();
            //        if (holder != null)
            //        {
            //            if (Char.IsLower(holder[0]))
            //            {
            //                holder[0] = Char.ToUpper(holder[0]);
            //                string newWord = new string(holder);
            //                //replace word in inputString
            //                inputString = inputString.Replace(words[i], newWord);
            //            }                            
            //        }
            //    }                
            //}

            TextInfo textUpper = new CultureInfo("en-US", false).TextInfo;

            richTextBox1.Text = textUpper.ToTitleCase(inputString);
        }

        private void BtnGetVowels_Click(object sender, EventArgs e)
        {
            //Determine the number of vowels in the inputString
            string inputString = richTextBox1.Text;
            int counter = 0;
            foreach (char ch in inputString)
            {
                if ("aeiouAEIOU".Contains(ch))
                    counter++;
            }
            richTextBox2.Text = $"There are {counter} vowels";
        }

        private void BtnGetIndexFirstVowel_Click(object sender, EventArgs e)
        {
            //Determine the index of the first vowel in the input string.
            string inputString = richTextBox1.Text;
            int index = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if ("aeiouAEIOU".Contains(inputString[i]))
                {
                    index++;
                    break;
                }                    
            }                
            richTextBox2.Text = $"Index for first vowel is {index}";
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
///
///Exercise:
///Swap the first word with the last word in the inputString
///replace all the blanks with a double dash
///Uppercase the first char or letter of every word in inputString
///Determine the number of vowels in the inputString
///Determine the index of the first vowel in the input string.
