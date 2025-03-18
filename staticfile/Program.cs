using System;

class SalesReport
{
    static void Main()
    {
        int numSalesmen = 2; // Change as needed
        int numItems = 5;
        string[] salesmen = new string[numSalesmen];
        int[,] sales = new int[numSalesmen, numItems];
        int[] totalSales = new int[numSalesmen];

        for (int i = 0; i < numSalesmen; i++)
        {
            Console.WriteLine($"Enter Salesman {i + 1} Name: ");
            salesmen[i] = Console.ReadLine();

            int sum = 0;
            for (int j = 0; j < numItems; j++)
            {
                Console.WriteLine($"Enter sales for item {j + 1}: ");
                sales[i, j] = int.Parse(Console.ReadLine());
                sum += sales[i, j];
            }
            totalSales[i] = sum;
        }

        Console.WriteLine("\nSales Report");
        Console.WriteLine("Name    Item1  Item2  Item3  Item4  Item5  TotalSales");

        int grandTotal = 0;
        for (int i = 0; i < numSalesmen; i++)
        {
            Console.WriteLine($"{salesmen[i]}  ");
            for (int j = 0; j < numItems; j++)
            {
                Console.WriteLine($"{sales[i, j],5} ");
            }
            Console.WriteLine($"{totalSales[i],5}");
            grandTotal += totalSales[i];
        }

        Console.WriteLine($"GrandTotal  {grandTotal}");
    }
}