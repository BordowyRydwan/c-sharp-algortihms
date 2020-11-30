using System;

public static partial class Algorithms{
	public static void CountingSort(string[] arr, int digit){
		const int MAX_ASCII = 128;

		string[] output = new string[arr.Length];
		int[] counters = new int[MAX_ASCII]; //tablica chowajaca alfabet
		
		for(int i = 0; i < MAX_ASCII; ++i)
		{
			counters[i] = 0;
		}

		for(int i = 0; i < arr.Length; ++i)
		{
			counters[digit < arr[i].Length ? arr[i][digit] + 1 : 0]++;
		}

		for(int i = 1; i < MAX_ASCII; ++i)
		{
			counters[i] += counters[i - 1];
		}

		for(int i = arr.Length - 1; i >= 0; --i)
		{
			output[counters[digit < arr[i].Length ? arr[i][digit] + 1 : 0] - 1] = arr[i];
			counters[digit < arr[i].Length ? arr[i][digit] + 1 : 0]--;
		}

		for (int i = 0; i < arr.Length; ++i)
		{
			arr[i] = output[i];
		}
	}
}