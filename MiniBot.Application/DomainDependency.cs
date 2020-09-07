using Autofac;
using MiniBot.Core;
using MiniBot.Domain;

namespace MiniBot.Application
{
    public static class DomainDependency
    {
        public static void RegisterDomainDependency(this ContainerBuilder builder)
        {
            builder.RegisterType<Pixel>().As<IPixel>();
            builder.RegisterType<Mana>().As<IMana>();
        }
    }
}
