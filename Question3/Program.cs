﻿//evaluating credit worthiness


using System;

namespace CreditWorthinessEvaluator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of customers: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the credit limit: ");
                double creditLimit = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the price of the item: ");
                double price = Convert.ToDouble(Console.ReadLine());

                bool isValid = false;
                double quantity = 0.0;
                double totalValue = 0.0;

                while (!isValid)
                {
                    Console.Write("Enter the quantity: ");
                    quantity = Convert.ToDouble(Console.ReadLine());

                    totalValue = price * quantity;

                    if (totalValue > creditLimit)
                    {
                        Console.WriteLine("Sorry, you cannot purchase goods worth such a value on credit.");
                    }
                    else
                    {
                        Console.WriteLine("Thank you for purchasing from us.");
                        Console.WriteLine($"The value of the purchase is: {totalValue}");
                        isValid = true;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
