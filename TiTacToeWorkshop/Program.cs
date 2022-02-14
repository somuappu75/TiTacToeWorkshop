using System;

namespace TiTacToeWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TICTocToe Problem");
            char[] board = BoardCreation();
            char PlayerLetter = PlayerInput();
            char computer_Letter = (PlayerLetter == 'X') ? 'O' : 'X';
        }

        private static char PlayerInput()
        {
            throw new NotImplementedException();
        }

        private static char[] BoardCreation()
        {
            throw new NotImplementedException();
        }
    }
}
