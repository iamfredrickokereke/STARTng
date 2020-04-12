using System.Collections.Generic;
using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] orders = {1, 2, 3};
            double[] prices = new double[3]; 
            prices[0] = 1000;
            prices[1] = 2000; 
            prices[2] = 3000;

            List<string>  Fruits = new List<string>();

            Fruits.Add("Rice");
            Fruits.Add("Beans");
            Fruits.Add("Yam");
            Fruits.Add("Soup");


            System.Console.WriteLine("Welcome to Eric's Supermarket...");
            System.Console.WriteLine("Enter an order number");

            int orderNumber = int.Parse(Console.ReadLine());
            bool isThereFruits = false;
            double price = 0;

            for (int index = 0; index < orders.Length; index++)
            {

                 for (int i = 0; i < Fruits.Count; i++) // Loop through List with for
            {
                if (orderNumber == orders[index])
                {
                    price = prices[index];
                    isThereFruits = true;
               
                    break;
                }
            }
                
            }


            if (isThereFruits == true){
                System.Console.WriteLine("The food is available, and the price is {0}", price.ToString("C"));
                //System.Console.WriteLine("Your food is " + Fruits[i].ToString());
            }
            else{
                System.Console.WriteLine("We are sorry, this food is finished");
            }

        }
    }
}
