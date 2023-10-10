using System;

public class Factorial
{
    public static long CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1; // Base case: 0! = 1
        }
        else
        {
            return n * CalculateFactorial(n - 1);
        }
    }

    public static void Main()
    {
        Console.Write("Enter a non-negative integer n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            long result = CalculateFactorial(n);
            Console.WriteLine($"{n}! = {result}");
        }
    }
}