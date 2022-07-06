using System;
namespace InversionOfControl
{
    public class OracleDatabase : IDatabase
    {
        public OracleDatabase()
        {
            
        }

        public void SaveIntoDb(String str)
        {
            Console.WriteLine(str + " Saved Into Oracle database...");
        }
        
        public string getAddress(int id)
        {
            string a = "";
            return a;            
        }
    }
}
