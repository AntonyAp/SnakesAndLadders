using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLadders
{
    class Squares
    {
        private int _position;
        private int _moveTo = -1;

        public Squares(int position)
        {
            _position = position;
        }

        public Squares(int position,int moveTo)
        {
            _position = position;
            _moveTo = moveTo;
        }

        public int checkPosition(int position)
        {
            return _moveTo == -1 ? position : _moveTo;
        }

    }
}
