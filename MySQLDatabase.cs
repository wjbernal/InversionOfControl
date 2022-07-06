using System;

namespace InversionOfControl
{
    public class MySQLDatabase : IDatabase
    {
        public MySQLDatabase()
        {
            
        }

        public void SaveIntoDb(String str)
        {
            Console.WriteLine(str + " Saved Into MySql database...");
        }

        public string getAddress(int id)
        {
            string a = "";
            return a;            
        }
    }
}