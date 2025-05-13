using System; 

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
            
        {
            int maxAttempts = 3;
            bool validChoice = false;
        

            for (int attempts = 1; attempts <= maxAttempts; attempts++)
            {
                Console.WriteLine("\nChoose a shape to calculate area:");
                Console.WriteLine("1. Triangle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Circle");
                Console.Write("Enter your choice (1-3): ");
                
                string input = Console.ReadLine();
                
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    ShowRemainingAttempts(attempts, maxAttempts);
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        CalculateTriangleArea();
                        validChoice = true;
                        break;
                    case 2:
                        CalculateRectangleArea();
                        validChoice = true;
                        break;
                    case 3:
                        CalculateCircleArea();
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please select 1, 2, or 3.");
                        ShowRemainingAttempts(attempts, maxAttempts);
                        break;
                }

                if (validChoice) break;
            }

            if (!validChoice)
            {
                Console.WriteLine("\nMaximum attempts reached. Exiting program.");
            }
        }

        static void CalculateTriangleArea()
        {
            Console.Write("Enter base length: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double area = 0.5 * baseLength * height;
            Console.WriteLine($"\nArea of Triangle: {area:F2}");
        }

        static void CalculateRectangleArea()
        {
            Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter breadth: ");
            double breadth = Convert.ToDouble(Console.ReadLine());
            double area = length * breadth;
            Console.WriteLine($"\nArea of Rectangle: {area:F2}");
        }

        static void CalculateCircleArea()
        {
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine($"\nArea of Circle: {area:F2}");
        }

        static void ShowRemainingAttempts(int currentAttempt, int maxAttempts)
        {
            int remaining = maxAttempts - currentAttempt;
            if (remaining > 0)
            {
                Console.WriteLine($"You have {remaining} attempt(s) remaining.");
            }
        }
    }
}
