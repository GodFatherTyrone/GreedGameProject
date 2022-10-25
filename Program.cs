using System;
using Unit03.Game;

namespace GreedGameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
            return 0;
        }
    }
}