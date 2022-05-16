using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Imports
using Account.Model;
using AccountHolder.Model;
using System.Data;
using System.Data.SqlClient;


namespace Controller
{
    internal class BankDAO
    {

        //Conntect to Database using class constructor
        private SqlConnection connection; //Instantiate a SqlConnection object 
        public BankDAO()
        {
            connection = new SqlConnection
            {
                ConnectionString = "Data Source=TECH-365;Initial Catalog=Bank;" +
                                   "Integrated Security=True"
            };
        }

        //Set up commmand parameters for AccountHolders
        private void SetUpCommandParameters(SqlCommand command, AccountHolder accountHolder)
        {
            //Initialise a new sqlParameter and use the parameterless constructor
            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@"
            });
        }
        //Search AccountHolders 
        //Get all or many AccountHolders
        //Insert AccountHolder 
            //Need to create a new account to here with a blank balance
        //Delete AccountHolder
        //Update AccountHolder

        //Set up commmand parameters for Accounts
        //Search Accounts 
        //Get all or many Accounts
        //Insert Account 
        //Delete Account
        //Update Account

    }
}
