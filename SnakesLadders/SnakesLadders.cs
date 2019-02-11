using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLadders
{
    class SnakesLadders
    {
        GameBoard board=new GameBoard();
        Player Player1 = new Player(0);
        Player Player2 = new Player(0);
        private int currentPlayer = 1;
        private bool victory = false;

        public string play(int die1, int die2)
        {
            if (victory) return "Game over!";
            var player = GetCurrentGlayer();
            player.Position  = board.MoveTo(player, die1+die2);
            if (player.Position == 100)
            {
                victory = true;
                return $"Player {currentPlayer} wins! ";
            }
            var result = $"Player {currentPlayer} is on square {player.Position} ";

            if (die1 != die2)
            {
                currentPlayer = currentPlayer== 1 ?  2 :  1;
            }

            return result;
        }

        Player GetCurrentGlayer()
        {
            return currentPlayer == 1 ? Player2 : Player1;
        }

    }
}
