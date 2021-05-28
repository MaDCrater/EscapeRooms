using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace EscapeRoom
{
    class RoomObject
    {
        private string Name;
        private string Description;
        private Random myRand;
        
        public RoomObject(string name, string description)
        {
            Name = name;
            Description = description;
            myRand = new Random();
        }
        public void DisplayInfo()
        {
            WriteLine($"You inspect the {Name}.");
            WriteLine(Description);
            WriteLine("You hear loud footsteps. \n");
            int Monster = myRand.Next(1, 7);
            if(Monster < 3)
            {
                Death();
            }
            else
            {
                Hero();
            }
            WriteLine("(press any key to continue)");
            ReadKey(true);
         }

        public void Death()
        {
            ConsoleColor prevColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Red;
            WriteLine("The door is suddenly thurst open.\n A man with a chainsaw appears. \n");
            WriteLine("You die...");
            ForegroundColor = prevColor;
        }
        public void Hero()
        {
            ConsoleColor prevColor = ForegroundColor;
            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("The door is suddenly thurst open. \n A friend grabs your hand.");
            WriteLine("Are you saved?");
            ForegroundColor = prevColor;
        }
    }
   
}
