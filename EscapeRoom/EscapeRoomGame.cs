using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace EscapeRoom
{
    class EscapeRoomGame
    {
        private RoomObject Painting;
        private RoomObject Cane;
        private RoomObject DeskDrawer;
        private Door LockedDoor;
        private bool HasEscaped;


        public EscapeRoomGame()
        {
            Painting = new RoomObject("painting", "It's, oddly enough a giant painting of mice. You think \"mice\" might be a clue.");
            Cane = new RoomObject("Cane", "You realize it is actually a walking stick that a \"blind man\" might use.");
            DeskDrawer = new RoomObject("Desk drawer", "It sticks slightly, but you manage to jiggle it open. You find a post it with the number \"three\" on it.");
            LockedDoor = new Door("three blind mice");
            HasEscaped = false;
        }
        public void StartRoom()
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            Clear();
            Title = "Escape!";
            WriteLine("You wake up and groggigly look around.");
            WriteLine("Looks like you are in some kind of escape room...");
            WriteLine("(press any key to continue)");
            ReadKey(true);

            //Painting.DisplayInfo();
            //Cane.DisplayInfo();
            //DeskDrawer.DisplayInfo();
            //bool wasSuccessful = LockedDoor.AttemptEscape();
            //WriteLine($"Did they escape? {wasSuccessful}");
            while (!HasEscaped)
            {
                string choice = Navigate();
                WriteLine($"You chose {choice}");
                if(choice == "1")
                {
                    
                    Painting.DisplayInfo();
                }
                else if(choice == "2")
                {
                    Painting.DisplayInfo();
                }
                else if(choice == "3")
                {
                    Painting.DisplayInfo();
                }
                else if(choice == "4")
                {
                    bool wasSuccessful = LockedDoor.AttemptEscape();
                    HasEscaped = wasSuccessful;
                }
                else
                {
                    DisplayInvalidChoiceFeedback();
                }
            }
           

            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
        
        private void DisplayInvalidChoiceFeedback()
        {
            WriteLine("That's not a valid option. Try again.");
            WriteLine("(press any key to continue");
            ReadKey(true);
        }

        public string Navigate()
        {
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("Where would you like to look?");
            WriteLine(" 1) a painting \n 2) a desk drawer \n 3) a cane \n 4) a door");
            string navigationChoice = ReadLine().Trim();
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            return navigationChoice;
        }
    }
}
