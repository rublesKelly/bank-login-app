//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;

//namespace Controller
//{
//    internal class BankDAOBase
//    {
//        //Search AccountHolders 
//        public List<AccountHolder.Model> GetAccountHolders(out bool success)
//        {
//            List<AccountHolder> listOfAccountHolders = new List<AccountHolder>();

//            try
//            {
//                success = true;
//            }
//            catch (SqlException ex)
//            {
//                success = false;
//                Console.WriteLine(ex);

//            }
//            finally
//            {
//                if (connection.State != ConnectionState.Closed)
//                {
//                    connection.Close();
//                }
//            }
//            return listOfAccountHolders;
//        }
//    }
//}