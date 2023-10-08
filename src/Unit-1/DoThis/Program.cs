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
            return builder.Build();
        }

        static void Main(string[] args)  //Main entry point
        {
            CompositionRoot().Resolve<Application>().Run(args);
        }
    }
    #endregion
}
