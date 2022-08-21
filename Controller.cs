using System;
using console = System.Diagnostics.Debug;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Imports
using AccountModel;
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
            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@ID",
                Value = accountHolder.ID,
                SqlDbType = SqlDbType.Int                
            });

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
                Value = accountHolder.PhoneNum,
                SqlDbType = SqlDbType.VarChar,
                Size = 50
            });

            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@email",
                Value = accountHolder.Email,
                SqlDbType = SqlDbType.VarChar,
                Size = 50
            });

            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@password",
                Value = accountHolder.Password,
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

                //Execute command and load results into dataReader
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
                        //AccountID = (Int32)dataReader["account_id"],
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
        public AccountHolder GetAccountHolderByEmail(string email, string password, out bool success)
        {
            //Only return data to caller if password given matches password 

            string sql = $"SELECT * FROM account_holder_table WHERE email = '{email}' AND password = '{password}'";

            AccountHolder accountHolder = new AccountHolder();

            success = false;

            try
            {
                SqlCommand command = new SqlCommand(sql, connection);

                connection.Open();

                // Execute command and load results into dataReader
                SqlDataReader dataReader = command.ExecuteReader();
                System.Diagnostics.Debug.WriteLine($"The query sent to DB was {command.CommandText.ToString()}");

                // Fill a single AccountHolder object with datareader
                System.Diagnostics.Debug.WriteLine($"DataReader.HasRows is {dataReader.HasRows}");
                if (dataReader.HasRows)
                {
                    success = true;
                    while (dataReader.Read())
                    {
                        accountHolder.ID = (int)dataReader["ID"];
                        accountHolder.FirstName = dataReader["first_name"].ToString();
                        System.Diagnostics.Debug.WriteLine($"{dataReader["first_name"].ToString()}");
                        accountHolder.LastName = dataReader["last_name"].ToString();
                        accountHolder.Address = dataReader["address"].ToString();
                        //accountHolder.AccountID = (Int32)dataReader["account_id"];
                        accountHolder.PhoneNum = dataReader["phone_num"].ToString();
                        accountHolder.Email = dataReader["email"].ToString();
                        accountHolder.Password = dataReader["password"].ToString();
                        accountHolder.DateOfBirth = (DateTime)dataReader["date_of_birth"];
                    }
                }
                else success = false;
                dataReader.Close();
                System.Diagnostics.Debug.WriteLine($"GetAccountHolderByEmail was {success}");
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            System.Diagnostics.Debug.WriteLine($"Success is {success}");
            return accountHolder;
        }

        //Insert AccountHolder 
        public int InsertAccountHolder(AccountHolder accountHolder, out bool success)
        {
            string sql = "INSERTfd INTO account_holder_table " +
                "(first_name, last_name, address, phone_num, email, password, date_of_birth) " +
                "Values(@first_name, @last_name, @address, @phone_num, @email, @password, @date_of_birth)";
            int id = 0;

            try
            {
                //Set up command 
                SqlCommand command = new SqlCommand(sql, connection);
                SetUpCommandParameters(command, accountHolder);

                //Open connection to DB
                connection.Open();

                //Execute command and verify success with numRows
                int numRows = command.ExecuteNonQuery();
                System.Diagnostics.Debug.WriteLine("The query sent to the DB was" + command.CommandText.ToString());
                
                if (id == 0) success = true; else success = false;
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
            return id;

        }
        
        //Delete AccountHolder
        //Update AccountHolder

        //Set up commmand parameters for Accounts
        private void SetUpCommandParametersAccounts(SqlCommand command, Account account)
        {
            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@balance",
                Value = account.Balance,
                SqlDbType = SqlDbType.Money,

            });
            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@accountHolder",
                Value = account.AccountHolder,
                SqlDbType = SqlDbType.VarChar,
                Size = 50
            });
            command.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@accountHolderID",
                Value = account.AccountHolderID,
                SqlDbType = SqlDbType.Int
            });
        }
        //Search Accounts 
        public Account GetAccountByAccountHolder(string UserName, out bool success)
        {
            string sql = $"SELECT * FROM accounts_table WHERE account_holder = '{UserName}'";

            Account account = new Account();

            success = false;

            try
            {
                SqlCommand command = new SqlCommand(sql, connection);

                connection.Open();

                // Execute command and load results into dataReader
                SqlDataReader dataReader = command.ExecuteReader();
                System.Diagnostics.Debug.WriteLine($"The query sent to DB was {command.CommandText.ToString()}");

                // Fill a single AccountHolder object with datareader
                System.Diagnostics.Debug.WriteLine($"DataReader.HasRows is {dataReader.HasRows}");
                if (dataReader.HasRows)
                {
                    success = true;
                    while (dataReader.Read())
                    {
                        account.AccountHolder = dataReader["account_holder"].ToString();
                        account.Balance = (decimal)dataReader["balance"];
                    };
                }
                else success = false;
                dataReader.Close();
            }
            catch (SqlException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            System.Diagnostics.Debug.WriteLine($"Success is {success}");
            return account;
        }
        //Get all or many Accounts

        //Insert Account 
        public void InsertAccount(AccountHolder accountHolder, int id, out bool success)
        {
            Account account = new Account()
            {
                AccountHolder = $"{accountHolder.FirstName} {accountHolder.LastName}", //Must use this pattern in all parts of the MVC 
                Balance = 1000,
                AccountHolderID = id

            };
            try
            {
                string sql = "INSERT INTO accounts_table (balance, account_holder, account_holder_id)" +
                               "VALUES(@balance, @accountHolder, @accountholderID); ";
                //Set up command 
                SqlCommand command = new SqlCommand(sql, connection);
                SetUpCommandParametersAccounts(command, account);

                //Open connection to DB
                connection.Open();

                //Execute command and verify success with numRows
                 
                int numRows = command.ExecuteNonQuery();
                console.WriteLine("The query sent to the DB was" + command.CommandText.ToString());

                if (numRows > 0) success = true; else success = false;
            }
            catch (SqlException ex)
            {
                console.WriteLine(ex);
                success = false;
                throw;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        //Delete Account
        //Update Account


        //Set Up Parameters for accounts table 

        //Get transactions for account 

        

    }
}
