using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Model
{
    internal class Account
    {
        //Properties 
        public string AccountID { get; set; }
        public decimal Balance { get; set; }
        public string AccountHolderID { get; set; }


        //Constructors 
        public Account() { }

        public Account(string account_id, decimal balance, string account_holderID)
        {
            AccountID = account_id;
            Balance = balance;
            AccountHolderID = account_holderID;
        }
    }
}
