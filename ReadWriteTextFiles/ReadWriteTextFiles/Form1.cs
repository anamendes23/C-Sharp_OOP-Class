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
using System.IO;

namespace ReadWriteTextFiles
{
    /* Text files : using System.IO
     * ------------
     * 1. Open an existing file or create a new one
     * using FileStream class
     * 
     * 2. Read the file using StreamReader
     * or Write to file using StreamWriter
     * 
     * 3. Close the streams 
     * 
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            FileStream fs = null; //to open or create
            StreamWriter sw = null; //to write to it
            string filepath = txtFilePath.Text;

            try
            {
                fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                //get text to write
                string text = txtTextToWrite.Text;
                //write it
                sw.WriteLine(text);
                MessageBox.Show("text has been appended to file...");
            }
            catch (ArgumentException ae) //txtbox not empty
            {
                MessageBox.Show(ae.Message);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
                if (fs != null) //cannot close a null file
                    fs.Close();
            }
        }

        private void BtnReadText_Click(object sender, EventArgs e)
        {
            FileStream fs = null; //to open or create
            StreamReader sr = null; //to read to it
            string filepath = txtFilePath.Text;

            try
            {
                fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    //display it
                    richTextBox1.AppendText(line + "\n");
                }
            }
            catch (ArgumentException ae) //txtbox not empty
            {
                MessageBox.Show(ae.Message);
            }
            catch (FileNotFoundException fne)
            {
                MessageBox.Show(fne.Message);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
                if (fs != null) //cannot close a null file
                    fs.Close();
            }
        }
    }
}
