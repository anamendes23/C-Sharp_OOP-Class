using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //preload listview
            listView1.Items.Add(new ListViewItem(new string[] {"John","425-235-2222","Micorsoft" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Julie", "360-657-5555", "Google" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Aaron", "253-235-2255", "Yahoo" }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get Selected item from a button click
            ListViewItem sitem = listView1.SelectedItems[0];

            richTextBox1.Text = "name: " + sitem.SubItems[0].Text + "\n" +
                                "phone: " + sitem.SubItems[1].Text + "\n" +
                                "work: " + sitem.SubItems[2].Text;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get selected item directly from listview click (selection)
           // MessageBox.Show("number of selected rows: " + listView1.SelectedItems.Count);

            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem sitem = listView1.SelectedItems[0];

                richTextBox1.Text = "name: " + sitem.SubItems[0].Text + "\n" +
                                    "phone: " + sitem.SubItems[1].Text + "\n" +
                                    "work: " + sitem.SubItems[2].Text;
            }

        }
    }
}
