using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using AccountHolderModel;

namespace BankLogin_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Global variables 
        private List<AccountHolder> listOfAccountHolders;
        private BankDAO DAO = new BankDAO();
        AccountHolder currentUser = new AccountHolder();
        public static string currentUserEmail = string.Empty;
        public static string currentUserPassword = string.Empty;
        public static string currentUserName = string.Empty;
        bool toggle = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            listOfAccountHolders = DAO.GetAccountHolders(out bool succcess);

            //if (succcess)
            //{
            //    MessageBox.Show("Success is true " + listOfAccountHolders.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("Success is false");
            //}
        }

        private bool ValidateLogin()
        {
            //Validation to make sure fields aren't empty
            string message = String.Empty;
            if (textBox_Email.Text == String.Empty) message += "Please enter an email address \n \n";
            if (textBox_Password.Text == String.Empty) message += "Please enter password \n \n";
            if (message != String.Empty) MessageBox.Show(message);
            return message == String.Empty;
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            
            bool isValid = ValidateLogin();

            //Search for specific user DAO.FindYserByEmail(email, password)
            string email = textBox_Email.Text;
            string password = textBox_Password.Text;
            currentUserEmail = textBox_Email.Text;
            currentUserPassword = textBox_Password.Text;
            

            if (isValid == true)
            {
                currentUser = DAO.GetAccountHolderByEmail(email, password, out bool success);

                System.Diagnostics.Debug.WriteLine($"The current user is {currentUser.FirstName} the email used was {email}");

                //Open form with user details and close this form
                System.Diagnostics.Debug.WriteLine($"Success is {success}");
                if (success)
                {
                    MessageBox.Show("You have loggedIn ");
                    currentUserName = $"{currentUser.FirstName} {currentUser.LastName}";
                    Form3 form3 = new Form3(); //Probably gonna need to put in current as a param for constructor or onLoad function 
                    //Pass currentUser to Form3 and expose currentUser to Form3
                    form3.Show();
                    //this.Close();

                }
                else MessageBox.Show("Email or Password did not match any users please try again or sign as a new user");
            }

        }

        private void WelcomeHeader_Click(object sender, EventArgs e)
        {

        }

        private void TestingButton_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); //Initaialise a new Form2 object form Form2 class

            form2.Show();
        }

        private void buttonPassViewer_Click(object sender, EventArgs e)
        {
            if (this.toggle)
            {
                buttonPassViewer.BackgroundImage = global::BankLogin_App.Properties.Resources.Screenshot_55;
                textBox_Password.PasswordChar = '*';
                this.toggle = false;
            }
            else
            {
                buttonPassViewer.BackgroundImage = global::BankLogin_App.Properties.Resources.Screenshot_56;
                textBox_Password.PasswordChar = '\0';
                this.toggle = true;
            }
        }
    }
}
