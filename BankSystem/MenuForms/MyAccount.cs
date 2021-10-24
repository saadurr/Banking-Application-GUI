//Author: Saad

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ABCSystem
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
            MyAccountOptionsStack.BackColor = Color.FromArgb(0, 88, 44, 55);
            tableLayoutPanel1.BackColor = Color.FromArgb(0, 88, 44, 55);
            AccountLabel.BackColor = Color.FromArgb(0, 88, 44, 55);
            NameLabel.BackColor = Color.FromArgb(0, 88, 44, 55);
            
            AccountLabel.Text = UserRecord.Current.getAccountID;
            NameLabel.Text = UserRecord.Current.getFirstName + " " + UserRecord.Current.getLastName;
            AgeLabel.Text = UserRecord.Current.getAge;
            LocationLabel.Text = UserRecord.Current.getCountry;
            ContactLabel.Text = UserRecord.Current.getPhone;
            BalanceLabel.Text = (UserRecord.Current.getBankBalance).ToString() + "$";
            TableIntial();
        }
        public void TableIntial()
        {
            UserAccountRecord.GetLogs(dataGridView1);   
        }
        private void DepositButton_Click(object sender, EventArgs e)
        {
            (new paymentTransactionAmount("Deposit")).ShowDialog();
            string Temp = (UserRecord.Current.getBankBalance).ToString() + "$";
            if ( Temp!= BalanceLabel.Text)
            {
                dataGridView1.Rows.Add("Deposited To Account : ",paymentTransactionAmount.amountVal.ToString()+"$");
                UserAccountRecord.AddLog("Deposited To Account : ", paymentTransactionAmount.amountVal.ToString() + "$");
                BalanceLabel.Text = Temp;
                UserRecord.UpdateAccount();
            }
        }

        private void WithdrawalButton_Click(object sender, EventArgs e)
        {
            (new paymentTransactionAmount("Withdrawal")).ShowDialog();
            string Temp = (UserRecord.Current.getBankBalance).ToString() + "$";
            if (Temp != BalanceLabel.Text)
            {
                dataGridView1.Rows.Add("Amount Withdrawal From Account : ", paymentTransactionAmount.amountVal.ToString() + "$");
                //
                //Add Log
                UserAccountRecord.AddLog("Withdrawal From Account : ", paymentTransactionAmount.amountVal.ToString() + "$");
                BalanceLabel.Text = Temp;
                UserRecord.UpdateAccount();
            }
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            (new paymentTransactionAmount("Transfer")).ShowDialog();
            string Temp = (UserRecord.Current.getBankBalance).ToString() + "$";
            if (Temp != BalanceLabel.Text)
            {
                dataGridView1.Rows.Add("Transfer To Another The Account : ", paymentTransactionAmount.amountVal.ToString() + "$");
                UserAccountRecord.AddLog("Transfer To Another The Account : ", paymentTransactionAmount.amountVal.ToString() + "$");
                BalanceLabel.Text = Temp;
                UserRecord.UpdateAccount();
            }
        }

        private void PayBillsButton_Click(object sender, EventArgs e)
        {
            (new PayBillsMenu()).ShowDialog();
            string Temp = (UserRecord.Current.getBankBalance).ToString() + "$";
            if (Temp != BalanceLabel.Text)
            {
                dataGridView1.Rows.Add("Payment For " + paymentTransactionAmount.paymentPay + " : ", paymentTransactionAmount.amountVal.ToString() + "$");
                UserAccountRecord.AddLog("Payment For " + paymentTransactionAmount.paymentPay + " : ", paymentTransactionAmount.amountVal.ToString() + "$");
                BalanceLabel.Text = Temp;
                UserRecord.UpdateAccount();

            }
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Delete Your ABC Banking Account?", "Confirmation", //
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // //
            {
                UserRecord.DeleteAccount(); // Delete Account Function
                this.Close(); //Close Window
            }
        }
    }
}
