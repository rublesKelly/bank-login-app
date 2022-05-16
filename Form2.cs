using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLogin_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

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
            //Intialise a new AccountHolder object with data from the form inputs
            //request controller to add new AccountHolder to database
            //if request is successful display message box
        }
    }
}
