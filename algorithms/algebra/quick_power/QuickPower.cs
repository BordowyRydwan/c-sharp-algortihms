using System;

public static partial class Algorithms
{
    public static int PowerNaive(int num, int power)
    {
        //Complexity: O(n)

        int result = 1;

        for (int i = 0; i < power; ++i)
        {
            result *= num;
        }

        return result;
    }

    public static int PowerRecursive(int num, int power)
    {
        //Complexity: O(log(n))

        if(power == 0)
        {
            return 1;
        }
        else if (power == 1)
        {
            return num;
        }
        else if (Convert.ToBoolean(power % 2))
        {
            return num * PowerRecursive(num, (power - 1) / 2) * PowerRecursive(num, (power - 1) / 2);
        }
        else
        {
            return PowerRecursive(num, power / 2) * PowerRecursive(num, power / 2);
        }
    }

    public static int PowerDynamic(int num, int power)
    {
        //Complexity: O(log(n))

        int result = 1;

        while (power > 0)
        {
            if (Convert.ToBoolean(power % 2))
            {
                result *= num;
            }

            num *= num;
            power /= 2;
        }

        return result;
    }

    public static int Power(int num, int power)
    {
        return PowerDynamic(num, power);
    }
}
