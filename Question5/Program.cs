using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the number of salesmen and items
        int numberOfSalesmen = 2;
        int numberOfItems = 5;
        
        // Arrays to store salesmen names and sales data
        string[] names = new string[numberOfSalesmen];
        int[,] sales = new int[numberOfSalesmen, numberOfItems];

        // Collect sales data for each salesman
        for (int i = 0; i < numberOfSalesmen; i++)
        {
            Console.Write("Enter the name of salesman {0}: ", i + 1);
            names[i] = Console.ReadLine();
            
            // Collect sales for each item
            for (int j = 0; j < numberOfItems; j++)
            {
                Console.Write("Enter sales for item {0}: ", j + 1);
                sales[i, j] = int.Parse(Console.ReadLine()); // Convert input to integer
            }
        }

        // Display the table header
        Console.WriteLine("Name\tItem1\tItem2\tItem3\tItem4\tItem5\tTotalSales");
        Console.WriteLine("-----------------------------------------------------");

        int grandTotal = 0; // Variable to store total sales of all salesmen
        
        // Process and display each salesman's data
        for (int i = 0; i < numberOfSalesmen; i++)
        {
            int totalSales = 0; // Store total sales for the current salesman
            Console.Write(names[i] + "\t");
            
            // Print sales for each item and compute total sales
            for (int j = 0; j < numberOfItems; j++)
            {
                Console.Write(sales[i, j] + "\t");
                totalSales += sales[i, j];
            }
            
            Console.WriteLine(totalSales); // Print total sales for the salesman
            grandTotal += totalSales; // Add to grand total
        }
        
        // Display grand total
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("GrandTotal\t" + grandTotal);
    }
}
