using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using Autofac;
using static System.Net.Mime.MediaTypeNames;

namespace WinTail
{
    #region Program
    [ExcludeFromCodeCoverage]
    static class Program
    {
        private static Autofac.IContainer CompositionRoot()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>();
            builder.RegisterType<SystemConsole>().As<IConsoleReader>().As<IConsoleWriter>();
            return builder.Build();
            // blocks the main thread from exiting until the actor system is shut down
        }
        static void Main(string[] args)  //Main entry point
        {
            CompositionRoot().Resolve<Application>().Run(args);
        }
    }
    #endregion
}
