using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Collection
{
    public class Account
    {
        private int _accountNumber;
        private decimal _balance;
        private string _bank;

        public Account(int accountNumber, decimal balance, string bank)
        {
            _accountNumber = accountNumber;
            _balance = balance;
            _bank = bank;
        }

        public int AccountNumber { get => _accountNumber; }
        public decimal Balance { get => _balance; }
        public string Bank { get => _bank; }

        //public int AccountNumber { get { return _accountNumber; } }
        public override string ToString()
        {
            //return String.Format("{0}\t\t{1}\t{2}",
            //    _accountNumber, _balance.ToString("c"), _bank);

            return $"{_accountNumber}\t{_balance:c}\t{_bank}";
        }
    }
}
