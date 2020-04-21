using System;

namespace NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random randm = new Random();
            var currentLevel = "";
            var displayResult = "";
            int randomNumber;
            var guess = 0;
            var chances = 0;
            

            System.Console.Write("Dear user, you have between Easy, Medium and Hard. PRESS 1 - Easy, 2 - Medium and 3 - Hard... then Press ENTER : ");
            // System.Console.Write("");
            int numberChosen = int.Parse(Console.ReadLine());

            if (numberChosen == 1)
            {
                currentLevel = "EASY";
            }
            else if (numberChosen == 2)
            {
                currentLevel = "MEDIUM";
            }
            else if (numberChosen == 3)
            {
                currentLevel = "HARD";
            }
            else
            {
                displayResult = "Wrong input, Start the game again...";
            }

            if (currentLevel == "EASY")
            {
                //RANDOM NUMBER
                randomNumber = randm.Next(1,11);
                chances = 6;
                System.Console.WriteLine(playGame(1,10,chances,randomNumber,guess));
            }
            else if (currentLevel == "MEDIUM")
            {
                randomNumber = randm.Next(1,21);
                chances = 4;
                System.Console.WriteLine(playGame(1,20,chances,randomNumber,guess));
            }
            else if (currentLevel == "HARD")
            {
                randomNumber = randm.Next(1,51);
                chances = 3;
                System.Console.WriteLine(playGame(1,50,chances,randomNumber,guess));
            }
            Console.WriteLine(displayResult);            
        }

        //Game method
        private static string playGame(int minVal, int maxVal, int gameChance, int gameRandomNumber, int gameGuesses) 
        {
            string gameOutput = "";
            while (gameGuesses != gameRandomNumber)
            {
                if (gameChance > 1)
                {
                    Console.WriteLine($"You have {gameChance} chances left.");
                    Console.Write($"Guess the number between {minVal} and {maxVal}: ");
                    gameGuesses = int.Parse(Console.ReadLine());
                }
                else if (gameChance == 1)
                {
                    System.Console.WriteLine($"You have {gameChance} chance left.");
                    System.Console.Write($"Guess the number between {minVal} and {maxVal}: ");
                    gameGuesses = int.Parse(Console.ReadLine());
                }
                        

                if (gameGuesses == gameRandomNumber && gameChance > 0)
                {
                    gameOutput = $"Alas master, you got it. The random number is {gameRandomNumber}";
                    break;
                }

                if (gameChance == 1)
                {
                    gameOutput = "Oops, you are out of guesses. Please try again.";  
                    break;
                }
                else{
                    System.Console.WriteLine("Wrong Entry...");
                }
                gameChance -= 1;
            }
            return gameOutput;
        }
    }
}