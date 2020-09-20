using Itech.CLI;
using Itech.Common.FolderInfo;
using Itech.Common.FolderInfo.IO;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CLI
{
    class Program
    {
        private static IServiceProvider serviceProvider;
        static void Main(string[] args)
        {
            RegisterServices();
            IServiceScope scope = serviceProvider.CreateScope();
            scope.ServiceProvider.GetRequiredService<CLIApp>().Execute();
            DisposeServices();
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IFolderDetailReader, FolderDetailReader>();
            services.AddSingleton<CLIApp>();

            serviceProvider = services.BuildServiceProvider(true);
        }

        private static void DisposeServices()
        {
            if (serviceProvider == null)
            {
                return;
            }
            if (serviceProvider is IDisposable)
            {
                ((IDisposable)serviceProvider).Dispose();
            }
        }
    }
}
