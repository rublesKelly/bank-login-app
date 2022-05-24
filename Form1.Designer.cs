namespace BankLogin_App
{
    partial class Form1
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
            this.WelcomeHeader = new System.Windows.Forms.Label();
            this.SignUp_Btn = new System.Windows.Forms.Button();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeHeader
            // 
            this.WelcomeHeader.AutoSize = true;
            this.WelcomeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.WelcomeHeader.Location = new System.Drawing.Point(173, 50);
            this.WelcomeHeader.Name = "WelcomeHeader";
            this.WelcomeHeader.Size = new System.Drawing.Size(203, 51);
            this.WelcomeHeader.TabIndex = 0;
            this.WelcomeHeader.Text = "Welcome";
            this.WelcomeHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeHeader.Click += new System.EventHandler(this.WelcomeHeader_Click);
            // 
            // SignUp_Btn
            // 
            this.SignUp_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SignUp_Btn.Location = new System.Drawing.Point(286, 242);
            this.SignUp_Btn.Name = "SignUp_Btn";
            this.SignUp_Btn.Size = new System.Drawing.Size(104, 34);
            this.SignUp_Btn.TabIndex = 1;
            this.SignUp_Btn.Text = "Sign Up";
            this.SignUp_Btn.UseVisualStyleBackColor = true;
            this.SignUp_Btn.Click += new System.EventHandler(this.SignUp_Btn_Click);
            // 
            // Login_Btn
            // 
            this.Login_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Login_Btn.Location = new System.Drawing.Point(158, 242);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(104, 34);
            this.Login_Btn.TabIndex = 2;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.UseVisualStyleBackColor = true;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(218, 177);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(210, 20);
            this.textBox_Password.TabIndex = 21;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Password.Location = new System.Drawing.Point(121, 177);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(78, 20);
            this.label_Password.TabIndex = 20;
            this.label_Password.Text = "Password";
            this.label_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(218, 139);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(210, 20);
            this.textBox_Email.TabIndex = 19;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Email.Location = new System.Drawing.Point(151, 139);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(48, 20);
            this.label_Email.TabIndex = 18;
            this.label_Email.Text = "Email";
            this.label_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 349);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.SignUp_Btn);
            this.Controls.Add(this.WelcomeHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeHeader;
        private System.Windows.Forms.Button SignUp_Btn;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
    }
}

