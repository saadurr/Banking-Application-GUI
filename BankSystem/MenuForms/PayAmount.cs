//Author: Saad
using System;
using System.Windows.Forms;

namespace ABCSystem
{
    public partial class paymentTransactionAmount : Form
    {
        static public long amountVal;
        static public string paymentPay;
        //Author: Saad
        public paymentTransactionAmount(string Title)
        {
            InitializeComponent();
            this.Text = Title;
            this.LabelText.Text = "Please Enter Your " + Title + " Value :";
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //close
            this.Close();
        }
        private bool CheckInput(string inputFromDialog)
        {
            if (inputFromDialog.Length < 1) return false;
            for (int indexForLoop = 0; indexForLoop < inputFromDialog.Length; ++indexForLoop)
            {
                if (!(inputFromDialog[indexForLoop] >= '0' && inputFromDialog[indexForLoop] <= '9')) return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInput(TextInput.Text))
            {
                //
                amountVal = Int64.Parse(TextInput.Text);
                //
                if (this.Text == "Deposit")
                {
                    //
                    UserRecord.Current.getBankBalance += Int32.Parse(TextInput.Text);
                    //
                    //
                    //
                    MessageBox.Show("The Order Has Been Successfully Done!", "Confirm");
                    this.Close();
                }
                else
                {
                    if (UserRecord.Current.getBankBalance < Int32.Parse(TextInput.Text))
                    {
                        ////
                        ///
                        MessageBox.Show("Error: Cannot Process Order Request!", "Error");
                        ////
                    }
                    else
                    {
                        if (this.Text == "Withdrawal")
                        {
                            //
                            UserRecord.Current.getBankBalance -= Int32.Parse(TextInput.Text);
                            ////
                            MessageBox.Show("Success: Your Order Is Done!", "Confirm");
                            ////
                            this.Close();
                        }
                        else if (this.Text == "Transfer")
                        {
                            (new AmountTransferOnAccountID(Int32.Parse(TextInput.Text))).ShowDialog();
                            //
                            this.Close();
                        }
                        else
                        {
                            paymentPay = this.Text;
                            //
                            UserRecord.Current.getBankBalance -= Int32.Parse(TextInput.Text);
                            //
                            MessageBox.Show("Your Order Is Successfully Done!", "Confirm");
                            //
                            this.Close();
                            //
                        }
                    }
                }
            }
            else
            {
                //////////
                ///////////
                ///////////
                MessageBox.Show("Please Enter A Correct Value!", "Error");
                ////////
                /////////
            }
        }
    }
}
