using System;
using System.Collections.Generic;

namespace myGame
{
    public class Kitchen
    {
        public string Name {get; set;}

        public string Description {get; set;}
      
        public void Door(string name, string description ){
           
           Name = name;
           Description = description;
       } 
       
      

        

        public  static void EnterKitchen()
        {
            Console.WriteLine("The kitchen is a great idea, after all there's so much garbage to pick up, you'd better get a trashbag or two.\nThe kitchen is exactly the mess you suspected, platters of mostly eaten food, empty bottles and cups,\nwhat appears to be a pan of burned pasta on the stove. Heavy sigh. There are three doors, one that leads to the garage (g),\none for the broom closet(b) and finally the pantry(p). Hmm, trash bags could be anywhere. Which door will you open?\n");
            string input = "";
            input = Console.ReadLine();
            {
                if (input == "P" || input == "p")
                    Game.OpenPantry();
                else
            
            if (input == "G" || input == "g")
                    Game.OpenGarage();
                else
                       if (input == "B" || input == "b")
                    Game.OpenBroomCloset();

                else

                    Console.WriteLine("Sorry, that's not possible, you can only press P, G or B. Should have learded to follow directions. You are DEAD");
                

            }


        }

        //private void NewMethod()
      //  {
           // Console.WriteLine("You decide to go to the kitchen, after all there's so much garbage to pick up, you'd better get a trashbag or two.\nThe kitchen is exactly the mess you suspected, platters of mostly eaten food, empty bottles and cups,\nwhat appears to be a pan of burned pasta on the stove. Heavy sigh. There are there doors, one that leads to the garage (g),\none for the broom closet(b) and finally the pantry(p). Hmm, trash bags could be anywhere. Which door will you open?\n");


       //}
    }
}