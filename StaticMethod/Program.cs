using System;

class questionone
{
    static void Main()
    {
        int totalscore = 0;
        int secretNumber = 7;


        Console.Write("Enter the number of rounds: ");

        int rounds = int.Parse(Console.ReadLine());

        for ( int i = 0; i < rounds; i++)
        {
            Console.Write("Enter your Lucky number for round {i}: ");

            int LuckyNumber = int.Parse(Console.ReadLine());

            int remainder = LuckyNumber % secretNumber;

            if (remainder == 0)
            {
                totalscore += 1;
            }
            else if (remainder % 2 == 0)
            {
                totalscore += 3;
            }
            else 
            {
                totalscore -=3;
            }

            Console.WriteLine("Your score for round {i} is {totalscore}");

            if (totalscore > 0)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose");
            }
        }
    }
}
