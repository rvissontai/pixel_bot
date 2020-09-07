using Autofac;
using MiniBot.Infra.CrossCutting.Pinvoke;
using MiniBot.Infra.CrossCutting.Pinvoke.Wrappers;

namespace MiniBot.Infra.CrossCutting.IoC
{
    public static class PinvokeDepency
    {
        public static void RegisterPinvokeDependency(this ContainerBuilder builder)
        {
            builder.RegisterType<Gdi32Wrapper>().As<IGdi32Wrapper>();
            builder.RegisterType<User32Wrapper>().As<IUser32Wrapper>();
        }
    }
}
