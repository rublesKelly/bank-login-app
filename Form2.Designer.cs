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
            this.FirstName_Lbl = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_SurName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_Phone = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_SignUpHeader = new System.Windows.Forms.Label();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.label_DOB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName_Lbl
            // 
            this.FirstName_Lbl.AutoSize = true;
            this.FirstName_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FirstName_Lbl.Location = new System.Drawing.Point(43, 95);
            this.FirstName_Lbl.Name = "FirstName_Lbl";
            this.FirstName_Lbl.Size = new System.Drawing.Size(86, 20);
            this.FirstName_Lbl.TabIndex = 0;
            this.FirstName_Lbl.Text = "First Name";
            this.FirstName_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FirstName_Lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(148, 95);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(166, 20);
            this.textBox_FirstName.TabIndex = 1;
            this.textBox_FirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label_SurName
            // 
            this.label_SurName.AutoSize = true;
            this.label_SurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_SurName.Location = new System.Drawing.Point(49, 136);
            this.label_SurName.Name = "label_SurName";
            this.label_SurName.Size = new System.Drawing.Size(80, 20);
            this.label_SurName.TabIndex = 2;
            this.label_SurName.Text = "Sur Name";
            this.label_SurName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_SurName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Phone.Location = new System.Drawing.Point(74, 217);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(55, 20);
            this.label_Phone.TabIndex = 4;
            this.label_Phone.Text = "Phone";
            this.label_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Email.Location = new System.Drawing.Point(81, 176);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(48, 20);
            this.label_Email.TabIndex = 6;
            this.label_Email.Text = "Email";
            this.label_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_SignUpHeader
            // 
            this.label_SignUpHeader.AutoSize = true;
            this.label_SignUpHeader.Location = new System.Drawing.Point(47, 34);
            this.label_SignUpHeader.Name = "label_SignUpHeader";
            this.label_SignUpHeader.Size = new System.Drawing.Size(204, 13);
            this.label_SignUpHeader.TabIndex = 8;
            this.label_SignUpHeader.Text = "Please enter your details and press submit";
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Submit.Location = new System.Drawing.Point(356, 320);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(122, 42);
            this.Btn_Submit.TabIndex = 9;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Cancel.Location = new System.Drawing.Point(484, 320);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(122, 42);
            this.Btn_Cancel.TabIndex = 10;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // label_DOB
            // 
            this.label_DOB.AutoSize = true;
            this.label_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_DOB.Location = new System.Drawing.Point(30, 255);
            this.label_DOB.Name = "label_DOB";
            this.label_DOB.Size = new System.Drawing.Size(99, 20);
            this.label_DOB.TabIndex = 11;
            this.label_DOB.Text = "Date of Birth";
            this.label_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_DOB.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 374);
            this.Controls.Add(this.label_DOB);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.label_SignUpHeader);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_SurName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_SignUpHeader;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label label_DOB;
    }
}