using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Imports
using Account.Model;
using AccountHolderModel;
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
            //command.Parameters.Add(new SqlParameter()
            //{
            //    ParameterName = "@ID",
            //    Value = accountHolder.ID,
            //    SqlDbType = SqlDbType.VarChar,
            //    Size = 50
            //});

            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@first_name",
                Value = accountHolder.FirstName,
                SqlDbType = SqlDbType.VarChar,
                Size = 50
            });

            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@last_name",
                Value = accountHolder.LastName,
                SqlDbType = SqlDbType.VarChar,
                Size = 50
            });

            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@address",
                Value = accountHolder.Address,
                SqlDbType = SqlDbType.VarChar,
                Size = 50
            });

            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@account_id",
                Value = accountHolder.AccountID,
                SqlDbType = SqlDbType.VarChar,
                Size = 50
            });

            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@phone_num",
                Value = accountHolder.AccountID,
                SqlDbType = SqlDbType.VarChar,
                Size = 50
            });

            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@email",
                Value = accountHolder.AccountID,
                SqlDbType = SqlDbType.VarChar,
                Size = 50
            });

            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@password",
                Value = accountHolder.AccountID,
                SqlDbType = SqlDbType.VarChar,
                Size = 50
            });

            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@date_of_birth",
                Value = accountHolder.DateOfBirth,
                SqlDbType = SqlDbType.DateTime                
            });
        }
        //Get all or many AccountHolders
        public List<AccountHolder> GetAccountHolders(out bool success)
        {
            //Declare list to be filled
            List<AccountHolder> listOfAccountHolders = new List<AccountHolder>();
            //Declare SQL statement to be executed
            string sql = "SELECT * FROM account_holder_table";

            //TryCatch Query 
            try
            {
                //Set up command 
                SqlCommand command = new SqlCommand(sql, connection);

                //Open connection to DB
                connection.Open();

                //Execute command load results into dataReader
                SqlDataReader dataReader = command.ExecuteReader();

                //Loop through dataReader load results into listOfCars 
                while (dataReader.Read())
                {
                    //Create a new Car object for each row in the dataReader
                    AccountHolder accountHolder = new AccountHolder
                    {
                        //ID = dataReader[""].ToString(),
                        FirstName = dataReader["first_name"].ToString(),
                        LastName = dataReader["last_name"].ToString(),
                        Address = dataReader["address"].ToString(),
                        AccountID = (Int32)dataReader["account_id"],
                        PhoneNum = dataReader["phone_num"].ToString(),
                        Email = dataReader["email"].ToString(),
                        Password = dataReader["password"].ToString(),
                        DateOfBirth = (DateTime)dataReader["date_of_birth"],
                    };
                    //Add new car to list
                    listOfAccountHolders.Add(accountHolder);
                }
                success = true;
            }
            catch (SqlException ex)
            {
                success = false;
                Console.WriteLine(ex);
                
            }
            finally
            {
                if(connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return listOfAccountHolders;
        }
        //Search AccountHolders 
        //Insert AccountHolder 
        public void InsertAccountHolder(AccountHolder accountHolder, out bool success)
        {
            string sql = "INSERT INTO account_holder_table " +
                "(first_name, last_name, address, phone_num, email, password, date_of_birth) " +
                "Values(@first_name, @last_name, @address, @phone_num, @email, @password, @date_of_birth)";
            try
            {
                //Set up command 
                SqlCommand command = new SqlCommand(sql, connection);
                SetUpCommandParameters(command, accountHolder);

                //Open connection to DB
                connection.Open();
                
                System.Diagnostics.Debug.WriteLine("Hello" + command.CommandText.ToString());

                //Execute command and verify success with numRows
                int numRows = command.ExecuteNonQuery();
                
                if (numRows > 0) success = true; else success = false;
            }
            catch (SqlException ex)
            {
                success = false;
                Console.WriteLine(ex);

            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }


        }
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
