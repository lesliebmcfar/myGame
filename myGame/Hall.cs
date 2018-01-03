using System;
using System.Collections.Generic;

namespace myGame
{
    public class Hall
    {
        private string description {get; set;}


        public static void EnterHall(){
         Console.Clear();
         Console.WriteLine("Push open the front door (is has been left ajar) and go in. You are in the entry hall, \nto your left is the kitchen \nYou can see cupboards are open, bottles and trash are scattered on every surface. \nStraight ahead is the living room more glasses and bottles trash; there is a chair is on it's side and there's a ...drumset?. \nTo your right are stairs going up, they are tall and you can't see anything beyond the top.\n");
         LeaveHall();
        }
        public static void LeaveHall(){
            Console.WriteLine("Where will you start? \nKitchen: K\nLiving Room: L\nUpstairs: U");
            string input = "";
            input = Console.ReadLine();{
                if (input == "K" || input == "k")
                 {   
                       Kitchen.EnterKitchen();}
                else
            if (input == "L" || input == "l")
                    LivingRoom.EnterLivingRoom();
                else    
                       if (input == "U" || input == "u")
                    Upstairs.GoUpstairs();
                else
                   
                Game.Die();   
            }
            }


            // kitchen- broom closet jimmy casino dead tied to chair in one, police or flee? get protection, knife is bloody
            // pantry- trapped squirrel in other, escaspes runs all over house-grab broom from the closet- jimmy casino

            //living room-right chair-whats that? just pepsi the poodle taking a nap, put him in his bed, squirl runs from behind, pepsi's stiff and dead, 
            //drum set- oh yeah, joey and the band played, but why did chuch leave his drums?symbols making a low noise, reach out to touch, spark flies, look closer see feet, find dead chuck

            //upstairs- dark and quiet, 

}
}
