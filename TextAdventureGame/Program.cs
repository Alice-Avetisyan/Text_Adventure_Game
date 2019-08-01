using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame
{
    class Program
    {
        /*
         * Creating a Text Adventure Game which will require written input from the user
         * The program utilizes: Methods, Switch Cases, If(if, else if, else) Statements, Loops (while loop, for loop, foreach loop), 
         * Random numbers, Strings, Arrays, User Input
         */
        static void Main(string[] args)
        {
            //Calling the start of the game
            GameTitle();
        }

        //---------Game Title---------------------
        public static void GameTitle()
        {
            Console.WriteLine("Welcome to the:\nTEXT ADVENTURE GAME");
            Console.WriteLine("\nPress 'Enter' to begin.");

            Console.ReadLine();
            Console.Clear();

            First();
        }//GameTitle

        //---------First/Story Act One---------------------
        public static void First()
        {
            //Putting the story components/text in array
            //Player summery
            string[] playerSumm = {"You are a janitor working for a big Corporation.",
                "You don't even remember the name of the Corporation. What a surprise.",
                "But...that's not the bigest problem here. Why? Well, you have a bad habit of daydreaming during your job. And not the small and harmless dreams. No, no...",
                "One day, you are a fierce warrior who destroys armies of darkness. The so called \"darkness\" is actually your Boss and his business partners.",
                "Or sometimes you imagine yourself as a wise mage traveling across the world. Or like your coworkers would like to call you instead: \"An Idiot Who Walks Around With A Wet Broom And Sprays Everyone With Dirty Water!\"",
                "Still surprised you aren't fierd?", "However, even though every worker is forced to deal with such a person such as you on a daily basic...",
                "You're the only janitor who does their works perfectly."};
            //Printing playerSumm using foreach loop
            foreach (string player in playerSumm)
                Console.WriteLine(player);

            string choice;
            string[] choiceArr = { "1. Punch him", "2. Apologize", "3. Say nothing" };

            Console.WriteLine("\nAnyway, lets start with the story.\n");

            Console.WriteLine("You wake up from your daydreaming (like always) to see your Manager standing right behind you. He looks mad.\nApperently, you have been dancing around with your mope, and have put a bucket of dirty soap water on your head.");

            Console.WriteLine("What do you do?\n");

            //printing choiceArr
            for (int i = 0; i < choiceArr.Length; i++)
            {
                Console.WriteLine(choiceArr[i]);
            }

            Console.Write("\nChoice: ");

            //Player's written answer/player writes an answer
            choice = Console.ReadLine().ToLower();
            // Console.Clear();

            string[] case_1 = {"You without thinking punched him in the face.", "Everyone is confused at first but then start cheering.",
                    "While you are enjoing the praise and the admiration of your followers, Boss hears the commotion and storms out of the office.",
                    "When she sees the Manager sulking in the corner with a dead look in his eyes, she pulls out her Panzerfaust and shoots you straight out of the building."};

            string[] case_2 = { "The Manager is fuming with rage. ", "I don't need your apology! ", "Go clean the mess!" };

            //Creating a "choosing" mechanism with the use of switch cases
            //To make the game progress the player must write valid input(from the set choices), otherwise (by default) the player will receive a message 
            switch (choice)
            {
                case "1":
                case "punch him":
                case "punch":
                    {
                        for (int i = 0; i < case_1.Length; i++)
                        {
                            Console.WriteLine(case_1[i]);
                        }// case_1 array
                        Console.WriteLine("\nPress 'Enter' to continue.");
                        Console.ReadLine();

                        GameOver();
                        break;
                    }//case 1

                case "2":
                case "sorry":
                case "apologize":
                    {
                        for (int i = 0; i < case_2.Length; i++)
                        {
                            Console.Write(case_2[i]);
                        }// case_2 array
                        Console.WriteLine("\nPress 'Enter' to continue.");
                        Console.ReadLine();

                        Second();
                        break;
                    }//case 2

                case "3":
                case "say nothing":
                case "stay silent":
                    {
                        Console.WriteLine("\nThe Mangaer's face becomes the color of ripe tomatoes. You take cover behind the wall and throw a grenade which in actuality was a bar of soap.");
                        Console.WriteLine("Fortunately it missed him, but the Manager still shrieked like a little girl. After coming to his senses he roared: \"You disrespectful brat! You think you can do whatever you want?!\"");
                        Console.WriteLine(case_2[2]);
                        Console.WriteLine("\nPress'Enter' to continue.");
                        Console.ReadLine();

                        Second();
                        break;
                    }//case 3

                default:
                    {
                        //Is called when the written text does not correspond to the statements used in the case method 
                        Console.WriteLine("\nI don't understand that command...");
                        Console.WriteLine("\nPress 'Enter' to try again.");
                        Console.ReadLine();

                        First();
                        break;
                    }//default
            }//switch
        }//First

        //---------Second/Story Act Two---------------------
        public static void Second()
        {
            Random rnd = new Random();
            string[] secOptions = {"While cleaning the mess you have made, in the hallway you see that cops are searching for someone.",
                                        "In the hallway you see your stalker walking towards you.","In the halway the fire alarm goes off."};

            //uses Random class to randomly select number/object from secOptions
            int randomNumber = rnd.Next(0, 3);//randomNumber chooses are rundom number from numbers 1 to 3
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);

            Console.WriteLine("Your senses are screaming at you. Something is definitely wrong. Do you try to hide in the bathroom; Yes or No?");
            Console.Write("\nChoice: ");

            secChoice = Console.ReadLine().ToLower();

            //a simple yes or no statements 
            if (secChoice == "yes" || secChoice == "y")
            {
                Third();
            }// if
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("A meteor slams into the hallway at that exact moment, killing you instantly.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                GameOver();
            }// else if
            else
            {
                //Is called when the written text does not correspond to the statements used in the if statement
                Console.WriteLine("I don't understand that command...");
                Console.WriteLine("Press 'Enter' to try again.");
                Console.ReadLine();
                Second();
            } // else
        }//Second

        //---------Third/Story Act Three---------------------
        public static void Third()
        {
            int runningSpeed;
            Random rnd = new Random();
            string[] trdMotivations = { "You need to run faster!", "You will die if you run like a snail!", "I SAID FASTER, YOU DIMWIT!", "Gotta go faster!" };

            Console.WriteLine("\nYou burst into the bathroom and whoever was chaising you started aggressivly pounding on the door.");
            Console.WriteLine("Your heart beat increases. If you don't escape you might end up dead.");
            Console.WriteLine("How fast do you run?");
            Console.Write("Please enter a number: ");
            //TryParse converts string to int
            //referencing runningSpeed value
            int.TryParse(Console.ReadLine(), out runningSpeed);

            //creates a while loop until the needed(runningSpeed<100) condition is met
            while (runningSpeed < 100)
            {
                //uses Random class to randomly select number/object from trdMotivations(to motivate our player)
                int randomNumber = rnd.Next(0, 4);
                string trdText = trdMotivations[randomNumber];
                Console.WriteLine(trdText);
                Console.Write("Please enter a number: ");
                int.TryParse(Console.ReadLine(), out runningSpeed);
            }//while
            Console.WriteLine("You run at the speed of sound, breaking throung the walls and windows.\nWhoever was chaising you never caught up with you and got arested for being a shitty person.");
            YouWin();
        }//Third

        //---------Game Over---------------------
        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("At your funeral, they sing songs of your bravery.\nUnfortunately they remember who's funeral they are attenting and they take it all back.");
            Console.WriteLine("\nBetter Luck Next Time");
            Console.WriteLine("\nPress 'Enter' to try again.");
            Console.ReadLine();
            //Clears the console and returns to the Game Title screen
            Console.Clear();
            GameTitle();
        }//GameOver

        //---------You Win---------------------
        public static void YouWin()
        {
            Console.Clear();
            Console.WriteLine("After running away you never returned to that Corporation, afraid that they will find out who's been using the plants as a defence against zombies. The plants did a fine job at preventing all your coworkers from coming inside the building.\nThe same could be said about your stalker who in reality was your landlord. Don't know what he is doing here, but who cares!");
            Console.WriteLine("\nYou Win!");
            Console.WriteLine("\nPress 'Enter'.");
            Console.ReadLine();
            //Clears the console and returns to the Game Title screen
            Console.Clear();
            GameTitle();
        }//YouWin

    }
}
