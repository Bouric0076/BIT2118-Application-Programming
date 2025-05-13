using System;

class Business
{
    double buyingPrice, transportCost, sellingPrice;

    // Default constructor
    public Business()
    {
        buyingPrice = 0;
        transportCost = 0;
        sellingPrice = 0;
    }

    // Parameterized constructor
    public Business(double buyingPrice, double transportCost, double sellingPrice)
    {
        this.buyingPrice = buyingPrice;
        this.transportCost = transportCost;
        this.sellingPrice = sellingPrice;
    }

    public void CalculateProfitOrLoss()
    {
        double totalCost = buyingPrice + transportCost;
        double result = sellingPrice - totalCost;

        if (result > 0)
        {
            Console.WriteLine($"Profit made: {result:C}");
        }
        else if (result < 0)
        {
            Console.WriteLine($"Loss incurred: {-result:C}");
        }
        else
        {
            Console.WriteLine("No profit or loss was made.");
        }
    }
}

class Program
{
    static void Main()
    {
        Business item1 = new Business(100, 20, 150);
        item1.CalculateProfitOrLoss();

        Business item2 = new Business();
        item2.CalculateProfitOrLoss();
    }
}
