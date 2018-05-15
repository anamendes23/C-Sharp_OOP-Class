using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_List_with_IComparable
{
    public class Account : IComparable<Account>
    {
        public int AccNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public int CompareTo(Account other)
        {
            if (this.AccNumber > other.AccNumber)
                return 1;
            if (this.AccNumber < other.AccNumber)
                return -1;
            return 0;
        }
    }
}
