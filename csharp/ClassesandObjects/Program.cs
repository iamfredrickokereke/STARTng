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
            student1.CGPA = 5.0;

            Student student2 = new Student();

            student2.Name = "Chinedu";
            student2.Score = 89;
            student2.CGPA = 4.0;



            if (student1.CGPA > student2.CGPA)
            {                
                 Console.WriteLine(" my name is " + student1.Name + " and i have the highest CGPA of " + student1.CGPA);                
            }
            else
            {
                 Console.WriteLine(" my name is " + student1.Name + " and i have the highest CGPA of " + student1.CGPA);
            }


        }
    }
}
