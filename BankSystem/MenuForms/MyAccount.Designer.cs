//Author: Saad

using System.Drawing;
namespace ABCSystem
{
    partial class MyAccount
    {

        private System.ComponentModel.IContainer components = null;
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccount));
            this.NameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Ag = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.PhNumber = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.Am = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.MyAccountOptionsStack = new System.Windows.Forms.TableLayoutPanel();
            this.DepositButton = new System.Windows.Forms.Button();
            this.WithdrawalButton = new System.Windows.Forms.Button();
            this.TransferButton = new System.Windows.Forms.Button();
            this.PayBillsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.MyAccountOptionsStack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(28, 57);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(302, 23);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.94595F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.05405F));
            this.tableLayoutPanel1.Controls.Add(this.Ag, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AgeLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LocationLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PhNumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ContactLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Am, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BalanceLabel, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 85);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 214);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Ag
            // 
            this.Ag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ag.AutoSize = true;
            this.Ag.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ag.Location = new System.Drawing.Point(4, 22);
            this.Ag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ag.Name = "Ag";
            this.Ag.Size = new System.Drawing.Size(44, 24);
            this.Ag.TabIndex = 2;
            this.Ag.Text = "Age";
            // 
            // AgeLabel
            // 
            this.AgeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(182, 22);
            this.AgeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(72, 24);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "label1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Country";
            // 
            // LocationLabel
            // 
            this.LocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(182, 74);
            this.LocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(72, 24);
            this.LocationLabel.TabIndex = 4;
            this.LocationLabel.Text = "label1";
            // 
            // PhNumber
            // 
            this.PhNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PhNumber.AutoSize = true;
            this.PhNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhNumber.Location = new System.Drawing.Point(4, 135);
            this.PhNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhNumber.Name = "PhNumber";
            this.PhNumber.Size = new System.Drawing.Size(141, 24);
            this.PhNumber.TabIndex = 4;
            this.PhNumber.Text = "Phone Number";
            // 
            // ContactLabel
            // 
            this.ContactLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactLabel.Location = new System.Drawing.Point(182, 135);
            this.ContactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(72, 24);
            this.ContactLabel.TabIndex = 9;
            this.ContactLabel.Text = "label1";
            // 
            // Am
            // 
            this.Am.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Am.AutoSize = true;
            this.Am.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Am.Location = new System.Drawing.Point(4, 190);
            this.Am.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Am.Name = "Am";
            this.Am.Size = new System.Drawing.Size(80, 24);
            this.Am.TabIndex = 9;
            this.Am.Text = "Balance";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(182, 190);
            this.BalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(72, 24);
            this.BalanceLabel.TabIndex = 10;
            this.BalanceLabel.Text = "label1";
            // 
            // AccountLabel
            // 
            this.AccountLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLabel.Location = new System.Drawing.Point(14, 14);
            this.AccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(401, 23);
            this.AccountLabel.TabIndex = 9;
            this.AccountLabel.Text = "label1";
            // 
            // MyAccountOptionsStack
            // 
            this.MyAccountOptionsStack.ColumnCount = 1;
            this.MyAccountOptionsStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MyAccountOptionsStack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.MyAccountOptionsStack.Controls.Add(this.DepositButton, 0, 0);
            this.MyAccountOptionsStack.Controls.Add(this.WithdrawalButton, 0, 1);
            this.MyAccountOptionsStack.Controls.Add(this.TransferButton, 0, 2);
            this.MyAccountOptionsStack.Controls.Add(this.PayBillsButton, 0, 3);
            this.MyAccountOptionsStack.Location = new System.Drawing.Point(436, 13);
            this.MyAccountOptionsStack.Margin = new System.Windows.Forms.Padding(4);
            this.MyAccountOptionsStack.Name = "MyAccountOptionsStack";
            this.MyAccountOptionsStack.RowCount = 4;
            this.MyAccountOptionsStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MyAccountOptionsStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MyAccountOptionsStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MyAccountOptionsStack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MyAccountOptionsStack.Size = new System.Drawing.Size(233, 251);
            this.MyAccountOptionsStack.TabIndex = 10;
            // 
            // DepositButton
            // 
            this.DepositButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DepositButton.Location = new System.Drawing.Point(30, 7);
            this.DepositButton.Margin = new System.Windows.Forms.Padding(4);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(173, 47);
            this.DepositButton.TabIndex = 0;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // WithdrawalButton
            // 
            this.WithdrawalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WithdrawalButton.Location = new System.Drawing.Point(30, 69);
            this.WithdrawalButton.Margin = new System.Windows.Forms.Padding(4);
            this.WithdrawalButton.Name = "WithdrawalButton";
            this.WithdrawalButton.Size = new System.Drawing.Size(173, 47);
            this.WithdrawalButton.TabIndex = 1;
            this.WithdrawalButton.Text = "Withdrawal";
            this.WithdrawalButton.UseVisualStyleBackColor = true;
            this.WithdrawalButton.Click += new System.EventHandler(this.WithdrawalButton_Click);
            // 
            // TransferButton
            // 
            this.TransferButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TransferButton.Location = new System.Drawing.Point(30, 131);
            this.TransferButton.Margin = new System.Windows.Forms.Padding(4);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(173, 47);
            this.TransferButton.TabIndex = 2;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // PayBillsButton
            // 
            this.PayBillsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PayBillsButton.Location = new System.Drawing.Point(30, 195);
            this.PayBillsButton.Margin = new System.Windows.Forms.Padding(4);
            this.PayBillsButton.Name = "PayBillsButton";
            this.PayBillsButton.Size = new System.Drawing.Size(173, 47);
            this.PayBillsButton.TabIndex = 3;
            this.PayBillsButton.Text = "Pay Bills";
            this.PayBillsButton.UseVisualStyleBackColor = true;
            this.PayBillsButton.Click += new System.EventHandler(this.PayBillsButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Value});
            this.dataGridView1.Location = new System.Drawing.Point(6, 327);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(663, 283);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Log";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 310;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Value.Width = 125;
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.Location = new System.Drawing.Point(466, 272);
            this.DeleteAccountButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(173, 42);
            this.DeleteAccountButton.TabIndex = 12;
            this.DeleteAccountButton.Text = "Delete Account";
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ABCSystem.Properties.Resources.BackgroundColour;
            this.ClientSize = new System.Drawing.Size(671, 625);
            this.Controls.Add(this.DeleteAccountButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MyAccountOptionsStack);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MyAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Account";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MyAccountOptionsStack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
//ABC Banking Group
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Am;
        private System.Windows.Forms.Label Ag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PhNumber;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.TableLayoutPanel MyAccountOptionsStack;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Button WithdrawalButton;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Button PayBillsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Button DeleteAccountButton;



    }
}
//Author: Saad