using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountHolderModel;
using Controller;
using System.Text.RegularExpressions;


namespace BankLogin_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Gloabal Variables
        BankDAO DAO = new BankDAO();
        bool toggle = false;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private bool ValidatePassword(out string ErrorMessage, out int strenght)
        {
            //Stuff hewew
            string input = textBox_Password.Text;
            ErrorMessage = String.Empty;
            strenght = 10;

            Regex hasNumber = new Regex(@"[0-9]+");
            Regex hasUpperChar = new Regex(@"[A-Z]+");
            Regex hasMiniMaxChars = new Regex(@".{8,14}");
            Regex hasLowerChar = new Regex(@"[a-z]+");

            if(input == String.Empty)
            {
                ErrorMessage = String.Empty;
                strenght = 0;
                return true;
            }
            else if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one lower case letter";
                strenght -= 2;
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one upper case letter";
                strenght -= 2;
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should not be less than or greater than 12 characters";
                strenght -= 2;
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one numeric value";
                strenght -= 2;
                return false;
            }
            else
            {
                strenght = 10;
                return true;
            }
        }

        private bool ValidateConfirmPassword(out string ErrorMessage)
        {
            //Run this when confirmPassword onLeave 
            ErrorMessage = String.Empty;

            if(textBox_Password.Text == textBoxConfirmPassword.Text)
            {
                return true;
            }
            else
            {
                ErrorMessage = "Passwords are not the same";
                return false;
            }
        }
        
        private bool ValidateForm()
        {
            string message = String.Empty;

            Regex isEmail = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
            //Regex isPhone = new Regex(@"^\(?\+?\d{1}\)\?\-?\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");

            if (textBox_FirstName.Text == String.Empty) message += "Please enter a valid first Name \n \n";
            if (textBox_LastName.Text == String.Empty) message += "Please enter a valid last Name \n \n";
            if (textBox_Address.Text == String.Empty) message += "Please enter a valid address \n \n";
            if (textBox_Phone.Text == String.Empty) message += "Please enter a valid phone numnber \n \n";
            if (!isEmail.IsMatch(textBox_Email.Text) || textBox_Email.Text == String.Empty) 
                    message += "Please enter a valid email address \n \n";
            bool validPass = ValidatePassword(out string ErrorMessage, out int strenght);
                if (!validPass) message += ErrorMessage;
            ValidateConfirmPassword(out string err);
                if (err != String.Empty) message += err;

            if (message != String.Empty) MessageBox.Show(message);
            return message == String.Empty;
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            //Call ValidateForm()
            bool isValid = ValidateForm();

            //Intialise a new AccountHolder object with data from the form inputs
            if (isValid) {
                AccountHolder accountHolder = new AccountHolder
                {
                    FirstName = textBox_FirstName.Text,
                    LastName = textBox_LastName.Text,
                    Address = textBox_Address.Text,
                    PhoneNum = textBox_Phone.Text,
                    Email = textBox_Email.Text,
                    Password = textBox_Password.Text,
                    DateOfBirth = dateTimePicker.Value
                }; 

                //request controller to add new AccountHolder to database
                DAO.InsertAccountHolder(accountHolder, out bool success);
                AccountHolder test  = DAO.GetAccountHolderByEmail(accountHolder.Email, accountHolder.Password, out bool doubleSuccess);
                int AccountHolderId = test.ID;
                System.Diagnostics.Debug.WriteLine($"The accountHolder ID is {AccountHolderId}  and his name is  {test.FirstName.ToString()}");
                DAO.InsertAccount(accountHolder, AccountHolderId, out bool triplescuccess);

                //if request is successful display message box
                if (success && doubleSuccess && triplescuccess)
                {
                    MessageBox.Show("Your AccountHolder profile has been added please login");
                    this.Close();
                }
            //OnClose on the message box form2 closes and form1 opens
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Password_Leave(object sender, EventArgs e)
        {
            //This is an offFocus Event handler used to call Validate password and show password to short label if true
            bool isValid = ValidatePassword(out string err, out int strenght);
            labelPasswordWarning.Text = $"{err}";
            System.Diagnostics.Debug.WriteLine($"The sternght of the password is {strenght}");
            
            if (!isValid)
            {
                labelPasswordWarning.Show();
    }
            else
            {
                labelPasswordWarning.Hide();
            }
        }

        private void textBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            bool isValid = ValidateConfirmPassword(out string err);
            labelConfirmPasswordWarning.Text = $"{err}";

            if (!isValid)
            {
                labelConfirmPasswordWarning.Show();
            }
            else
            {
                labelConfirmPasswordWarning.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {        
            if (this.toggle)
            {
                button1.BackgroundImage = global::BankLogin_App.Properties.Resources.Screenshot_55;
                textBox_Password.PasswordChar = '*';
                this.toggle = false;
            }
            else 
            {
                button1.BackgroundImage = global::BankLogin_App.Properties.Resources.Screenshot_56;
                textBox_Password.PasswordChar = '\0';
                this.toggle = true;
            }           
        }
    }
}
