using Autofac;

namespace _02_InyecDependAutoFact
{
    public class ProfesorModulo : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProfesorRepositorio>().As<IProfesorRepositorio>();
            base.Load(builder);
        }
    }
}
