using System;
namespace RiceGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = 5;
            int turns = 1;
            string demonSide;

            Console.WriteLine("Right Road, Wrong Road!");
            Console.WriteLine("You are chasing a demon who risks everything to eat humans. You must choose the correct side or else the demon eats some humans.");
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();

            while (lives > 0)
            {
                Console.WriteLine("Turn: " + turns + ". Lives = " + lives + ". Left or Right?");
                string playerChoice = Console.ReadLine();
                Random r = new Random();
                int demonChoice = r.Next(0, 2);
                if (demonChoice == 0)
                {
                    demonSide = "Left";
                }
                else
                {
                    demonSide = "Right";
                }
                if (playerChoice.ToLower() == demonSide.ToLower())
                {
                    Console.WriteLine("Awesome! You stopped the demon... for now... Lives = " + lives);
                    turns += 1;
                }
                else if (playerChoice.ToLower() != demonSide.ToLower() && playerChoice == "left" || playerChoice == "right")
                { 
                    lives -= 1;
                    turns += 1;
                    Console.WriteLine("Whoops! The demon ate humans in another town. You lost a life. Lives = " + lives);
                }
                else
                {
                    Console.WriteLine("Whoops! Try again!");
                }
            }
            if (turns > 19)
            {
                Console.WriteLine("You ran out of lives. " + playerName + ", you were able to live for " + turns + " turns. Rating = S");
            }
            else if (turns > 14 && turns < 20)
            {
                Console.WriteLine("You ran out of lives. " + playerName + ", you were able to live for " + turns + " turns. Rating = A");
            }
            else if (turns > 11 && turns < 15)
            {
                Console.WriteLine("You ran out of lives. " + playerName + ", you were able to live for " + turns + " turns. Rating = B");
            }
            else if (turns > 9 && turns < 12)
            {
                Console.WriteLine("You ran out of lives. " + playerName + ", you were able to live for " + turns + " turns. Rating = C");
            }
            else if (turns > 5 && turns < 10)
            {
                Console.WriteLine("You ran out of lives. " + playerName + ", you were able to live for " + turns + " turns. Rating = D");
            }
            else
            {
                Console.WriteLine("You ran out of lives. " + playerName + ", you were able to live for " + turns + " turns. Rating = F");
            }
            Console.ReadKey();
        }
    }
}
