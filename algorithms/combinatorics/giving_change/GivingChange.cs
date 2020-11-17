using System;

public static partial class Algorithms{
    public static int HowManyChangeWays(int[] coins, int change)
    {
        int[] ways = new int[change + 1];

        ways[0] = 1;

        for (int i = 0; i < coins.Length; ++i)
        {
            for(int j = coins[i]; j < ways.Length; ++j)
            {
                ways[j] += ways[j - coins[i]];
            }
        }

        return ways[ways.Length - 1];  
    }

    public static int MinimumChangeCoins(int[] coins, int change)
    {
        if(change == 0){
            return 0;
        }

        int result = Int32.MaxValue;

        for(int i = 0; i < coins.Length; ++i){
            if(coins[i] <= change){

                int subResult = MinimumChangeCoins(coins, change - coins[i]);

                if(subResult != Int32.MaxValue && subResult + 1 < result){
                    result = subResult + 1;
                }

            }
        }

        return result;
    }
}