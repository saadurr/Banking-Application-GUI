//Author: Saad

using System;
using System.IO;
using System.Windows.Forms;

namespace ABCSystem
{
    class UserAccountRecord
    {
        //file access stream
        static FileStream fstream;
        //reader for binary files
        static BinaryReader breader;
        //writer object for binary files
        static BinaryWriter bwriter;

        //function for accessing stream, opening them.
        public static string OpenStreams()
        {
            //exception handling in case the file does not exist or an error occurs
            try
            {
                //filestream
                fstream = new FileStream("Logs.txt", FileMode.Open, FileAccess.ReadWrite);
                //binary reader for external file
                breader = new BinaryReader(fstream);
                //binary writer for exetrnal file
                bwriter = new BinaryWriter(fstream);
                //return success message once done
                return "Opened";
            }
            catch (Exception ex)
            {
                //if an exception is caught, it will be handled.
                return ex.Message;
            }
        }
        public static void SetAdress(int Address)
        {
            //setting address using filestream's seek function
            fstream.Seek(2 * Address, SeekOrigin.Begin);
        }
        public static void GetLogs(DataGridView dg)
        {
            //read back logs using binary reader
            while (breader.PeekChar() == '|')
            {
                //readchar function
                breader.ReadChar();
                dg.Rows.Add(breader.ReadString(), breader.ReadString());
            }
        }
        
        //add a new record
        public static void AddLog(string s1,string s2)
        {
            //add a  new record
            bwriter.Write('|');
         //write string 1
            bwriter.Write(s1);
            //write string 2
            bwriter.Write(s2);
            //flush
            bwriter.Flush();
        }

        //close streams after done
        public static bool CloseStreams()
        {
            //try catch exception handling
            try
            {
                //binary reader 
                breader.Close();
                //binary writer
                bwriter.Close();
                //filestream
                fstream.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
