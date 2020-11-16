using System;

public static partial class Algorithms{
	public static int TernarySearch(int[] arr, int left, int right, int number)
        {
            if(right >= left)
            {
                int mid1 = left + (right - left) / 3;
                int mid2 = mid1 + (right - left) / 3;

                if (arr[mid1] == number)
                {
                    return mid1;
                }

                if (arr[mid2] == number)
                {
                    return mid2;
                }

                if (number < arr[mid1])
                {
                    return TernarySearch(arr, left, mid1 - 1, number);
                }

                if (number > arr[mid2])
                {
                    return TernarySearch(arr, mid2 + 1, right, number);
                }

                return TernarySearch(arr, mid1 + 1, mid2 - 1, number);
            }

            return -1;
        }

}