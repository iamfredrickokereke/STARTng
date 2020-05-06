using System;

namespace ClassesandObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Chinedu";
            student1.Score = 89;
            Console.WriteLine("Hello World!" + " my name is " + student1.Name + " and i scored " + student1.Score);
        }
    }
}
