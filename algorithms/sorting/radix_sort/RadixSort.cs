using System;

public static partial class Algorithms{
	static int GetMax(string[] arr)
        {
            int n = arr.Length;

            int max = arr[0].Length;
            for (int i = 1; i < n; i++)
            {
                if (arr[i].Length > max)
                    max = arr[i].Length;
            }

            return max;
        }


	public static void RadixSort(string[] arr){
		 int longestWord = GetMax(arr);

            for(int i = longestWord; i > 0; --i)
            {
                Algorithms.CountingSort(arr, i - 1);
            }	
	}
}