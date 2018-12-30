using System;

namespace DemoLibrary.Utilities
{
    public class Logger:ILogger
    {
        public void Log(string v)
        {
            Console.WriteLine($"Logging: {v}");
        }
    }
}