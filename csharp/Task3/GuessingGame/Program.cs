using System.Collections.Generic;   
using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // strings
            //Trim, Trim(), TrimStart(), TrimEnd()
            //Replace
            //Remove
            //Contains => true /false.
            //StartsWith
            //EndsWith

            //behavior with integer. 

            //division with integer returns an integer  e.g 9/2

            //integer.min,   integer.max  which returns highest precision value  e.g x.maxvalue + 3 ===>  goes into overflow -negative  viceversal

            //integer.minvalue returns the least value in its precision hold

            //double  double.minvalue====> double.maxvalue

            // decimal decimal.minvalue ==> decimal.maxvalue //   the dedimal precision has more values than double

            // decimal     var x = 1.4M;  where m denotes constant is decimal


            // lond and short  .minvalue and .maxvalue



            var name = "            Fred                              ";
            var d = 9/2;

            int min = int.MinValue;
            int max = int.MaxValue;


            double x = 1/3;

            System.Console.WriteLine(x);
            System.Console.WriteLine(1.0/3.0);
            // System.Console.WriteLine($"[{name.Trim()}]");
            // System.Console.WriteLine($"[{name.TrimStart()}]");
            // System.Console.WriteLine($"[{name.TrimEnd()}]");
            // System.Console.WriteLine($"[{name}]");
            //System.Console.WriteLine(name.Replace("Fred", "kelly"));

            System.Console.WriteLine($"Hello {name.Trim()} the answer is {d}");

            System.Console.WriteLine(min);
            System.Console.WriteLine(max);
        }
    }
}
