using System;
using System.Collections.Generic;
using System.Text;

namespace TiTacToeWorkshop
{
   public class InputFRomPlayers
    {
         private static char PlayerUserLetter()
        {
            Console.WriteLine("Choose your Letter: ");
            string userLetter = Console.ReadLine();
            return char.ToUpper(userLetter[0]);
        }
    }
}
