using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class SmartComputer : Player
    {
        public SmartComputer(string name) : base(name)
        {
        }

        public override int TakePins(Board board)
        {

            int pins;
            if (board.noPins > 3)
            {
                pins = (board.noPins - 1) % 3 == 0 ? 1 : 2; 
            }

            else
            {
                pins = board.noPins == 3 ? 2 : 1;
            }

            board.TakePins(pins);
            return pins;
        }
    }
}

