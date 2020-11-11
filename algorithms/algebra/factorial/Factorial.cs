using System;

public static partial class Algorithms
{
    public static long FactorialRecursive(long n)
    {
        if(n < 0)
        {
            throw new ArgumentOutOfRangeException("You can't simply calculate factorial for negatives");
        }

        return n != 1 ? n * FactorialRecursive(n - 1) : 1;
    }

    public static long FactorialIterative(long n)
    {
        int product = 1;

        if (n < 0)
        {
            throw new ArgumentOutOfRangeException("You can't simply calculate factorial for negatives");
        }

        for (int i = 2; i <= n; ++i)
        {
            product *= i;
        }

        return product;
    }

    public static long Factorial(int n)
    {
        return FactorialIterative(n); //selecting the quicker one
    }
}

   

