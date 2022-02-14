using System;

namespace TiTacToeWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //addind player and computer
            Console.WriteLine("Welcome to TICTocToe Problem");
            char[] board = BoardCreation();
            char userLetter = PlayerUserLetter();
            char computerLetter = (userLetter == 'X') ? 'O' : 'X';

        }

        private static char PlayerUserLetter()
        {
            throw new NotImplementedException();
        }

        private static char[] BoardCreation()
        {
            throw new NotImplementedException();
        }
    }
}
