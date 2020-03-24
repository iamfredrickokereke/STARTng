using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize the variables
            int firstnumber = 0;   int secondnumber = 0;   int thirdnumber = 0;   int result =  0;

            // Output a beautiful * line demacator.
            System.Console.WriteLine("*************************************");

            // Display Program title
            System.Console.WriteLine("This is a simple Multiplication program");

            // Output a beautiful * line demacator.
            System.Console.WriteLine("*************************************");

            // Ask user for the first input
            System.Console.Write("Please enter your first number : ");

            // convert user string input to integer and store in firstnumber
            firstnumber = int.Parse(Console.ReadLine());

            // Ask user for the second input
            System.Console.Write("Please enter your second number : ");

            // convert user string input to integer and store in secondnumber
            secondnumber = int.Parse(Console.ReadLine());

            // Ask user for the third input
            System.Console.Write("Please enter your third number : ");

            // convert user string input to integer and store in thirdnumber
            thirdnumber = int.Parse(Console.ReadLine());            
    
            // Multiply the firstnumber by the secondnumber, thirdnumber and store in the result variable
            result = firstnumber * secondnumber * thirdnumber;

            // Display an empty line
            System.Console.WriteLine();

            //Display Result
            System.Console.WriteLine("After Multiplication the result is " + result);
        }
    }
}
