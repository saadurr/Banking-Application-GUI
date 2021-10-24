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
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feedback has been successfully sent!", "Thank You!");
            this.Close();
        }
    }
}
