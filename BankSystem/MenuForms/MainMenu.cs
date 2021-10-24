//Author: Saad
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ABCSystem
{
    public partial class MainMenu : Form
    {
        //Author: Saad
        public MainMenu()
        {
            
            InitializeComponent();
            string Replay = UserRecord.OpenStreams();
            if (Replay != "Opened")
            {
                      MessageBox.Show(Replay, "Cannot Read External File",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                      this.Dispose();
            }
            Replay = UserAccountRecord.OpenStreams();
            if (Replay != "Opened")
            {
                MessageBox.Show(Replay, "Cannot Read External File",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }
        //Author: Saad
        private void Main_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.FromArgb(0, 88, 44, 55);
            tableLayoutPanel2.BackColor = Color.FromArgb(0, 88, 44, 55);
            label1.BackColor = Color.FromArgb(0, 88, 44, 55);
            label2.BackColor = Color.FromArgb(0, 88, 44, 55);
            EmLog.Text = "Saad@Admin";
            PassLog.Text = "00000";
            PassLog.PasswordChar = '*';
        }
        //Author: Saad
        private void NewAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new CreateNewMenu()).ShowDialog();
            this.Show();
        }
        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            ("ABC Banking Group Application Created By:\nSaad",
              "About Us");
        }
        //Author: Saad

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Author: Saad
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Feedback()).ShowDialog();
            this.Show();
        }

        //Author: Saad
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (EmLog.Text.Length < 1 || PassLog.Text.Length < 1)
            {
                MessageBox.Show("Please Enter Account ID and Password!", "Error");
            }
            else
            {
                if (UserRecord.LogInChecker(EmLog.Text.ToLower(), PassLog.Text))
                {
                    this.Hide();
                    (new MyAccount()).ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Account ID or Password! ", "Error");
                }

            }
        }
        //Author: Saad
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do You Want To Exit?", "Exit",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (!UserRecord.CloseStreams() || !UserAccountRecord.CloseStreams())
                {
                    MessageBox.Show("External File Could Not Be Closed Successfully!", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
//Author: Saad