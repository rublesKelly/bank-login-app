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

        private void Form1_Load(object sender, EventArgs e)
        {
            listOfAccountHolders = DAO.GetAccountHolders(out bool succcess);

            if (succcess)
            {
                MessageBox.Show("Success is true " + listOfAccountHolders.ToString());
            }
            else
            {
                MessageBox.Show("Success is false");
            }
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {

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
    }
}
