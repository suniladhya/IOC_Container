using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace AutoFac_TimCorey
{
    class Program
    {
        static void Main(string[] args)
        {
            //var container = ContainerConfig.Configure();



            //using (var scope = container.BeginLifetimeScope())
            //{
            //    var app = scope.Resolve<IApplication>();
            //    app.Run();
            //}

            var unityContainer = 
                UnityContainerConfig.Configure();

            var app = unityContainer.Resolve<IUnityApplication>();

            app.Run();

            Console.WriteLine("In Main");
            Console.ReadLine();
        }
    }
}
