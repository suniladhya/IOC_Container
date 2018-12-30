using DemoLibrary.Utilities;
using System;

namespace DemoLibrary
{
    public class BusinessLogic: IBusinessLogic
    {
        ILogger _logger ;
        IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        /// <summary>
        /// logs data
        /// loadData
        /// savedata
        /// logSaved data status
        /// </summary>
        public void ProcessData()
        {

            // = new DataAccess();

            _logger.Log("Starting Process of the Data");
            Console.WriteLine("Processing the Data");

            _dataAccess.LoadData();
            _dataAccess.SaveData("Processing Info!");

            _logger.Log("Finished processing the Data");
        }
    }
}