namespace BankLogin_App
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.accountstableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new BankLogin_App.BankDataSet();
            this.accounts_tableTableAdapter = new BankLogin_App.BankDataSetTableAdapters.accounts_tableTableAdapter();
            this.labelNameProperty = new System.Windows.Forms.Label();
            this.labelNameValue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBalanceProperty = new System.Windows.Forms.Label();
            this.labelBalanceValue = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.bankDataSet1 = new BankLogin_App.BankDataSet1();
            this.bankDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accountstableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountstableBindingSource
            // 
            this.accountstableBindingSource.DataMember = "accounts_table";
            this.accountstableBindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accounts_tableTableAdapter
            // 
            this.accounts_tableTableAdapter.ClearBeforeFill = true;
            // 
            // labelNameProperty
            // 
            this.labelNameProperty.AutoSize = true;
            this.labelNameProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelNameProperty.Location = new System.Drawing.Point(83, 182);
            this.labelNameProperty.Name = "labelNameProperty";
            this.labelNameProperty.Size = new System.Drawing.Size(53, 20);
            this.labelNameProperty.TabIndex = 3;
            this.labelNameProperty.Text = "Name";
            this.labelNameProperty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNameValue
            // 
            this.labelNameValue.AutoSize = true;
            this.labelNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelNameValue.Location = new System.Drawing.Point(179, 182);
            this.labelNameValue.Name = "labelNameValue";
            this.labelNameValue.Size = new System.Drawing.Size(0, 20);
            this.labelNameValue.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::BankLogin_App.Properties.Resources.blank_user1;
            this.pictureBox1.Location = new System.Drawing.Point(108, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelBalanceProperty
            // 
            this.labelBalanceProperty.AutoSize = true;
            this.labelBalanceProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelBalanceProperty.Location = new System.Drawing.Point(83, 226);
            this.labelBalanceProperty.Name = "labelBalanceProperty";
            this.labelBalanceProperty.Size = new System.Drawing.Size(70, 20);
            this.labelBalanceProperty.TabIndex = 6;
            this.labelBalanceProperty.Text = "Balance";
            this.labelBalanceProperty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBalanceValue
            // 
            this.labelBalanceValue.AutoSize = true;
            this.labelBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelBalanceValue.Location = new System.Drawing.Point(179, 226);
            this.labelBalanceValue.Name = "labelBalanceValue";
            this.labelBalanceValue.Size = new System.Drawing.Size(0, 20);
            this.labelBalanceValue.TabIndex = 7;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(84, 304);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRequest
            // 
            this.buttonRequest.Location = new System.Drawing.Point(179, 304);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(75, 23);
            this.buttonRequest.TabIndex = 9;
            this.buttonRequest.Text = "Request";
            this.buttonRequest.UseVisualStyleBackColor = true;
            // 
            // bankDataSet1
            // 
            this.bankDataSet1.DataSetName = "BankDataSet1";
            this.bankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankDataSet1BindingSource
            // 
            this.bankDataSet1BindingSource.DataSource = this.bankDataSet1;
            this.bankDataSet1BindingSource.Position = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 397);
            this.Controls.Add(this.buttonRequest);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelBalanceValue);
            this.Controls.Add(this.labelBalanceProperty);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNameValue);
            this.Controls.Add(this.labelNameProperty);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountstableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource accountstableBindingSource;
        private BankDataSetTableAdapters.accounts_tableTableAdapter accounts_tableTableAdapter;
        private System.Windows.Forms.Label labelNameProperty;
        private System.Windows.Forms.Label labelNameValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBalanceProperty;
        private System.Windows.Forms.Label labelBalanceValue;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.BindingSource bankDataSet1BindingSource;
        private BankDataSet1 bankDataSet1;
    }
}