using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountModel
{
    internal class Account
    {
        //Properties 
        public int ID { get; set; }
        public decimal Balance { get; set; }
        public int AccountHolderID { get; set; }
        public string AccountHolder { get; set; }


        //Paramerterless Constructor
        public Account() { }
        //Paramerter Constructor
        public Account(int id, decimal balance, int account_holderID, string account_holder)
        {
            ID = id;
            Balance = balance;
            AccountHolderID = account_holderID;
            AccountHolder = account_holder;
        }
    }
}
