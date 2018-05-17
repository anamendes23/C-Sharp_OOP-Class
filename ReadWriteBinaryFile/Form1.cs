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
using System.IO; //ADD THIS

namespace ReadWriteBinaryFile
{
    public partial class Form1 : Form
    {
        /* BINARY FILES
         * Read/write object data from/to file
         * 
         * 1. Open File/create it to read or to write
         *      Open file: use FileStream class
         * 2. Read/write
         *      Read File: BinaryReader
         *      Write File: BinaryWriter
         * 3. Close the stream (File)
         *      Using the Close method
         *      
         *      Use try / catch / finally blocks
         * */

        string filePath = "cars.dat";

        List<Car> carList = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            //declare as global because you'll access them in try and finally (two different blocks)
            FileStream fs = null;
            BinaryWriter bw = null;

            try
            {
                //1. Open or create file for writing/appending
                //create FileStream
                //open the file if it exists or create it if it does not exist
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                //2. Write data to the file using BinaryWriter
                bw = new BinaryWriter(fs);
                //use bw.Write() method to write data to file
                //get data from user
                string make = txtMake.Text;
                string model = txtModel.Text;
                int year = int.Parse(txtYear.Text);
                int mileage = int.Parse(txtMileage.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                //write it to file
                bw.Write(make);
                bw.Write(model);
                bw.Write(year);
                bw.Write(mileage);
                bw.Write(price);
                //optional: let user know
                MessageBox.Show("Car data was saved to file");

            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            catch(FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            finally
            {
                //code in here will always run
                //close stream
                fs.Close();
                bw.Close();
            }
        }

        private void btnReadCars_Click(object sender, EventArgs e)
        {
            //FileStream to open file for reading
            //BinaryReader to read data from file
            FileStream fs = null;
            BinaryReader br = null;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                //use while loop to read
                while(br.BaseStream.Position != br.BaseStream.Length)
                {
                    //read data in the same order it was written
                    string make = br.ReadString();
                    string model = br.ReadString();
                    int year = br.ReadInt32();
                    int mileage = br.ReadInt32();
                    decimal price = br.ReadDecimal();
                    //display to the richtextbox1
                    richTextBox1.AppendText(
                        $"{make}  {model}  {year}  {mileage}  {price:c}");
                }
            }
            catch (FileNotFoundException fne)
            {
                MessageBox.Show(fne.Message);
            }
            catch (IOException ioe)
            {
                //found the file, but has problem reading it
                MessageBox.Show(ioe.Message);
            }
            finally
            {
                fs.Close();
                br.Close();
            }
        }
    }
}
