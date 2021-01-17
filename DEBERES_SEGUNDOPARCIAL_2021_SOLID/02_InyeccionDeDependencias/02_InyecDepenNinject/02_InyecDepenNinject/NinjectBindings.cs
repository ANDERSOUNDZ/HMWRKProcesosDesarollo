namespace _02_InyecDepenNinject
{
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<ILibrero>().To<Libreria>();
        }
    }
}
