using Hemuppgift_Arv_Temp.Game;
using System.Numerics;

namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            Board board = new Board(10); 
            Player player1 = new HumanPlayer("Spelare 1");
            Player player2 = new ComputerPlayer("Datorn");

            Player currentPlayer = player1;

            while (!board.GetNoPins())
            {
                Console.WriteLine($"Just nu finns det {board.noPins} stickor kvar.");
                int pinsTaken = currentPlayer.TakePins(board);

                if (pinsTaken > 0)
                {
                    Console.WriteLine($"{currentPlayer.UserId} har tagit {pinsTaken}  antal stickor.");
                }

                if (board.GetNoPins())
                {
                    Console.WriteLine($"Vinnaren är {currentPlayer.UserId}!");
                    break;
                }

                if (currentPlayer == player1)
                {
                    currentPlayer = player2;
                }
                else
                {
                    currentPlayer = player1;
                }
            }
        }
    }
}

