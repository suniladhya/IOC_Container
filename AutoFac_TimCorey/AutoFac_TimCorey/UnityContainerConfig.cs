using DemoLibrary;
using DemoLibrary.Utilities;
using System;
using Unity;
using Unity.Lifetime;

namespace AutoFac_TimCorey
{
    public class UnityContainerConfig
    {
        internal static IUnityContainer Configure()
        {
            var Container = new UnityContainer();

            Container.RegisterType<ILogger, Logger>(new ContainerControlledLifetimeManager());
            Container.RegisterType<IDataAccess, DataAccess>(new ContainerControlledLifetimeManager());
            Container.RegisterType<IBusinessLogic, BusinessLogic>(new ContainerControlledLifetimeManager());
            Container.RegisterType<IUnityApplication, UnityApplication>(new ContainerControlledLifetimeManager());

            return Container;
        }

        
    }
    public class UnityApplication : IUnityApplication
    {
        IBusinessLogic _busunesslogic;

        public UnityApplication(IBusinessLogic businessLogic)
        {
            _busunesslogic = businessLogic;
        }

        public void Run()
        {
            _busunesslogic.ProcessData();
        }
    }

    interface IUnityApplication
    {
        void Run();

    }
}