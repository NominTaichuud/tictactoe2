using System;
using TicTacToeAndOthello2.Properties;

namespace TicTacToeAndOthello2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Board board = new Board();
            Game game = new Game();
            CheckWin checkWin = new CheckWin();
            UI ui = new UI();
            Console.WriteLine(game.counter);
            ui.introduction();
            

            while (game.PlaysAgain.Equals("Y"))
            {
                board.initializeVariable();
                Console.WriteLine(board.currentBoard[3]);
                while(checkWin.hasWon()==false && game.counter < 9)
                {
                    game.askData("X");
                    if (checkWin.hasWon() == true || game.counter == 9)
                        break;
                    game.askData("O");
                }
                if (checkWin.hasWon() == true)
                {
                    ui.playAgainMsg("Congradulation! You won!");
                }
                else ui.playAgainMsg("Sorry, but this was a tie game!");
            }
            ui.goodBye();
        }
    }
}
