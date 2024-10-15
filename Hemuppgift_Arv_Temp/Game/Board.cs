using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        public int PinsLeft { get; set; }

        public Board(int startingPins)
        {
            PinsLeft = startingPins;
        }

        public bool TakePins(int numberOfPins)
        {
            if (numberOfPins < 1 || numberOfPins > 2 || numberOfPins > PinsLeft)
            {
                return false;
            }

            PinsLeft -= numberOfPins;
            return true;
        }

        public bool IsGameOver()
        {
            return PinsLeft == 0;
        }
    }
}
