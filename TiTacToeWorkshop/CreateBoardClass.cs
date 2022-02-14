using System;
using System.Collections.Generic;
using System.Text;

namespace TiTacToeWorkshop
{
    public class CreateBoardClass
    {
        public static char[] BoardCreation()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
    }
}
