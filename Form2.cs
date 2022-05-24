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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            string message = String.Empty;

            if (textBox_FirstName.Text == String.Empty) message += "Please enter a valid first Name";
            if (textBox_LastName.Text == String.Empty) message += "Please enter a valid last Name";
            if (textBox_Phone.Text == String.Empty) message += "Please enter a valid phone numnber";
            if (textBox_Email.Text == String.Empty) message += "Please enter a valid email address";

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

                //if request is successful display message box
                if (success)
                {
                    MessageBox.Show("Your AccountHolder profile has been added please login");
                }
            //OnClose on the message box form2 closes and form1 opens
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
