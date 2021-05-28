using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace EscapeRoom
{

    class Door
    {
        private string Code;

        public Door(string code)
        {
            Code = code;
        }
        public bool AttemptEscape()
        {
            WriteLine("You step up and try the door. It's locked and needs a code...");
            Write("Please enter a code:");
            string playerGuess = ReadLine().ToLower().Trim();
            if(playerGuess == Code)
            {
                WriteLine("Click... the lock falls away. You escaped!");           
            }
            else
            {
                WriteLine("Nothing happened... guess the code was wrong.");
            }
            WriteLine("(press any key to continue)");
            ReadKey(true);
            return playerGuess == Code;
        }
    }
}
