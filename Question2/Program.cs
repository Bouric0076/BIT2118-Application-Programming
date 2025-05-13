using System;

class NestedLoop
{
    static void Main(string[]args)
    {
        int n = 6; 

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                
                if (i == 0 || i == n - 1 || i == j)
                {
                    Console.Write("& ");
                }
                else
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
    }
}
