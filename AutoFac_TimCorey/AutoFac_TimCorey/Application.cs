using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac_TimCorey
{
    public class Application : IApplication
    {
        IBusinessLogic _busunesslogic;

        public Application(IBusinessLogic businessLogic)
        {
            _busunesslogic = businessLogic;
        }

        public void Run()
        {
            _busunesslogic.ProcessData();
        }
    }
}
