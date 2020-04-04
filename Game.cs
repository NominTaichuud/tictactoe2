using System;

namespace TicTacToeAndOthello2.Properties
{
    public class Game
    {
        Board board=new Board();
        
        private String playsAgain="Y";
        public int counter=0;
        public String PlaysAgain { get => playsAgain; set => playsAgain = value; }
        //public int Counter { get => counter; set => counter = value; }
        //public Board Board { get => board; set => board = value; }
        public Game()
        {
        }
        public void askData(String player)
        {
            Console.Clear();

            Console.WriteLine("Player: " + player); // X / O
            int selection;

            while (true)
            {
                Console.WriteLine("Please enter your selection.");
                Console.WriteLine("Counter: " + counter);
                board.drawBoard();
                selection = Convert.ToInt32(Console.ReadLine()); // input from the user, the index of board
                // [0, ..., 8]
                if (selection < 0 || selection > 9 || (board.currentBoard[selection].Equals("X") || board.currentBoard[selection].Equals("O")))
                    Console.WriteLine("Invalid selection!");
                else
                    break;
            }
            board.currentBoard[selection] = player;
            //Console.WriteLine(board.currentBoard[4]);
            counter++;
        }

        public void reset()
        {
            // clear the board
            board.initializeVariable();
            // counter = 0
            counter = 0;
        }
    }

   
   
}
