using Autofac;

public class DefaultModule: Autofac.Module
{
    protected override void Load(ContainerBuilder builder)
    {
            builder
                .RegisterType<Service>()
                .SingleInstance();        
    }
}
