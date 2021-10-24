using System;
using System.Windows.Forms;

//Author: Saad
namespace ABCSystem
{
    public partial class CreateNewMenu : Form
    {
        public CreateNewMenu()
        {
            InitializeComponent();
            FieldPassword.PasswordChar = '*';
        }
        private void CreateSubButton_Click(object sender, EventArgs e)
        {
            //create a
            if (  CharsChecker(FieldFirstName.Text) && CharsChecker(FieldLastName.Text) &&
                  NumsChecker(FieldContactNumber.Text) &&
                  FieldAccountID.Text.Length > 0 && FieldPassword.Text.Length > 0 && 
                  FieldGeographicLocation.SelectedIndex != -1 && FieldAge.SelectedIndex != -1)
            {
                //see if use ris registered
                if (UserRecord.Registered(FieldAccountID.Text.ToLower()))
                {
                    //create a new instannce
                    User newUser = new User(FieldAccountID.Text, FieldPassword.Text, FieldFirstName.Text, FieldLastName.Text, FieldGeographicLocation.Text,
                                                FieldAge.Text, FieldContactNumber.Text,CheckboxPremiumMember.Checked);
                    //add to record
                    UserRecord.AddUser(newUser);
                    //show message
                    MessageBox.Show("You Are Registered Successfully. Please Login Now!", "Congratulations");
                    this.Close();
                }
                else
                {
                    //show message
                    MessageBox.Show("You Have Already Registered An Account!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Information Not Correct. Please Try Again!","Error");
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            //close
            this.Close();
        }
        private bool CharsChecker(string s1)
        {
            if (s1.Length < 1) return false;
            for (int k = 0; k < s1.Length; ++k)
            {
                if ( !(s1[k] >= 'A' && s1[k] <= 'Z') && !(s1[k] >= 'a' && s1[k] <= 'z') ) return false;
            }
            return true;
        }

        private bool NumsChecker(string s2)
        {
            if (s2.Length < 1) return false;
            for (int j = 0; j < s2.Length; ++j)
            {
                if (  s2[j] < '0' || s2[j] > '9' ) return false;
            }
            return true;
        }
    }
}
