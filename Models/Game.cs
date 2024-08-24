using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using OptimisedTicTacToe.Exceptions;
using OptimisedTicTacToe.Type;

namespace OptimisedTicTacToe.Models
{
    internal class Game
    {
        Board board;
        ResultType result;
        ResultAnalyzer resultAnalyzer;
        

        public Game(Board b , ResultAnalyzer res) {

            board = b;
            result = ResultType.Progress;
            resultAnalyzer = res;
            
        }
       
        public void playGame(Player player, int loc , MarkType mark,ResultType res)
        {
            if (loc < 0 || loc >= board.cell.Length)
                throw new InvalidMoveException("Invalid Choice Of Insertion");

            Console.WriteLine($"{player.Name}'s Turn");
            board.setCellMark(loc,mark);
            board.DisplayBoard();
            res = resultAnalyzer.AnalyzeResult();
            switch (res)
            {
                case ResultType.Win:
                    Console.WriteLine($"{player.Name} Wins");
                    break;
                case ResultType.Draw:
                    Console.WriteLine("Its a draw");
                    break;
                case ResultType.Progress:
                    Console.WriteLine("Game in Progress");
                    break;
            }

        }

        

        



    }
}
