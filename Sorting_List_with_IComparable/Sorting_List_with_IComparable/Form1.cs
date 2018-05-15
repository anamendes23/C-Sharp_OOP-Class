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

namespace Sorting_List_with_IComparable
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        List<Account> accList = new List<Account>();

        public Form1()
        {
            InitializeComponent();
            InitializeNumbers();
            InitializeAccounts();
            Display(numbers);
            Display(accList);
        }
        //------------------------------METHODS------------------------------------------

        private void InitializeNumbers()
        {
            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                numbers.Add(rand.Next(1000, 2000));
            }
        }

        private void InitializeAccounts()
        {
            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                int accNumber = rand.Next(1234567, 2000000);
                decimal balance = rand.Next(1000, 5000);

                int year = DateTime.Now.Year - rand.Next(15);
                int month = rand.Next(1, 13);
                int day = rand.Next(1, 29);

                DateTime dateCreated = new DateTime(year, month, day);

                Account account = new Account
                {
                    AccNumber = accNumber,
                    Balance = balance,
                    DateCreated = dateCreated
                };

                accList.Add(account);
            }
        }

        private void Display(List<int> list)
        {
            listBox1.Items.Clear();

            foreach (int num in numbers)
            {
                listBox1.Items.Add(num);
            }
        }

        private void Display(List<Account> list)
        {
            listView1.Items.Clear();

            foreach (Account acc in accList)
            {
                ListViewItem row = new ListViewItem(
                    new String[]
                    {
                        acc.AccNumber.ToString(), acc.Balance.ToString("c"), acc.DateCreated.ToShortDateString()
                    });

                listView1.Items.Add(row);
            }
        }

        //------------------------------EVENTS-------------------------------------------

        private void btnSortNumbers_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            Display(numbers);
        }

        private void btnSortByAccNumber_Click(object sender, EventArgs e)
        {
            accList.Sort(); //the Sort method works if
            //the Account class inherits the interface IComparable<T>
            Display(accList);
        }

        private void btnSortByBalance_Click(object sender, EventArgs e)
        {
            /*
             public void Sort(IComparer<T> comparer)

                this method needs an object of a class that inherits from IComparer<T>

                we need to define a class that inherits the IComparer<T> interface.
                In our case T is Account
             */

            AccountBalanceComparer comparer = new AccountBalanceComparer();
            accList.Sort(comparer);
            Display(accList);
        }

        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            // public void Sort(IComparer<T> comparer)
            //create a class that inherits IComparer<T>
            //override the Comparer to compare according to dateCreated

            AccountDateComparer comparer = new AccountDateComparer();
            accList.Sort(comparer);
            Display(accList);
        }
    }
}
///Exercise:
///New project
///Define a class Box with Length, Width, Height
///Define methods: Volume and Area
///where Volume = L * W * H
///and Area = 2*L*W + 2*L*H + 2*W*H
///
///Define a List<Box>
///Define a method InitializeBoxList with 50 random boxes
///
///Use both IComparable<T> and IComparer<T> to sort the boxList
///by Volume and by Area
