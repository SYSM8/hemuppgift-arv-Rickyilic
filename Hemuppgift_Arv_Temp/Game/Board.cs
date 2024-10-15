using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        public int noPins { get; set; }

        public Board(int startingPins)
        {
            noPins = startingPins;
        }

        public bool TakePins(int numberOfPins)
        {
            if (numberOfPins < 1 || numberOfPins > 2 || numberOfPins > noPins)
            {
                return false;
            }

            noPins -= numberOfPins;
            return true;
        }

        public bool GetNoPins()
        {
            return noPins == 0;
        }
    }
}
