using System;

public class Fibonacci
{
    public static int CalculateFibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        int[] fibArray = new int[n + 1];
        fibArray[0] = 0;
        fibArray[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
        }

        return fibArray[n];
    }

    public static void Main()
    {
        Console.Write("Enter the value of n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = CalculateFibonacci(n);
        Console.WriteLine($"Fibonacci({n}) = {result}");
    }
}