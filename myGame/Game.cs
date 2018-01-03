using System;

namespace myGame
{
    public class Game
    {

        public bool Playing = true;

        public static string MyName = "";

        public static void StartGame()
        {

            NameCharacter();
        }
        public static void NameCharacter()

        {
            Console.Clear();

            Console.WriteLine("Yikes, the morning after! \n\nLast night you and your best friend held a small soiree at her family estate.\nWord spread and before you could do anything to stop it, it was an old fashioned blowout. \nSometime before the sun came up, you wandered off to get some sleep in the guest house\nand now it's morning and you have been texting and calling your friend, but she isn't answering. \nAt very least you know you have to help clean up, so you are on the front porch, \nwishing you could ditch the whole situation.\n");
            Console.WriteLine("What is your name?\n");
            MyName = Console.ReadLine();
            Console.WriteLine($"\nWelcome to the monkey house {MyName}!\nDid you have a good time last night?\nWas it worth it? \nYou'd better get started cleaning this up, your friend's family will be home soon and this was NPOT a sanctioned activity!\n");

            Console.WriteLine("When you are ready, type Y to go into the house, N to ditch and go get a coffee.");
            Choice();
        }

        private static void Choice()

        {

            string input = "";
            input = Console.ReadLine();

            if (input == "Y" || input == "y")
                Hall.EnterHall();
            else
                if (input == "n" || input == "N")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nBad Choice! Go to rehab! You are never seen or heard from again.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\n\nYou made this mess " + (MyName) + ", you don't get to quit!");
                Hall.EnterHall();
            }

        }

        public static void OpenBroomCloset()

        {
            Console.Clear();
            Console.WriteLine("Holy cow there's someone passed out in the broom closet! Better wake him up. On closer inspection \nyou realize it's that creepy old guy Jimmy Casino that Tiffany brought. Nudge him with your foot, tell him to wake up. He doens't move. Try again, no dice. \nTurn on the light, discover he is dead, eyes wide open with a hole in the middle of his forehead.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("PANIC!!!!");
            Console.ResetColor();
            Console.WriteLine("Try to slam the door, but somehow his foot has moved and is blocking it. What should you do? \nCall the police! Of course, call the police and GET OUT OF THERE!\n");
            Game.OpenGarageAfterBroom();
        }
        internal static void OpenGarage()
        {
            Console.WriteLine("Open the garage door. You know this house like your own, there are extra car keys on the hook by the door, \ngrab them on your way out and run to the car and bail on the whole endeaver.");
            Game.Die();
        }
        internal static void OpenGarageAfterBroom()
        {
            Console.WriteLine("Open the garage door to make a clean getaway. You know this house like your own, there are extra car keys on the hook by the door, \ngrab them on your way out and run to the car. But wait, all the tires are slashed, you won't be getting out that way. \nBack into the kitchen. Now what? (p for pantry, h to go back to the hall)");
            string input = "";
            input = Console.ReadLine();

            if (input == "P" || input == "p")
                OpenPantry();
            else
                 if (input == "h" || input == "H")
                Hall.LeaveHall();

            else

                Console.WriteLine("Sorry, that's not possible, you can only press P, G or B. Should have learded to follow directions. You are DEAD");
        }

        internal static void OpenPantry()
        {
            Console.WriteLine("Open the pantry door and something small and furry flies out at you,\ntaking a nip out of your arm. It's a squirrel, somehow trapped in there. \nIt runs around the room, out in the hall and disappears into the house. \nGreat, now you've been bitten, you should look for medical supplies. Check the broom closet");
            OpenBroomCloset();
        }
        internal static void Die()
        {
           Console.WriteLine("Bad, bad friend. You are DEAD");
        }




    }
}

