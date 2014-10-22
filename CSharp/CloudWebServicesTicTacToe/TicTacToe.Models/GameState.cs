using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public enum GameState
    {
        WaitingForSecondPlayer = 0,
        TurnX = 1,
        TurnO = 2,
        WonByX =3,
        WonByY =4,
        Draw = 5
    }
}
