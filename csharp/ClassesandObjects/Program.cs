using System;

namespace ClassesandObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            
            student1.Name = "Fredrick";
            student1.Score = 99;

            Student student2 = new Student();
            
            student2.Name = "Chinedu";
            student2.Score = 89;



            Console.WriteLine("Hello World!" + " my name is " + student1.Name + " and i scored " + student1.Score);
        }
    }
}
