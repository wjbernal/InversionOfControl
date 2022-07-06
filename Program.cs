using System;

namespace InversionOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleDatabase theDb = new OracleDatabase ();
            SaveString sstr = new SaveString(theDb);
            sstr.CommitIntoDb("new String");
        }
    }
}
