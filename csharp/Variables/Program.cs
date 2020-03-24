using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int result =  0;


            System.Console.Write("Please enter your first number : ");
            firstNumber = int.Parse(Console.ReadLine());

            
            System.Console.Write("Please enter your second number : ");
            secondNumber = int.Parse(Console.ReadLine());

            System.Console.Write("Please enter your third number : ");
            thirdNumber = int.Parse(Console.ReadLine());
            
            result = firstNumber * secondNumber * thirdNumber;

            System.Console.WriteLine(" After Multiplication the result is " + result);
        }
    }
}
