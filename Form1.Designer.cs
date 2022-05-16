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
            this.SuspendLayout();
            // 
            // WelcomeHeader
            // 
            this.WelcomeHeader.AutoSize = true;
            this.WelcomeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.WelcomeHeader.Location = new System.Drawing.Point(194, 76);
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
            this.SignUp_Btn.Location = new System.Drawing.Point(74, 182);
            this.SignUp_Btn.Name = "SignUp_Btn";
            this.SignUp_Btn.Size = new System.Drawing.Size(141, 49);
            this.SignUp_Btn.TabIndex = 1;
            this.SignUp_Btn.Text = "Sign Up";
            this.SignUp_Btn.UseVisualStyleBackColor = true;
            // 
            // Login_Btn
            // 
            this.Login_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Login_Btn.Location = new System.Drawing.Point(356, 181);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(141, 49);
            this.Login_Btn.TabIndex = 2;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.UseVisualStyleBackColor = true;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 367);
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
    }
}

