using System;

namespace RockPaperScissors
{
    public class GameOfRPS: IGameOfRPS
    {
        public GameOfRPS() { }

        public string AGameOfRPS(Rock rock, Scissors scissors)
        {
            return $"Rock beats Scissors";
        }

        public string AGameOfRPS(Rock rock, Paper paper)
        {
            return $"Paper beats Rock";
        }

        public string AGameOfRPS(Paper paper, Scissors scissors)
        {
            return $"Scissors beats Paper";
        }


        static void Main(string[] args)
        {
            GameOfRPS game1 = new GameOfRPS();
            Rock rock = new Rock();
            Paper paper = new Paper();
            Scissors scissors = new Scissors();
            Console.WriteLine(game1.AGameOfRPS(rock, scissors));
        }
    }
}
