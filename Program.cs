using OptimisedTicTacToe.Exceptions;
using OptimisedTicTacToe.Models;
using OptimisedTicTacToe.Type;

namespace OptimisedTicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ResultType result = ResultType.Progress;
            Player player1 = new Player("Player 1",MarkType.X);
            Player player2 = new Player("Player 2", MarkType.O);
            Board board = new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Game game = new Game(board,resultAnalyzer);
            try
            {
                game.playGame(player1, 1, player1.Mark, result);
                game.playGame(player2, 0, player2.Mark, result);
                game.playGame(player1, 8, player1.Mark, result);
                game.playGame(player2, 5, player2.Mark, result);
                game.playGame(player1, 4, player1.Mark, result);
                game.playGame(player2, 2, player2.Mark, result);
                game.playGame(player1, 6, player1.Mark, result);
                game.playGame(player2, 3, player2.Mark, result);
                game.playGame(player1, 7, player1.Mark, result);

            }
            catch(CellAlreadyMarkedException cme)
            {
                Console.WriteLine(cme.Message);
            }
            catch(InvalidMoveException ime)
            {
                Console.WriteLine(ime.Message);
            }
            

         }

        
    }
}




//Board board = new Board();
// ResultType result;
// ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

// board.setCellMark(0, MarkType.X);
// board.setCellMark(1, MarkType.O);
// board.setCellMark(3, MarkType.X);
// board.setCellMark(2, MarkType.O);
// board.setCellMark(6, MarkType.X);
// board.setCellMark(6, MarkType.O);

// result = resultAnalyzer.AnalyzeResult();

// Console.WriteLine(result);