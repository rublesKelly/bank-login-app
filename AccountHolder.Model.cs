using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountHolder.Model
{
    internal class AccountHolder
    {
        //Constructors
        public AccountHolder() { }

        public AccountHolder(string id, string first_name, string last_name, string address,
                              int account_id, string phone_num, string email, string password,
                            DateTime date_of_birth )
        {
            ID = id;
            FirstName = first_name;
            LastName = last_name;
            Address = address;
            AccountID = account_id;
            PhoneNum = phone_num;
            Email = email;
            Password = password;
            DateOfBirth = date_of_birth;

        }

        //Properties
        public string ID { get; set;}
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public string Address { get; set; }
        public int AccountID { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
