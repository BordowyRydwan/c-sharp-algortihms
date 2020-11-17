using System;

public static partial class Algorithms{
	static void Merge(int[] arr, int left, int mid, int right){
		int leftLength = mid - left + 1;
		int rightLength = right - mid;

		int[] leftArray = new int[leftLength];
		int[] rightArray = new int[rightLength];
		int i, j;

		for (i = 0; i < leftLength; ++i){
			leftArray[i] = arr[left + i];
		}

		for (j = 0; j < rightLength; ++j){
			rightArray[j] = arr[mid + 1 + j];
		}

		i = 0;
		j = 0;

		int k = left;
		while (i < leftLength && j < rightLength) {
			if (leftArray[i] <= rightArray[j]) {
				arr[k] = leftArray[i];
				i++;
			}
			else {
				arr[k] = rightArray[j];
				j++;
			}
			k++;
		}

		while (i < leftLength) {
			arr[k] = leftArray[i];
			i++;
			k++;
		}

		while (j < rightLength) {
			arr[k] = rightArray[j];
			j++;
			k++;
		}
	}

	public static void MergeSort(int[] arr, int left, int right)
	{
		if (left < right) {
			int mid = (left + right) / 2;

			Algorithms.MergeSort(arr, left, mid);
			Algorithms.MergeSort(arr, mid + 1, right);

			Algorithms.Merge(arr, left, mid, right);
		}
	}
}