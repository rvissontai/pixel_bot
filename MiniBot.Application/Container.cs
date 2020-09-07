using Autofac;
using MiniBot.Application;
using MiniBot.Domain;

namespace MiniBot.Infra.CrossCutting.IoC
{
    public class ContainerIoC
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterPinvokeDependency();
            builder.RegisterFormsDependency();
            builder.RegisterDomainDependency();

            return builder.Build();
        }
    }
}
