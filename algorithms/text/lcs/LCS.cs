using System;

public static partial class Algorithms{
    public static string LCS(string s1, string s2){
    
        string result = "";

        int m = s1.Length;
        int n = s2.Length;
        int i, j;

        int[,] L = new int[m + 1, n + 1];

        for(i = 0; i <= m; ++i)
        {
            L[i, 0] = 0;
        }

        for (i = 0; i <= n; ++i)
        {
            L[0, i] = 0;
        }

        for(i = 0; i < m; ++i)
        {
            for(j = 0; j < n; ++j)
            {
                if(s1[i] == s2[j])
                {
                    L[i + 1, j + 1] = L[i, j] + 1;
                }
                else
                {
                    L[i + 1, j + 1] = Math.Max(L[i + 1, j], L[i, j + 1]);
                }
            }
        }

        i = m - 1;
        j = n - 1;

        while ((i >= 0) && (j >= 0))
        {
            if(s1[i] == s2[j])
            {
                result = String.Concat(s1[i], result);
                i--;
                j--;
            }
            else if(L[i + 1, j] > L[i, j + 1])
            {
                j--;
            }
            else
            {
                i--;
            }
        }

        return result;
    }
}