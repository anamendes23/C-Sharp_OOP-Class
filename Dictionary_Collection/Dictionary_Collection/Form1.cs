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

namespace Dictionary_Collection
{
    public partial class Form1 : Form
    {
        //create a Dictionary<TKey,TValue>
        Dictionary<int, Account> accountDictionary = new Dictionary<int, Account>();

        /* public void Add(TKey key, TValue value)
         * 
         * public bool TryGetValue(TKey key, out TValue value)
         * 
         * public bool Remove(TKey key)
         * */
        public Form1()
        {
            InitializeComponent();
            InitializeAccountDictionary();
            Display(accountDictionary);
        }

        private void InitializeAccountDictionary()
        {
            //add random accounts to the dictionary
            Random rand = new Random();
            //make up a list of banks
            string[] banknames = {"BA", "Chase", "Wells Fargo", "Citigroup",
                                   "KeyCorp", "JP Morgan"};
            //add 50 accounts
            for (int i= 1; i < 50; i++)
            {
                int accountNumber = rand.Next(111111, 999999);
                decimal balance = rand.Next(1000, 50000);
                string bank = banknames[rand.Next(banknames.Length)];

                //create account
                Account account = new Account(accountNumber, balance, bank);
                //add to account dictionary using the Add method
                //public void Add(TKey key, TValue value)
                accountDictionary.Add(accountNumber, account);
            }
        }
        //method to display account dictionary to a listview
        private void Display(Dictionary<int, Account> dictionary)
        {
            ListViewItem lvi = new ListViewItem();
            //a Dictionary is defined as a collection of KeyValuePair objects
            //a KeyValuePair is a struct that has 2 properties
            //Key, Value

            //clear listview 
            listView1.Items.Clear();

            foreach (KeyValuePair<int, Account> kvp in dictionary)
            {
                Account account = kvp.Value;
                string[] row = { account.AccountNumber.ToString(), account.Balance.ToString("c"), account.Bank };
                lvi = new ListViewItem(row);
                listView1.Items.Add(lvi);
            }
            //dictionary defines a property Values, which a
            //collection of all the values (accounts) in the dictionary.
            //foreach (Account account in dictionary.Values)
            //{
            //    string[] row = { account.AccountNumber.ToString(), account.Balance.ToString("c"), account.Bank };
            //    lvi = new ListViewItem(row);
            //    listView1.Items.Add(lvi);
            //}
        }

        private void BtnSearchKey_Click(object sender, EventArgs e)
        {
            /*use tryget method
             *
             * public bool TryGetValue(TKey key, out TValue value)
             * return true if found otherwise false
             * */
            Account account;
            try
            {
                //the key is the account number
                int key = int.Parse(txtSearchKey.Text);
                if (accountDictionary.TryGetValue(key, out account))
                {
                    //found
                    MessageBox.Show(account.ToString());
                }
                else
                    MessageBox.Show("Account not found with the given key.");
            }
            catch(FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }
    }
}
//read about hash functions and hashtables

///Exercise
///Add GUI to remove an account
///redisplay the dictionary when an account is removed
///display message to say "it has been removed" or the attempt
///was unsuccessful because the key does not exist in the dictionary
///use the method: public bool Remove(TKey key)
