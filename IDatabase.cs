using System;
namespace InversionOfControl
{
    public interface IDatabase
    {
        void SaveIntoDb(string str);

        string getAddress(int id);
        


    }
}