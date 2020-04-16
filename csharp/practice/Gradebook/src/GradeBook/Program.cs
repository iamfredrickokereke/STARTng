using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

        //    double [] numbers = new double [3];

            var numbers = new double[3];

           numbers[0] = 1;
           numbers[1] = 2;
           numbers[2] = 3;

           System.Console.WriteLine(numbers[1] + numbers[2]);
        }
    }
}
