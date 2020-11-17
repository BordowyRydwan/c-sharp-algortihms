using System;

public static partial class Algorithms{
    public static long FibonacciTermRecursive(long n){
        if(n < 3){
            return 1;
        }

        return FibonacciTermRecursive(n - 1) + FibonacciTermRecursive(n - 2);
    }

    public static long FibonacciTermDynamic(long n){
        long[] tmpArr = new long[n];

        tmpArr[0] = 1;
        tmpArr[1] = 1;

        for(int i = 2; i < n; ++i){
            tmpArr[i] = tmpArr[i - 1] + tmpArr[i - 2];
        }

        return tmpArr[tmpArr.Length - 1];
    }

    public static long FibonacciTermIterative(long n){
        long a = 1;
        long b = 1;

        for(int i = 2; i < n; ++i){
            b += a;
            a = b - a;
        }

        return b;
    }
}