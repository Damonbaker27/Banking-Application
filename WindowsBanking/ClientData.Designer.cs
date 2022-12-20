﻿namespace WindowsBanking
{
    partial class ClientData
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
            System.Windows.Forms.Label clientNumberLabel;
            System.Windows.Forms.Label dateCreatedLabel;
            System.Windows.Forms.Label fullAddressLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label accountNumberLabel;
            System.Windows.Forms.Label balanceLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label descriptionLabel2;
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.clientNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateCreatedLabel1 = new System.Windows.Forms.Label();
            this.fullAddressLabel1 = new System.Windows.Forms.Label();
            this.fullNameLabel1 = new System.Windows.Forms.Label();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.descriptionLabel3 = new System.Windows.Forms.Label();
            this.bankAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountNumberComboBox = new System.Windows.Forms.ComboBox();
            this.balanceLabel1 = new System.Windows.Forms.Label();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.notesLabel1 = new System.Windows.Forms.Label();
            this.llViewDetails = new System.Windows.Forms.LinkLabel();
            this.llProcessTransaction = new System.Windows.Forms.LinkLabel();
            clientNumberLabel = new System.Windows.Forms.Label();
            dateCreatedLabel = new System.Windows.Forms.Label();
            fullAddressLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            accountNumberLabel = new System.Windows.Forms.Label();
            balanceLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            descriptionLabel2 = new System.Windows.Forms.Label();
            this.grpClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.grpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clientNumberLabel
            // 
            clientNumberLabel.AutoSize = true;
            clientNumberLabel.Location = new System.Drawing.Point(55, 40);
            clientNumberLabel.Name = "clientNumberLabel";
            clientNumberLabel.Size = new System.Drawing.Size(76, 13);
            clientNumberLabel.TabIndex = 0;
            clientNumberLabel.Text = "Client Number:";
            // 
            // dateCreatedLabel
            // 
            dateCreatedLabel.AutoSize = true;
            dateCreatedLabel.Location = new System.Drawing.Point(55, 133);
            dateCreatedLabel.Name = "dateCreatedLabel";
            dateCreatedLabel.Size = new System.Drawing.Size(73, 13);
            dateCreatedLabel.TabIndex = 2;
            dateCreatedLabel.Text = "Date Created:";
            // 
            // fullAddressLabel
            // 
            fullAddressLabel.AutoSize = true;
            fullAddressLabel.Location = new System.Drawing.Point(55, 103);
            fullAddressLabel.Name = "fullAddressLabel";
            fullAddressLabel.Size = new System.Drawing.Size(67, 13);
            fullAddressLabel.TabIndex = 4;
            fullAddressLabel.Text = "Full Address:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(55, 70);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 6;
            fullNameLabel.Text = "Full Name:";
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Location = new System.Drawing.Point(55, 40);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new System.Drawing.Size(90, 13);
            accountNumberLabel.TabIndex = 2;
            accountNumberLabel.Text = "Account Number:";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new System.Drawing.Point(381, 40);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(49, 13);
            balanceLabel.TabIndex = 4;
            balanceLabel.Text = "Balance:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(381, 75);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(77, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Account Type:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(55, 110);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 8;
            notesLabel.Text = "Notes:";
            // 
            // descriptionLabel2
            // 
            descriptionLabel2.AutoSize = true;
            descriptionLabel2.Location = new System.Drawing.Point(55, 75);
            descriptionLabel2.Name = "descriptionLabel2";
            descriptionLabel2.Size = new System.Drawing.Size(35, 13);
            descriptionLabel2.TabIndex = 10;
            descriptionLabel2.Text = "State:";
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(clientNumberLabel);
            this.grpClient.Controls.Add(this.clientNumberMaskedTextBox);
            this.grpClient.Controls.Add(dateCreatedLabel);
            this.grpClient.Controls.Add(this.dateCreatedLabel1);
            this.grpClient.Controls.Add(fullAddressLabel);
            this.grpClient.Controls.Add(this.fullAddressLabel1);
            this.grpClient.Controls.Add(fullNameLabel);
            this.grpClient.Controls.Add(this.fullNameLabel1);
            this.grpClient.Location = new System.Drawing.Point(55, 25);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(635, 180);
            this.grpClient.TabIndex = 0;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Client Data";
            // 
            // clientNumberMaskedTextBox
            // 
            this.clientNumberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ClientNumber", true));
            this.clientNumberMaskedTextBox.Location = new System.Drawing.Point(137, 37);
            this.clientNumberMaskedTextBox.Mask = "0000-0000";
            this.clientNumberMaskedTextBox.Name = "clientNumberMaskedTextBox";
            this.clientNumberMaskedTextBox.Size = new System.Drawing.Size(135, 20);
            this.clientNumberMaskedTextBox.TabIndex = 1;
            this.clientNumberMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.clientNumberMaskedTextBox.Leave += new System.EventHandler(this.clientNumberMaskedTextBox_Leave);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BankOfBIT_DB.Models.Client);
            // 
            // dateCreatedLabel1
            // 
            this.dateCreatedLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "DateCreated", true));
            this.dateCreatedLabel1.Location = new System.Drawing.Point(134, 133);
            this.dateCreatedLabel1.Name = "dateCreatedLabel1";
            this.dateCreatedLabel1.Size = new System.Drawing.Size(138, 23);
            this.dateCreatedLabel1.TabIndex = 3;
            // 
            // fullAddressLabel1
            // 
            this.fullAddressLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "FullAddress", true));
            this.fullAddressLabel1.Location = new System.Drawing.Point(134, 103);
            this.fullAddressLabel1.Name = "fullAddressLabel1";
            this.fullAddressLabel1.Size = new System.Drawing.Size(458, 23);
            this.fullAddressLabel1.TabIndex = 5;
            // 
            // fullNameLabel1
            // 
            this.fullNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "FullName", true));
            this.fullNameLabel1.Location = new System.Drawing.Point(134, 70);
            this.fullNameLabel1.Name = "fullNameLabel1";
            this.fullNameLabel1.Size = new System.Drawing.Size(458, 23);
            this.fullNameLabel1.TabIndex = 7;
            // 
            // grpAccount
            // 
            this.grpAccount.Controls.Add(descriptionLabel2);
            this.grpAccount.Controls.Add(this.descriptionLabel3);
            this.grpAccount.Controls.Add(accountNumberLabel);
            this.grpAccount.Controls.Add(this.accountNumberComboBox);
            this.grpAccount.Controls.Add(balanceLabel);
            this.grpAccount.Controls.Add(this.balanceLabel1);
            this.grpAccount.Controls.Add(descriptionLabel);
            this.grpAccount.Controls.Add(this.descriptionLabel1);
            this.grpAccount.Controls.Add(notesLabel);
            this.grpAccount.Controls.Add(this.notesLabel1);
            this.grpAccount.Controls.Add(this.llViewDetails);
            this.grpAccount.Controls.Add(this.llProcessTransaction);
            this.grpAccount.Location = new System.Drawing.Point(55, 218);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(635, 273);
            this.grpAccount.TabIndex = 1;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Bank Account Data";
            // 
            // descriptionLabel3
            // 
            this.descriptionLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "AccountState.Description", true));
            this.descriptionLabel3.Location = new System.Drawing.Point(148, 75);
            this.descriptionLabel3.Name = "descriptionLabel3";
            this.descriptionLabel3.Size = new System.Drawing.Size(124, 23);
            this.descriptionLabel3.TabIndex = 11;
            // 
            // bankAccountBindingSource
            // 
            this.bankAccountBindingSource.DataSource = typeof(BankOfBIT_DB.Models.BankAccount);
            // 
            // accountNumberComboBox
            // 
            this.accountNumberComboBox.DataSource = this.bankAccountBindingSource;
            this.accountNumberComboBox.DisplayMember = "AccountNumber";
            this.accountNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountNumberComboBox.FormattingEnabled = true;
            this.accountNumberComboBox.Location = new System.Drawing.Point(151, 37);
            this.accountNumberComboBox.Name = "accountNumberComboBox";
            this.accountNumberComboBox.Size = new System.Drawing.Size(121, 21);
            this.accountNumberComboBox.TabIndex = 3;
            this.accountNumberComboBox.ValueMember = "BankAccountId";
            // 
            // balanceLabel1
            // 
            this.balanceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "Balance", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.balanceLabel1.Location = new System.Drawing.Point(479, 35);
            this.balanceLabel1.Name = "balanceLabel1";
            this.balanceLabel1.Size = new System.Drawing.Size(113, 23);
            this.balanceLabel1.TabIndex = 5;
            this.balanceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.balanceLabel1.Click += new System.EventHandler(this.balanceLabel1_Click);
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "Description", true));
            this.descriptionLabel1.Location = new System.Drawing.Point(482, 75);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(147, 23);
            this.descriptionLabel1.TabIndex = 7;
            // 
            // notesLabel1
            // 
            this.notesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankAccountBindingSource, "Notes", true));
            this.notesLabel1.Location = new System.Drawing.Point(148, 110);
            this.notesLabel1.Name = "notesLabel1";
            this.notesLabel1.Size = new System.Drawing.Size(444, 81);
            this.notesLabel1.TabIndex = 9;
            // 
            // llViewDetails
            // 
            this.llViewDetails.AutoSize = true;
            this.llViewDetails.Enabled = false;
            this.llViewDetails.Location = new System.Drawing.Point(381, 226);
            this.llViewDetails.Name = "llViewDetails";
            this.llViewDetails.Size = new System.Drawing.Size(65, 13);
            this.llViewDetails.TabIndex = 1;
            this.llViewDetails.TabStop = true;
            this.llViewDetails.Text = "View Details";
            this.llViewDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDetails_LinkClicked);
            // 
            // llProcessTransaction
            // 
            this.llProcessTransaction.AutoSize = true;
            this.llProcessTransaction.Enabled = false;
            this.llProcessTransaction.Location = new System.Drawing.Point(207, 226);
            this.llProcessTransaction.Name = "llProcessTransaction";
            this.llProcessTransaction.Size = new System.Drawing.Size(104, 13);
            this.llProcessTransaction.TabIndex = 0;
            this.llProcessTransaction.TabStop = true;
            this.llProcessTransaction.Text = "Process Transaction";
            this.llProcessTransaction.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProcess_LinkClicked);
            // 
            // ClientData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 546);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.grpClient);
            this.Name = "ClientData";
            this.Text = "ClientData";
            this.Load += new System.EventHandler(this.ClientData_Load);
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.LinkLabel llViewDetails;
        private System.Windows.Forms.LinkLabel llProcessTransaction;
        private System.Windows.Forms.MaskedTextBox clientNumberMaskedTextBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Label dateCreatedLabel1;
        private System.Windows.Forms.Label fullAddressLabel1;
        private System.Windows.Forms.Label fullNameLabel1;
        private System.Windows.Forms.Label descriptionLabel3;
        private System.Windows.Forms.BindingSource bankAccountBindingSource;
        private System.Windows.Forms.ComboBox accountNumberComboBox;
        private System.Windows.Forms.Label balanceLabel1;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label notesLabel1;
    }
}