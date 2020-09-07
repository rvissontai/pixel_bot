using Autofac;
using MiniBot.Infra.CrossCutting.IoC;
using System;

namespace MiniBot
{
    static class Program
    {
        public static IContainer Container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Container = ContainerIoC.Configure();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(Container.Resolve<FormPrincipal>());
        }
    }
}
