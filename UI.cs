using System;
namespace TicTacToeAndOthello2.Properties
{
    public class UI
    {
        Game game=new Game();
        public void introduction()
        {
            Console.Title = ("Tic Tac Toe Version 2");
            Console.WriteLine("Welcome to Tic Tac Toe.\n");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public void playAgainMsg(String message)
        {
            Console.WriteLine(message + "Do you want to play again?");
            if (Console.ReadLine().Equals("Y"))
            {
                game.reset();
                game.PlaysAgain = "Y";
            }
            else
            {
                game.PlaysAgain = "N";
            }
        }

        public void goodBye()
        {
            Console.WriteLine("Thank you for playing! Thanks YouTube for watching.");
            Console.ReadLine();

        }
    }
}
