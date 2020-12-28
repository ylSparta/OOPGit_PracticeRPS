using System;

namespace RockPaperScissors
{
    public class GameOfRPS: IGameOfRPS
    {
        public GameOfRPS() { }

        public string AGameOfRPS(Object input1, Object input2)
        {
            Rock rock = new Rock();
            Paper paper = new Paper();
            Scissors scissors = new Scissors();

            if (input1 == rock && input2 == paper)
            {
                return $"Paper beats Rock";
            }
            if (input1 == rock && input2 == scissors)
            {
                return $"Rock beats Scissors";
            }
            if (input1 == scissors && input2 == paper)
            {
                return $"Scissors beats Paper";
            }
            else return $"Its a draw!";
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
