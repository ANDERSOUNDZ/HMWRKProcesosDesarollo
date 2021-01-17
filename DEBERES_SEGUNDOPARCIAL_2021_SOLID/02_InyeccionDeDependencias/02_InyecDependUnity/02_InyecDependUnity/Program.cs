using System;
using Unity;

namespace _02_InyecDependUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<IGame, TrivialPursuit>();
            var game = unityContainer.Resolve<IGame>();
            game.AddPlayer();
            game.AddPlayer();
            Console.WriteLine(string.Format("{0} Personas Jugando a {1}", game.CurrentPlayers, game.Name));
            Console.ReadLine();

            var table = unityContainer.Resolve<Table>();
            table.Play();
            Console.WriteLine(table.GameStatus());
            Console.ReadLine();
        }
    }
}
