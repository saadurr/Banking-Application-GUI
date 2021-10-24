//Author: Saad

using System;
using System.IO;

namespace ABCSystem
{
    class UserRecord
    {
        static User Cur;
        static int CurPosition;
        static FileStream fStream;
        static BinaryReader binaryReader;
        static BinaryWriter binaryWriter;

        //constructor
        private UserRecord()
        { 
        }

        //open streams to read external file
        public static string OpenStreams()
        {
            try
            {
                //open data file
                fStream = new FileStream("Data.txt", FileMode.Open, FileAccess.ReadWrite);
                //open binary reader stream
                binaryReader = new BinaryReader(fStream);
                //open binary writer stream
                binaryWriter = new BinaryWriter(fStream);
                //succesfully opened
                return "Opened";
            }
            catch (Exception ex)
            {
                //throw exception
                return ex.Message;
            }
        }
        public static void AddUser(User User)
        {
            //get position from hashfunction
            int Position = 100*hashCalculatorFunctionForReader(User.getAccountID.ToLower());
            //seek funciton of filestream
            fStream.Seek(Position, SeekOrigin.Begin);
            /////
            /////
            while (binaryReader.PeekChar() == 'T')
            {
                fStream.Seek(100, SeekOrigin.Current);
            }
            binaryWriter.Write('T');
            //write account id
            binaryWriter.Write(User.getAccountID);
            //write password
            binaryWriter.Write(User.getLoginPassword);
            //write firstname
            binaryWriter.Write(User.getFirstName);
            //write lastname
            binaryWriter.Write(User.getLastName);
            //write country
            binaryWriter.Write(User.getCountry);
            //write  age
            binaryWriter.Write(User.getAge);
            //write phone
            binaryWriter.Write(User.getPhone);
            //write balance
            binaryWriter.Write(User.getBankBalance);
            binaryWriter.Flush();
        }
        public static bool Registered(string Email)
        {
            /////
            /////
            int Position = 100*hashCalculatorFunctionForReader(Email);
            /////
            /////
            fStream.Seek(Position, SeekOrigin.Begin);
            /////
            /////
            while (binaryReader.PeekChar() == 'T')
            {
                binaryReader.ReadChar();
                if (binaryReader.ReadString().ToLower() == Email)
                {
                    return false;
                }
                Position += 100;
                fStream.Seek(Position, SeekOrigin.Begin);
            }
            return true;
            /////
            /////
        }
        public static bool LogInChecker(string Email, string Pass)
        {
            /////
            /////hash function to get position
            int Position = 100*hashCalculatorFunctionForReader(Email);
            fStream.Seek(Position, SeekOrigin.Begin);
            /////
            /////
            while (binaryReader.PeekChar() == 'T')
            {
                /////
                /////
                int Temp = Position;
                binaryReader.ReadChar();
                if (binaryReader.ReadString().ToLower() == Email && binaryReader.ReadString() == Pass)
                {
                    /////
                    /////iterate over users
                    Cur = new User(Email, Pass, binaryReader.ReadString(), binaryReader.ReadString(), binaryReader.ReadString(),
                                    binaryReader.ReadString(), binaryReader.ReadString(), binaryReader.ReadInt32());
                   CurPosition = Position;
                    /////
                    /////
                    UserAccountRecord.SetAdress(Temp);
                    /////
                    /////
                    return true;
                }
                Position += 100;
                fStream.Seek(Position, SeekOrigin.Begin);
            }
            return false;
        }
        public static bool Transfer(string ReceiverAccountID,int TransactionAmount)
        {
            long Temp = fStream.Position;
            /////
            /////
            int Position = 100 * hashCalculatorFunctionForReader(ReceiverAccountID);
            fStream.Seek(Position, SeekOrigin.Begin);
            while (binaryReader.PeekChar() == 'T')
            {
                binaryReader.ReadChar();
                if (binaryReader.ReadString().ToLower() == ReceiverAccountID)
                {
                    binaryReader.ReadString(); binaryReader.ReadString(); binaryReader.ReadString(); binaryReader.ReadString();
                    binaryReader.ReadString(); binaryReader.ReadString(); binaryReader.ReadString();
                    /////
                    /////
                    int RecieverAmount = binaryReader.ReadInt32();
                    /////
                    /////
                    RecieverAmount += TransactionAmount;
                    /////
                    /////
                    binaryWriter.Seek(-4, SeekOrigin.Current);
                    /////
                    /////
                    binaryWriter.Write(RecieverAmount);
                    fStream.Position = Position;
                    return true;
                }
                Position += 100;
                fStream.Seek(Position, SeekOrigin.Begin);
            }
            /////
            /////
            fStream.Position = Position;
            return false;
        }
        public static void UpdateAccount()
        {
            /////
            /////
            binaryWriter.Seek(-4, SeekOrigin.Current);
            /////
            /////
            binaryWriter.Write(Cur.getBankBalance);
            /////
            /////
            binaryWriter.Flush();
            /////
            /////
        }
        public static void DeleteAccount()
        {
            binaryWriter.Seek(CurPosition, SeekOrigin.Begin);
            /////
            /////
            binaryWriter.Write('F');
            /////
            /////
        }
        public static bool CloseStreams()
        {
            try
            {
                binaryReader.Close();
                /////
                /////
                binaryWriter.Close();
                /////
                /////
                fStream.Close();
                /////
                /////
                return true;
            }
            catch 
            {
                return false;
            }
        }
        private static int hashCalculatorFunctionForReader(string Key)
        {
            long index = 0;
            long expo = 1;
            for (int i = 0; i < Key.Length; ++i)
            {
                index += Key[i] * expo;
                expo *= 2;
            }
            index %= 997;
            return (int)index;
        }
        public static User Current { get { return Cur; } }
    }
}