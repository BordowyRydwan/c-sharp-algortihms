using System;

public static partial class Algorithms{
   public static bool DoesIndexSumExist(int[] arr1, int[] arr2, int checkedNumber)
    {
        int i = 0;
        int j = arr1.Length - 1;

        int[] tmp1 = arr1;
        int[] tmp2 = arr2;

        Array.Sort(tmp1);
        Array.Sort(tmp2);

        while (i < tmp1.Length && j > 0)
        {
            if (tmp1[i] + tmp2[j] == checkedNumber)
            {
                return true;
            }
            else if (tmp1[i] + tmp2[j] < checkedNumber)
            {
                i += 1;
            }
            else
            {
                j -= 1;
            }
        }

        return false;
    }
}