using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{ 
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        public override int TakePins(Board board)
        {
            int pins;
            do
            {
                Console.Write($"{Name}, hur många pins vill du ta, 1 eller 2? ");
            } while (!int.TryParse(Console.ReadLine(), out pins) 
            || pins < 1 || pins > 2 || !board.TakePins(pins));

            return pins;
        }
    }
}
