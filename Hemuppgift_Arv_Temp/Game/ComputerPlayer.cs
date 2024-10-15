using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public class ComputerPlayer : Player
    {
        Random random = new Random();

        public ComputerPlayer(string name) : base(name)
        {
        }


        public override int TakePins(Board board)
        {
            int pins = random.Next(1, 3); 
            board.TakePins(pins);
            return pins;
        }
    }
}
