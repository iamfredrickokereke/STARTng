using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = 0;
            int secondnumber = 0;
            int result =  0;


            Console.Write("Please enter your first number : ");
            firstnumber = int.Parse(Console.ReadLine());

            
            System.Console.Write("Please enter your second number : ");
            secondnumber = int.Parse(Console.ReadLine());
            
            result = firstnumber + secondnumber;

            System.Console.WriteLine(" The result is " + result);
        }
    }
}
