using System;
namespace TicTacToeAndOthello2.Properties
{
    public class Board
    {
        
        public String[] currentBoard = new string[9];
        //public String[] currentBoard { get => currentBoard; set => currentBoard = value; }
        

        public Board()
        {
            //initializeVariable();

        }

        public void initializeVariable()
        {
            for(int i =0; i<9; i++)
            {
                currentBoard[i] = i.ToString();
            }
        }
        public void drawBoard()
        {
            for (int i = 0; i < 7; i += 3)
                Console.WriteLine(currentBoard[i] + "|" + currentBoard[i + 1] + "|" + currentBoard[i + 2]);
        }
    }
}
