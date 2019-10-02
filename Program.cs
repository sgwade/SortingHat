using System;



using System.Threading;

namespace SortingHat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Beep(8000, 2000);
            Console.WriteLine("Welcome to Hogwarts, please enter your name: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Wizard newWizard = new Wizard (Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            newWizard.Song();
            newWizard.Quiz();
            
        }
    }
   
    class Wizard
    {
        public string Name {get; set;}

        public Wizard(string name)
        {
            Name = name;
        }
         public void Song()
        {
            Console.WriteLine($"{Name}, after leaving the whistling Hogwarts Express behind, and crossing the eerie Black Lake,");
            Console.WriteLine("you bid Hagrid farewell and follow closely behind as Professor McGonagall leads you through");
            Console.WriteLine("the hallowed halls of Hogwarts School of Witchcraft and Wizardry. ");
            Console.WriteLine("You sit with the other First Years, anxiously waiting to find out which House you will be sorted into.");
            Console.WriteLine(" ");
            Console.WriteLine("Then the Sorting Hat begins to sing...");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("There's nothing hidden in your head The Sorting Hat can't see, so try me on and I will tell you where you ought to be.");
            Console.ForegroundColor = ConsoleColor.White;
            string cont = Console.ReadLine();
            if (cont == "")
            {
                Console.Clear();
            }
        
        }

        public void Quiz()
        { // write these as different quiz functions! 
            int slytherin = 0;
            int hufflepuff = 0;
            int ravenclaw = 0;
            int gryffindor = 0;
            Console.WriteLine($"{Name}, you're locked in a duel with a skilled opponent. They fire an unknown spell at you, and you shout...");
            Console.WriteLine(" ");
            Console.WriteLine("Expelliarmus, Protego, Stupefy, or Crucio!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string answerOne = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            
            if(answerOne == "expelliarmus")
            {
                gryffindor += 1;
            }
            else if(answerOne == "protego")
            {
                ravenclaw += 1;
            }
            else if(answerOne == "stupefy")
            {
                hufflepuff += 1;
            }
            else if(answerOne == "crucio")
            {
                slytherin += 1;
            }

            Console.Clear();
            Console.WriteLine($"{Name}, it's your fifth year at Hogwarts, and you've just received a Howler from your parents. What for?");
            Console.WriteLine(" ");
            Console.WriteLine("Sneaking into the Forbidden Forest at night on a dare."); //Forbidden Forest
            Console.WriteLine("Getting caught cheating in my Divination O.W.L."); //Cheating
            Console.WriteLine("Being put in detention after I was caught in the library after hours."); //Detention
            Console.WriteLine("Nothing! I'd never do anything to warrant a Howler!"); //Nothing
            Console.ForegroundColor = ConsoleColor.Cyan;
            string answerTwo = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            
            if(answerOne == "forbidden forest")
            {
                gryffindor += 1;
            }
            else if(answerTwo == "detention")
            {
                ravenclaw += 1;
            }
            else if(answerTwo == "nothing")
            {
                hufflepuff += 1;
            }
            else if(answerTwo == "cheating")
            {
                slytherin += 1;
            }

            Console.Clear();
            Console.WriteLine($"{Name}, The first Quidditch match of the season is approaching, and you can't wait to get involved. What role are you playing?");
            Console.WriteLine(" ");
            Console.WriteLine("Seaker. I want the glory!"); //Seaker
            Console.WriteLine("Chaser. I like to be involved, and work as part of the team."); //Chaser
            Console.WriteLine("Beater. I like having all that power."); //Beater
            Console.WriteLine("I'll be in the crowd, making sure supporter morale is high!"); //Crowd
            Console.ForegroundColor = ConsoleColor.Cyan;
            string answerThree = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            
            if(answerOne == "seaker")
            {
                gryffindor += 1;
            }
            else if(answerThree == "chaser")
            {
                ravenclaw += 1;
            }
            else if(answerThree == "crowd")
            {
                hufflepuff += 1;
            }
            else if(answerThree == "beater")
            {
                slytherin += 1;
            }

            Console.Clear();
            Console.WriteLine($"{Name}, It's Saturday, you've finished your homework, and have some free time. You decide to spend some time away from your common room. Where do you go?");
            Console.WriteLine(" ");
            Console.WriteLine("The Forbidden Forest"); //Forbidden Forest
            Console.WriteLine("The library"); //Library
            Console.WriteLine("The kitchens"); //Kitchens
            Console.WriteLine("The Room of Requirement"); //Room of Requirement
            Console.ForegroundColor = ConsoleColor.Cyan;
            string answerFour = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            
            if(answerFour == "room of requirement")
            {
                gryffindor += 1;
            }
            else if(answerFour == "library")
            {
                ravenclaw += 1;
            }
            else if(answerFour == "kitchens")
            {
                hufflepuff += 1;
            }
            else if(answerFour == "forbidden forest")
            {
                slytherin += 1;
            }

            Console.Clear();
            Console.WriteLine($"{Name}, Which path do you intend to follow after leaving Hogwarts?");
            Console.WriteLine(" ");
            Console.WriteLine("I'd join the Ministry -- I want to make a difference in the world."); //Ministry
            Console.WriteLine("I think I'd travel for a while before commiting to a career."); //Travel
            Console.WriteLine("I'd settle down and start a family as soon as possible!"); //Family
            Console.WriteLine("I'd continue to work hard in order to achieve as much success as possible."); //Success
            Console.ForegroundColor = ConsoleColor.Cyan;
            string answerFive = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            
            if(answerFive == "travel")
            {
                gryffindor += 1;
            }
            else if(answerFive == "ministry")
            {
                ravenclaw += 1;
            }
            else if(answerFive == "family")
            {
                hufflepuff += 1;
            }
            else if(answerFive == "success")
            {
                slytherin += 1;
            }

            Console.Clear();
        
        if(gryffindor >= 2)
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine($"{Name}, you belong in Gryffindor, where dwell the brave at heart, their daring, nerve, and chivalry Set Gryffindors apart!");
            }
                
        else if(ravenclaw >= 2)
                
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{Name}, you belong in wise old Ravenclaw, you have a ready mind, where those of wit and learning, will always find their kind!");
            }
        else if(hufflepuff >= 2)
                
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{Name}, you belong in Hufflepuff, where they are just and loyal, those patient Hufflepuffs are true, and unafraid of toil!");
            }
        else if(slytherin >= 2)
               
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{Name}, you belong in Slytherin, where you'll make real friends, those cunning folks use any means to achieve their ends! ");
            }
                  
        }
     
    }
    
}

