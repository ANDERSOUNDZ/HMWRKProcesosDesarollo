using Autofac;

namespace _02_InyecDependAutoFact
{
    public class EstudianteModulo : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EstudianteRepositorio>().As<IEstudianteRepositorio>();
            base.Load(builder);
        }
    }
}
