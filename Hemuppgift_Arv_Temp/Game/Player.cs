using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {
        public string UserId { get; set; }

        public Player(string UserId)
        {
           this.UserId = UserId;
        }

        public abstract int TakePins(Board board);
    }
}