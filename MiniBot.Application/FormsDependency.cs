using Autofac;

namespace MiniBot.Application
{
    public static class FormsDependency
    {
        public static void RegisterFormsDependency(this ContainerBuilder builder)
        {
            builder.RegisterType<FormPrincipal>().AsSelf();
        }
    }
}
