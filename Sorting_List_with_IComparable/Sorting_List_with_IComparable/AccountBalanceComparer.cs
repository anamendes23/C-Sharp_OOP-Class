using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_List_with_IComparable
{
    public class AccountBalanceComparer : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            if (x.Balance > y.Balance)
                return 1;
            if (x.Balance < y.Balance)
                return -1;
            return 0;
        }
    }
}
