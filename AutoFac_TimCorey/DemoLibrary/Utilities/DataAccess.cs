using System;

namespace DemoLibrary.Utilities
{
    public class DataAccess : DemoLibrary.Utilities.IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading Data");

        }

        public void SaveData(string v)
        {
            Console.WriteLine("Saving Data: "+v);
        }
    }
}