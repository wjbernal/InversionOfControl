using System;

namespace InversionOfControl
{
    public class PostgresqlDatabase : IDatabase
    {
        
        public PostgresqlDatabase()
        {
            
        }

        public void SaveIntoDb(string str)
        {
            Console.WriteLine(str + " Saved into Postgresql database");
        }

        public string getAddress(int id)
        {
            string a = "";
            return a; 
        }

    }
}