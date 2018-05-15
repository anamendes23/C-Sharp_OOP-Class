using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_List_with_IComparable
{
    public class AccountDateComparer : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            if (x.DateCreated > y.DateCreated)
                return 1;
            if (x.DateCreated < y.DateCreated)
                return -1;
            return 0;
        }
    }
}
