using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static partial class Algorithms
{
    public static List<int> FindPrimesLowerThanN(int n)
    {
        bool[] sieve = new bool[n];
        List<int> primes = new List<int>();

        for (int i = 2; i < sieve.Length; ++i)
        {
            sieve[i] = true;
        }

        for (int i = 2; i * i <= n; ++i)
        {
            if (sieve[i])
            {
                for (int j = i * i; j < n; j += i)
                {
                    sieve[j] = false;
                }
            }
        }

        for (int i = 2; i < sieve.Length; ++i)
        {
            if (sieve[i])
            {
                primes.Add(i);
            }
        }

        return primes;
    }

    public static bool IsPrime(int n)
    {
        if(n < 2)
        {
            return false;
        }

        for(int i = 2; i * i <= n; ++i)
        {
            if(n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
