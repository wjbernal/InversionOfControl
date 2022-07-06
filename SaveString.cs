using System;

namespace InversionOfControl
{
    public class SaveString
    {
        IDatabase _db { get; set; }

        public SaveString(IDatabase db)
        {
            _db = db;
        }

        public void CommitIntoDb(string str) 
        {
            _db.SaveIntoDb(str);
        }
    }
}