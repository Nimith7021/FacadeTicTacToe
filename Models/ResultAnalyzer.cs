using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using OptimisedTicTacToe.Type;

namespace OptimisedTicTacToe.Models
{
    internal class ResultAnalyzer
    {
        Board board {  get; set; }

        ResultType Result {  get; set; }

        public ResultAnalyzer(Board board)
        {
            this.board = board;
            Result = ResultType.Progress;
        }

        void HorizontalWinCheck()
        {
            if ((board.cell[0].getMark() == board.cell[1].getMark() && board.cell[1].getMark() == board.cell[2].getMark() && board.cell[0].IsEmpty()==false) ||
                (board.cell[3].getMark() == board.cell[4].getMark() && board.cell[4].getMark() == board.cell[5].getMark() && board.cell[4].IsEmpty() == false) ||
                (board.cell[6].getMark() == board.cell[7].getMark() && board.cell[7].getMark() == board.cell[8].getMark() && board.cell[7].IsEmpty() == false))
                Result = ResultType.Win;
            
            else if(board.isBoardFull())
                Result = ResultType.Draw;
        }

        void VerticalWinCheck()
        {
            if ((board.cell[0].getMark() == board.cell[3].getMark() && board.cell[3].getMark() == board.cell[6].getMark() && board.cell[3].IsEmpty() == false) ||
               (board.cell[1].getMark() == board.cell[4].getMark() && board.cell[4].getMark() == board.cell[7].getMark() && board.cell[4].IsEmpty() == false)  ||
               (board.cell[2].getMark() == board.cell[5].getMark() && board.cell[5].getMark() == board.cell[8].getMark() && board.cell[5].IsEmpty() == false))
                 Result = ResultType.Win;


          
            else if (board.isBoardFull())
                Result = ResultType.Draw;
        }

        void DiagonalWinCheck()
        {
            if ((board.cell[0].getMark() == board.cell[4].getMark() && board.cell[4].getMark() == board.cell[8].getMark() && board.cell[4].IsEmpty() == false) ||
               (board.cell[2].getMark() == board.cell[4].getMark() && board.cell[4].getMark() == board.cell[6].getMark() && board.cell[4].IsEmpty() == false))
                Result = ResultType.Win;

            else if (Result == ResultType.Win && board.isBoardFull())
                Result = ResultType.Win;

            else if (board.isBoardFull())
                Result = ResultType.Draw;

        }

        public ResultType AnalyzeResult()
        {
            HorizontalWinCheck();
            VerticalWinCheck();
            DiagonalWinCheck();
            return Result;
        }




    }
}
