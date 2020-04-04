using System;
namespace TicTacToeAndOthello2.Properties
{
    public class CheckWin:Board
    {

        
        public CheckWin()
        {

        }
        public Boolean hasWon()
        {
            Console.WriteLine(currentBoard[5]);
            for (int i = 0; i < 7; i += 3)
            {
                if (currentBoard[i].Equals(currentBoard[i + 1]) && currentBoard[i + 1].Equals(currentBoard[i + 2]))
                {
                    
                    return true;
                }
            }
            if (currentBoard[0].Equals(currentBoard[3]) && currentBoard[3].Equals(currentBoard[6]))
                return true;
            if (currentBoard[1].Equals(currentBoard[4]) && currentBoard[4].Equals(currentBoard[7]))
                return true;
            if (currentBoard[2].Equals(currentBoard[5]) && currentBoard[3].Equals(currentBoard[8]))
                return true;
            if (currentBoard[2].Equals(currentBoard[4]) && currentBoard[4].Equals(currentBoard[6]))
                return true;
            if (currentBoard[0].Equals(currentBoard[4]) && currentBoard[4].Equals(currentBoard[8]))
                return true;
            return false;
        }
        
    }
}
