using System;

namespace InversionOfControl
{
    public class MongoDbDatabase : IDatabase
    {
        public MongoDbDatabase()
        {
            
        }

        public void SaveIntoDb(String str)
        {
            Console.WriteLine(str + " Saved Into MongoDb database...");
        }        
    }
}