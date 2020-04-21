﻿using System;

namespace NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random randm = new Random();
            var levels = "";
            var wrongInputOutput = "";
            int randomNumber;
            var guess = 0;
            var chances = 0;
            

            System.Console.Write("Dear user, you have between Easy, Medium and Hard. PRESS 1 - Easy, 2 - Medium and 3 - Hard: ");
            System.Console.WriteLine("Welcome!!!");
            int numberChosen = int.Parse(Console.ReadLine());

            //SETTING LEVEL OF GAME
            if (numberChosen == 1)
            {
                levels = "EASY";
            }
            else if (numberChosen == 2)
            {
                levels = "MEDIUM";
            }
            else if (numberChosen == 3)
            {
                levels = "HARD";
            }
            else
            {
                wrongInputOutput = "Wrong input, Start the game again...";
            }

            //STARTING GAME BASED ON LEVEL
            if (levels == "EASY")
            {
                //CREATING RANDOM NUMBER
                randomNumber = randm.Next(1,11);
                chances = 6;

                Console.WriteLine(playGame(1,10,chances,randomNumber,guess));
            }
            else if (levels == "MEDIUM")
            {
                randomNumber = randm.Next(1,21);
                chances = 4;

                Console.WriteLine(playGame(1,20,chances,randomNumber,guess));
            }
            else if (levels == "HARD")
            {
                randomNumber = randm.Next(1,51);
                chances = 3;

                Console.WriteLine(playGame(1,50,chances,randomNumber,guess));
            }
            Console.WriteLine(wrongInputOutput);            
        }

        //Method that plays the game so that i don't repeat myself
        private static string playGame(int minValue, int maxValue, int gameChance, int gameRandomNumber, int gameGuess) 
        {
            string gameOutput = "";
            while (gameGuess != gameRandomNumber)
            {
                if (gameChance > 1)
                {
                    Console.WriteLine($"You have {gameChance} chances left.");
                    Console.Write($"Guess the number between {minValue} and {maxValue}: ");
                    gameGuess = int.Parse(Console.ReadLine());
                }
                else if (gameChance == 1)
                {
                    Console.WriteLine($"You have {gameChance} chance left.");
                    Console.Write($"Guess the number between {minValue} and {maxValue}: ");
                    gameGuess = int.Parse(Console.ReadLine());
                }
                        

                if (gameGuess == gameRandomNumber && gameChance > 0)
                {
                    gameOutput = $"You got it right. The random number was {gameRandomNumber}";
                    break;
                }

                if (gameChance == 1)
                {
                    gameOutput = "All attempts was wrong. Try again later";  
                    break;
                }
                gameChance -= 1;
            }
            return gameOutput;
        }
    }
}