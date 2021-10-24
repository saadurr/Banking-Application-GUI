//ABC Banking Group
using System;
using System.Windows.Forms;

namespace ABCSystem
{
    public partial class PayBillsMenu : Form
    {
        public PayBillsMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            //
            //
            //
            //
            if (PaymentServiceComboBox.SelectedIndex==-1)
            {
                MessageBox.Show("Please Select A Service", "Error");
            }
            //
            //
            //
            //

            else
            {
                (new paymentTransactionAmount(PaymentServiceComboBox.Text)).ShowDialog();
                this.Close();
            }
        }
    }
}
