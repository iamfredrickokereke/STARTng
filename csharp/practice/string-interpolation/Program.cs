using System;

namespace string_interpolation
{
    class Program
    {

        enum DaysOfTheWeek{
            monday,
            tuesday,
            wednesday,
            thursday,
            friday
        }

        static void Main(string[] args)
        {
        //    string afriend = "Belrah";
        //    string name = "fred";

        //    System.Console.WriteLine($"Hello {afrie(nd}, my name is {name}");

        // int a = 5; int b = ++a; int c = b++;

        // System.Console.WriteLine($"{a},{b},{c}");

    //     int a = 5;

    //     int b = a++;   //    !  its important to know that b = 5 but a = 6

    //     string name = "fred";
    //     string surname = "okereke";
    //    System.Console.WriteLine(b.CompareTo(a));
    //           System.Console.WriteLine();


    //           System.Console.WriteLine(string.Compare(name, surname, true));
    //            System.Console.WriteLine(string.Equals(name, surname));


        // int x = 5;
        // double y = x;

        // double y = 10;
        // int x = (int)y;

        // string b = "hello";

        //  b.Substring(0,2);
        // b.StartsWith("h"); // returns a bool of true or false
        // b.EndsWith("o"); // returns bool

        // System.Console.WriteLine(b);



        // DayOfWeek today = DayOfWeek.Friday;

        // System.Console.WriteLine(today);
        // System.Console.WriteLine((int)today);

        var fnum = int.Parse(Console.ReadLine());
        var snum = int.Parse(Console.ReadLine());

        var result = fnum + snum;

        System.Console.WriteLine($"{fnum} + {snum} = {result}");
        System.Console.WriteLine("{fnum} + {snum} = {result}");

        // Increment/decrement operators



        
        

        }
    }
}
