//Author: Saad

namespace ABCSystem
{
    class User
    {
        //initial amount is zero
        protected int cBankAmount = 0;

        //all members of class user (client)
        protected readonly string cFirstName, cLastName, cAge, cAccountNumber, cLocationCountry, cLoginPassword,cNumberPhone;
        
        //constructor for class user
        public User(string accountID,string pswd, string fName, string lName, string location,
                      string Age,string contactNumber,bool premiumMember)
        {
            this.cFirstName = fName;
            this.cLastName = lName;
            this.cAccountNumber = accountID;
            this.cLocationCountry = location;
            this.cAge = Age;
            this.cLoginPassword = pswd;
            this.cNumberPhone = contactNumber;
            if (premiumMember) cBankAmount = 100;
        }
        public User(string accountID,string loginPwd,string FirstName, string LastName, string Country,
                      string Age, string contactNumber,int Amount)
        {
            //firstname
            this.cFirstName = FirstName;
            //last name
            this.cLastName = LastName;
            //accountid for login
            this.cAccountNumber = accountID;
            //login password for login
            this.cLoginPassword = loginPwd;
            //country name of user
            this.cLocationCountry = Country;
            //age for user
            this.cAge = Age;
            //contact number for user
            this.cNumberPhone = contactNumber;
            //amount for user
            this.cBankAmount = Amount;
        }
        public string getFirstName
        {
            get { return cFirstName; }
        }
        public string getLastName
        {
            get { return cLastName; }
        }
        public string getAccountID
        {
            get { return cAccountNumber; }
        }
        public string getCountry
        {
            get { return cLocationCountry; }
        }
        public string getAge
        {
            get { return cAge; }
        }
        public string getLoginPassword
        {
            get { return cLoginPassword; }
        }
        public string getPhone
        {
            get { return cNumberPhone; }
        }
        public int getBankBalance
        {
            set { cBankAmount = value; }
            get { return cBankAmount; }
        }
    }
}
