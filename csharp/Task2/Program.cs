﻿using System;

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

            System.Console.WriteLine("Welcome to Eric's Supermarket...");
            System.Console.WriteLine("Enter an order number");

            int orderNumber = int.Parse(Console.ReadLine());
            bool isThereFood = false;
            double price = 0;

            for (int index = 0; index < orders.length; index++)
            {
                if (orderNumber == orders[index])
                {
                    price = prices[index];
                    isThereFood = true;
                    break;
                }
            }

        }
    }
}
