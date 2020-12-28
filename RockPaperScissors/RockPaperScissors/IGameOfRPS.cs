using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    public interface IGameOfRPS
    {
        string AGameOfRPS(Rock rock, Scissors scissors);
        string AGameOfRPS(Rock rock, Paper paper);
        string AGameOfRPS(Paper paper, Scissors scissors);

    }
}
