using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABCSystem
{
    public partial class AmountTransferOnAccountID : Form
    {
        int amt;
        public AmountTransferOnAccountID(int ID)
        {
            InitializeComponent();
            amt = ID;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //
            if (UserRecord.Transfer(AccountIDInput.Text, amt))
            {
                //
                UserRecord.Current.getBankBalance -= amt;
                //
                MessageBox.Show("Successfully Processed!", "Confirm");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry, Account Not Found!!", "Error");
                this.Close();
            }
        }
    }
}
