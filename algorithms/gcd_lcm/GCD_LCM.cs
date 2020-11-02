using System;

public static partial class Algorithms
{
    public static int GCDRecursive(int a, int b)
    {
        if((a < 0 || b < 0) || (a == 0 && b == 0))
        {
            throw new ArgumentOutOfRangeException("Numbers should be higher than 0");
        }

        int min = Math.Min(a, b);
        int max = Math.Max(a, b);

        if (min != 0)
        {
            return GCDRecursive(min, max % min);
        }

        return max;
    }

    public static int GCDIterative(int a, int b)
    {
        if ((a < 0 || b < 0) || (a == 0 && b == 0))
        {
            throw new ArgumentOutOfRangeException("Numbers should be higher than 0");
        }

        int min = Math.Min(a, b);
        int max = Math.Max(a, b);

        while (min != 0)
        {
            int tmp = max % min;

            max = min;
            min = tmp;
        }

        return max;
    }

    public static int GCD(int a, int b)
    {
        return GCDIterative(a, b); //chooses the faster method
    }

    public static int LCM(int a, int b)
    {
        return Math.Max(a, b) * GCD(a, b);
    }
}
