﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TiTacToeWorkshop
{
   public class Input
    {
        private static char PlayerInput()
        {
            Console.WriteLine("Choose Letter X oR O: ");
            string userLetter = Console.ReadLine();
            return char.ToUpper(userLetter[0]);
        }

    }
}
