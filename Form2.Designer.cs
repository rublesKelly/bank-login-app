namespace BankLogin_App
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FirstName_Lbl = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label_SurName = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label_Phone = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_SignUpHeader = new System.Windows.Forms.Label();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.label_DOB = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toolTipPhone = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1Address = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1Password = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1ConfirmPassword = new System.Windows.Forms.Label();
            this.labelPasswordWarning = new System.Windows.Forms.Label();
            this.labelConfirmPasswordWarning = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName_Lbl
            // 
            this.FirstName_Lbl.AutoSize = true;
            this.FirstName_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FirstName_Lbl.Location = new System.Drawing.Point(90, 76);
            this.FirstName_Lbl.Name = "FirstName_Lbl";
            this.FirstName_Lbl.Size = new System.Drawing.Size(86, 20);
            this.FirstName_Lbl.TabIndex = 0;
            this.FirstName_Lbl.Text = "First Name";
            this.FirstName_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(195, 76);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(210, 20);
            this.textBox_FirstName.TabIndex = 0;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(195, 114);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(210, 20);
            this.textBox_LastName.TabIndex = 1;
            // 
            // label_SurName
            // 
            this.label_SurName.AutoSize = true;
            this.label_SurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_SurName.Location = new System.Drawing.Point(90, 114);
            this.label_SurName.Name = "label_SurName";
            this.label_SurName.Size = new System.Drawing.Size(86, 20);
            this.label_SurName.TabIndex = 2;
            this.label_SurName.Text = "Last Name";
            this.label_SurName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(195, 299);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(210, 20);
            this.textBox_Phone.TabIndex = 7;
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Phone.Location = new System.Drawing.Point(121, 299);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(55, 20);
            this.label_Phone.TabIndex = 4;
            this.label_Phone.Text = "Phone";
            this.label_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipPhone.SetToolTip(this.label_Phone, "Please enter a valid phone number including area code");
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(195, 190);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(210, 20);
            this.textBox_Email.TabIndex = 4;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Email.Location = new System.Drawing.Point(128, 190);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(48, 20);
            this.label_Email.TabIndex = 6;
            this.label_Email.Text = "Email";
            this.label_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_SignUpHeader
            // 
            this.label_SignUpHeader.AutoSize = true;
            this.label_SignUpHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label_SignUpHeader.Location = new System.Drawing.Point(55, 30);
            this.label_SignUpHeader.Name = "label_SignUpHeader";
            this.label_SignUpHeader.Size = new System.Drawing.Size(363, 24);
            this.label_SignUpHeader.TabIndex = 8;
            this.label_SignUpHeader.Text = "Please enter your details and press submit";
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Submit.Location = new System.Drawing.Point(125, 384);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(94, 32);
            this.Btn_Submit.TabIndex = 9;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Cancel.Location = new System.Drawing.Point(253, 384);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(94, 32);
            this.Btn_Cancel.TabIndex = 10;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // label_DOB
            // 
            this.label_DOB.AutoSize = true;
            this.label_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_DOB.Location = new System.Drawing.Point(77, 337);
            this.label_DOB.Name = "label_DOB";
            this.label_DOB.Size = new System.Drawing.Size(99, 20);
            this.label_DOB.TabIndex = 11;
            this.label_DOB.Text = "Date of Birth";
            this.label_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Password.Location = new System.Drawing.Point(98, 228);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(78, 20);
            this.label_Password.TabIndex = 12;
            this.label_Password.Text = "Password";
            this.label_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1Password.SetToolTip(this.label_Password, "Password must include at least one lowercase character, one uppercase character, " +
        "and at least one number.");
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Address.Location = new System.Drawing.Point(108, 152);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(68, 20);
            this.label_Address.TabIndex = 14;
            this.label_Address.Text = "Address";
            this.label_Address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1Address.SetToolTip(this.label_Address, "Please enter your full address in this one text input");
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(195, 152);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(210, 20);
            this.textBox_Address.TabIndex = 2;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(195, 228);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(210, 20);
            this.textBox_Password.TabIndex = 5;
            this.textBox_Password.Leave += new System.EventHandler(this.textBox_Password_Leave);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(195, 336);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker.TabIndex = 8;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(196, 264);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(210, 20);
            this.textBoxConfirmPassword.TabIndex = 6;
            this.textBoxConfirmPassword.Leave += new System.EventHandler(this.textBoxConfirmPassword_Leave);
            // 
            // label1ConfirmPassword
            // 
            this.label1ConfirmPassword.AutoSize = true;
            this.label1ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1ConfirmPassword.Location = new System.Drawing.Point(39, 264);
            this.label1ConfirmPassword.Name = "label1ConfirmPassword";
            this.label1ConfirmPassword.Size = new System.Drawing.Size(137, 20);
            this.label1ConfirmPassword.TabIndex = 16;
            this.label1ConfirmPassword.Text = "Confirm Password";
            this.label1ConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPasswordWarning
            // 
            this.labelPasswordWarning.AutoSize = true;
            this.labelPasswordWarning.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPasswordWarning.ForeColor = System.Drawing.Color.Crimson;
            this.labelPasswordWarning.Location = new System.Drawing.Point(198, 248);
            this.labelPasswordWarning.Name = "labelPasswordWarning";
            this.labelPasswordWarning.Size = new System.Drawing.Size(167, 13);
            this.labelPasswordWarning.TabIndex = 17;
            this.labelPasswordWarning.Text = "Username is too large, 8 char only";
            this.labelPasswordWarning.Visible = false;
            // 
            // labelConfirmPasswordWarning
            // 
            this.labelConfirmPasswordWarning.AutoSize = true;
            this.labelConfirmPasswordWarning.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelConfirmPasswordWarning.ForeColor = System.Drawing.Color.Crimson;
            this.labelConfirmPasswordWarning.Location = new System.Drawing.Point(198, 283);
            this.labelConfirmPasswordWarning.Name = "labelConfirmPasswordWarning";
            this.labelConfirmPasswordWarning.Size = new System.Drawing.Size(167, 13);
            this.labelConfirmPasswordWarning.TabIndex = 19;
            this.labelConfirmPasswordWarning.Text = "Username is too large, 8 char only";
            this.labelConfirmPasswordWarning.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::BankLogin_App.Properties.Resources.Screenshot_55;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(411, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 18);
            this.button1.TabIndex = 18;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 447);
            this.Controls.Add(this.labelConfirmPasswordWarning);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelPasswordWarning);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.label1ConfirmPassword);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_DOB);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.label_SignUpHeader);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label_SurName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.FirstName_Lbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName_Lbl;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label_SurName;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_SignUpHeader;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label label_DOB;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ToolTip toolTipPhone;
        private System.Windows.Forms.ToolTip toolTip1Password;
        private System.Windows.Forms.ToolTip toolTip1Address;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label label1ConfirmPassword;
        private System.Windows.Forms.Label labelPasswordWarning;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelConfirmPasswordWarning;
    }
}