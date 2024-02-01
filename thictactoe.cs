using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4___TicTacToe___Group_3_6
{
    class ThicTacToe()
    {
        public void PrintBoard(string[] board)
        {
            Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
        }

        public bool CheckForWinner(string[] board, int player)
        {
            if ((board[0] == board[1] && board[1] == board[2]) ||
                (board[3] == board[4] && board[4] == board[5]) ||
                (board[6] == board[7] && board[7] == board[8]) ||
                (board[0] == board[3] && board[3] == board[6]) ||
                (board[1] == board[4] && board[4] == board[7]) ||
                (board[2] == board[5] && board[5] == board[8]) ||
                (board[0] == board[4] && board[4] == board[8]) ||
                (board[2] == board[4] && board[4] == board[6]))
            {
                Console.WriteLine($"Player {player} WINS!");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckForTie(string[] board, int player)
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] != "X" && board[i] != "O")
                {
                    return false;
                }
                
            }
            if (!CheckForWinner(board, player))
            {
                Console.WriteLine("It's a TIE!");
                return true;
            }else { return false; }

            
        }
    }
}