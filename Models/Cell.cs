using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimisedTicTacToe.Exceptions;
using OptimisedTicTacToe.Type;

namespace OptimisedTicTacToe.Models
{
    internal class Cell
    {
        public MarkType mark { get; set; } = MarkType.Empty;

        public Cell() {

            mark = MarkType.Empty;
        }

        public bool IsEmpty()
        {
            if(mark==MarkType.Empty)
                return true;
            return false;
        }

        public MarkType getMark()
        {
            return mark;
        }

        public void setMark(MarkType mark)
        {
            if (this.mark == MarkType.X || this.mark == MarkType.O)
                throw new CellAlreadyMarkedException("Cell is already Marked");
            this.mark = mark;
            
        }
    }
}
