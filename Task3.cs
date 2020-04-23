using System;

namespace ThirdTask 
{
    class Program 
    {
        public static void notNumber() 
        {
            Console.WriteLine("There are three levels: Easy, Medium and Hard");
            Console.Write ("Enter a level to play: ");
            string userChoice = Console.ReadLine();
            bool gameStart = true;
        }

        static void Main (string[] args) 
        {
            //game variables
            int guess;
            int attempts = 0;
            int guess_limit = 0;
            bool gameStart = true;
            string gameLevels = "There are three levels:Easy, Medium and Hard";

            //game start
            Console.Write("Welcome to my number guessing game. To exit at any time, type quit. ");
            Console.WriteLine(gameLevels);
            Console.Write("Enter a level to play: ");
            string userChoice = Console.ReadLine();
            while (gameStart)
            {
                if (userChoice == "easy") 
               {
                guess_limit = 6;
                int secretNumber = 7;
                Console.WriteLine("Let the games begin... you have 6 chances to guess the number between 1 and 10.");
                while (guess_limit != 0) 
                {
                    Console.Write("Guess the number: ");
                    string guess_value = Console.ReadLine();          
                    attempts += 1;
                    guess_limit -= 1;   
                    if(guess_value == "quit") 
                    {
                        gameStart = false;
                        break;                       
                    }           
                    else if (int.TryParse(guess_value, out guess)) 
                    {                            
                        if (guess == secretNumber) 
                        {
                            Console.WriteLine("You got it right!");
                            break;
                        } 
                        else
                        {
                            Console.WriteLine("That was wrong. You have " + guess_limit + " guesses left. ");
                        }
                    }                     
                    else 
                    {
                        notNumber();
                        guess_limit = 6;
                    }                    
                } 
                Console.WriteLine("Game Over!");   
                break;   
                } 
                else if (userChoice == "medium") 
                {
                guess_limit = 4;
                int secretNumber = 16;
                Console.WriteLine("You are required to guess the number between 1 and 20, you have 4 guesses. \nLet the games begin...");
                while (guess_limit != 0) 
                {
                    Console.Write("Guess the number: ");
                    string guess_value = Console.ReadLine();          
                    attempts += 1;
                    guess_limit -= 1;              
                    if (int.TryParse(guess_value, out guess)) 
                    {                            
                        if (guess == secretNumber) 
                        {
                            Console.WriteLine("You got it right!");
                            break;
                        } 
                        else
                        {
                            Console.WriteLine("That was wrong. You have " + guess_limit + " guesses left. ");
                        }
                    } 
                    else 
                    {
                        notNumber();
                    }                    
                } 
                Console.WriteLine("Game Over!");
                break;                            
                } 
                else if (userChoice == "hard") 
                {
                guess_limit = 3;
                int secretNumber = 16;
                Console.WriteLine("You are required to guess the number between 1 and 50 with only 3 attempts. \nLet the games begin...");
                while (guess_limit != 0) 
                {
                    Console.Write("Guess the number: ");
                    string guess_value = Console.ReadLine();          
                    attempts += 1;
                    guess_limit -= 1;              
                    if (int.TryParse(guess_value, out guess)) 
                    {                            
                        if (guess == secretNumber) 
                        {
                            Console.WriteLine("You got it right!");
                            break;
                        } 
                        else
                        {
                           Console.WriteLine("That was wrong. You have " + guess_limit + " guesses left. ");
                        }
                    } 
                    else 
                    {
                        notNumber();
                    }                    
                } 
                Console.WriteLine("Game Over!");
                break;
                } 
                else if (userChoice == "quit") 
                {
                    break;
                }
                else 
                {
                   Console.Write("Please enter easy medium or hard to play if not, quit.");
                } 
            }              
        }
    }
}