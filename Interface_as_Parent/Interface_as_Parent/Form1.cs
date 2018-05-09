using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceLib;

namespace Interface_as_Parent
{
    public partial class Form1 : Form
    {
        List<IShape> shapes = new List<IShape>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Circle c = new Circle(rand.Next(3, 10));
            shapes.Add(c);
            lstShapes.Items.Add(c.ToString());
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            InterfaceLib.Rectangle r = new InterfaceLib.Rectangle(rand.Next(3, 10), rand.Next(6, 13));
            shapes.Add(r);
            lstShapes.Items.Add(r.ToString());
        }
    }
}
