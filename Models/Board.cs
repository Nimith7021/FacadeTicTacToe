using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimisedTicTacToe.Type;

namespace OptimisedTicTacToe.Models
{
    internal class Board
    {
       public Cell[] cell { get; set; } 

        public Board()
        {
            cell = new Cell[9];
            for (int i = 0; i < cell.Length; i++)
            {
                cell[i] = new Cell(); // Instantiate each Cell object
            }
            foreach (var cell in cell) {
                cell.setMark(MarkType.Empty);
            }
        }

        public bool isBoardFull()
        {
            foreach (var cell in cell)
            {
                if(cell.mark==MarkType.Empty)
                    return false;
            }

            return true;
        }

        public void setCellMark(int loc,MarkType mark)
        {
            if(!isBoardFull())
                cell[loc].setMark(mark);
        }


        public void DisplayBoard()              //Displaying the board is the part of board functionality
                                                         
        {


            Console.WriteLine($"{CorrectSymbolOnBoard(0)}|{CorrectSymbolOnBoard(1)}|{CorrectSymbolOnBoard(2)}\n" +
                $"{CorrectSymbolOnBoard(3)}|{CorrectSymbolOnBoard(4)}|{CorrectSymbolOnBoard(5)}\n" +
                $"{CorrectSymbolOnBoard(6)}|{CorrectSymbolOnBoard(7)}|{CorrectSymbolOnBoard(8)}");
        }

        public string CorrectSymbolOnBoard(int loc)
        {
            string mark;
            if (cell[loc].mark == MarkType.Empty)
                mark = "-";
            else
                mark = cell[loc].mark.ToString();
            return mark;
        }
    }
}
