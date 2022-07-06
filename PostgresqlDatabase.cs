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
    }
}