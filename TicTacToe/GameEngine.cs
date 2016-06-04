using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TicTacToe
{
    public class GameEngine
    {
        public int[,] board;

        public GameEngine()
        {
            board = new int[3,3];
        }

        public bool CheckWinner(int playerX)
        {

            for (int i = 0; i < 3; i++)
            {
     
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != playerX)
                        break;
                    if ( j == 2 && board[i,2] == playerX)
                    {
                        //MessageBox.Show("We have a winner Crossing");
                        return true;
                    }
                        

                }
            }
            if ((board[0, 0] == playerX && board[1, 1] == playerX && board[2, 2] == playerX) || (board[0, 2] == playerX && board[1, 1] == playerX && board[2, 0] == playerX))
            {
                //MessageBox.Show("We have a winner CrossSection");
                return true;
            }
                
            

            return false;
        }
    }
}
