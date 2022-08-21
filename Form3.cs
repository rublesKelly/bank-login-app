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
using AccountModel;
using Controller;

namespace BankLogin_App
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();            
        }

        //Global Variables
        private BankDAO DAO = new BankDAO();
        AccountHolder currentUser = new AccountHolder();
        Account account = new Account();
        private string userEmail = Form1.currentUserEmail;
        private string userPassword = Form1.currentUserPassword;
        private string userName = Form1.currentUserName;
            

        private void Form3_Load(object sender, EventArgs e)
        {
            //Get current user
            currentUser = DAO.GetAccountHolderByEmail(userEmail, userPassword, out bool success);
            account = DAO.GetAccountByAccountHolder(userName, out bool doubleSuccess);
            if (success && doubleSuccess)
            {
                labelNameValue.Text =  account.AccountHolder.ToString();
                labelBalanceValue.Text = "€ " + account.Balance.ToString("0.##");
            }
            // TODO: This line of code loads data into the 'bankDataSet.accounts_table' table. You can move, or remove it, as needed.
            //this.accounts_tableTableAdapter.Fill(this.bankDataSet.accounts_table);
        }
        //private void fillByToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.accounts_tableTableAdapter.FillBy(this.bankDataSet.accounts_table);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
