using System;
namespace _02_InyecDependUnity
{
    public interface IGame
    {
        string Name { get; }
        int CurrentPlayers { get; }
        int MinPlayers { get; }
        int MaxPlayers { get; }

        void AddPlayer();
        void RemovePlayer();
        void Play();
        string Result();
    }
}
