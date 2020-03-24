using System;

namespace Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize the variables
            int firstnumber = 0;   int secondnumber = 0;   int result =  0;

            // Display a beautiful * line demacator.
            System.Console.WriteLine("*************************************");

            // Display Program title
            System.Console.WriteLine("This is a simple Subtraction program");

            // Display a beautiful * line demacator.
            System.Console.WriteLine("*************************************");

            // Ask user for the first input
            System.Console.Write("Please enter your first number : ");

            // convert user string input to integer and store in firstnumber
            firstnumber = int.Parse(Console.ReadLine());

            // Ask user for the second input
            System.Console.Write("Please enter your second number : ");

            // convert user string input to integer and store in secondnumber
            secondnumber = int.Parse(Console.ReadLine());

           // Subtract the firstnumber by the secondnumber and store in the result variable
            result = firstnumber - secondnumber;

            // Display an empty line
            System.Console.WriteLine();

            //Display Result
            System.Console.WriteLine("After Subtraction the result is " + result);
        }
    }
}
