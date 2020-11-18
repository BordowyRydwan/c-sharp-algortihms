using System;

public static partial class Algorithms{
    public static int BinomialIterative(int n, int k){
        int result = 1;

        if(k < 0 || k > n){
            return 0;
        }

        if(k == 0 || k == n){
            return 1;
        }

        k = Math.Min(k, n - k);

        for(int i = 0; i < k; ++i){
            result = result * (n - i) / (i + 1); 
        }

        return result;

    }

    public static int BinomialRecursive(int n, int k){
        if(k < 0 || k > n){
            return 0;
        }

        if(k > n - k){
            k = n - k;
        }

        if(k == 0 || k == n){
            return 1;
        }

        return BinomialRecursive(n - 1, k) + BinomialRecursive(n - 1, k - 1);
    }

    public static int BinomialDynamic(int n, int k){
        int[,] matrix = new int[n+1,k+1]; 
          
        for (int i = 0; i <= n; i++) 
        { 
            for (int j = 0; j <= Math.Min(i, k); j++) 
            { 

                if (j == 0 || j == i){
                    matrix[i,j] = 1; 
                }

                else{
                    matrix[i,j] = matrix[i-1,j-1] + matrix[i-1,j]; 
                }
                    
            } 
        } 
          
        return matrix[n,k];
    }
}