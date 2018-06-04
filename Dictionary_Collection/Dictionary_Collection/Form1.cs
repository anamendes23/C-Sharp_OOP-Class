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
        }
    }
}
//read about hash functions and hashtables
