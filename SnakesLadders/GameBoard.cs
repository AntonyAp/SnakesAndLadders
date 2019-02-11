using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLadders
{
    class GameBoard
    {
        private Squares [] squares=new Squares[100];

        public GameBoard()
        {
            Setup();
        }

        void Setup()
        {
            for (int i = 0; i < 100; i++)
                squares[i] = new Squares(i);

            squares[2] = new Squares(2, 38);
            squares[7] = new Squares(7, 14);
            squares[8] = new Squares(8, 31);
            squares[15] = new Squares(15, 26);
            squares[16] = new Squares(16, 6);
            squares[21] = new Squares(21, 42);
            squares[28] = new Squares(28, 84);
            squares[36] = new Squares(36, 44);
            squares[46] = new Squares(46, 25);
            squares[49] = new Squares(49, 11);
            squares[51] = new Squares(51, 67);
            squares[62] = new Squares(62, 19);
            squares[64] = new Squares(64, 60);
            squares[71] = new Squares(71, 91);
            squares[74] = new Squares(74, 53);
            squares[78] = new Squares(78, 98);
            squares[87] = new Squares(87, 94);
            squares[89] = new Squares(89, 68);
            squares[92] = new Squares(92, 88);
            squares[95] = new Squares(95, 75);
            squares[99] = new Squares(99, 80);
        }

        public int MoveTo(Player player,int position)
        {
            int newPosition = player.Position + position;
            if (newPosition > 100) newPosition = (100 - (newPosition - 100));
            newPosition = squares[newPosition].checkPosition(newPosition);
            return newPosition;
        }
    }
   

}

