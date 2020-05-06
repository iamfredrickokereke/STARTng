using System.Drawing;
using System;

namespace ClassesandObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.Xposition = 0;
            box1.Yposition = 0;
            box1.Height = 100;
            box1.Width = 100;
            box1.Color = "Red";
            

            Box box2 = new Box();
            box2.Xposition = 5;
            box2.Yposition = 10;
            box2.Height = 100;
            box2.Width = 200;
            box2.Color = "black";



            bool isbox1Square = isShapeSquare(box1);
            bool isbox2Square = isShapeSquare(box2);


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

        static bool isShapeSquare(Box b){
            if (b.Width == b.Height)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
