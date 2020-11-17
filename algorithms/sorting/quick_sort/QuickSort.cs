using System;

public static partial class Algorithms{
  static int Partition(int[] arr, int left, int right){
    int pivot = arr[(left + right) / 2];

    while (left <= right)
    {
        while (arr[left] < pivot)
        {
            left++;
        }

        while (arr[right] > pivot)
        {
            right--;
        }

        if (left <= right)
        {
            int tmp = arr[left];
            arr[left] = arr[right];
            arr[right] = tmp;
            left++;
            right--;
        }
    }

    return left;
  }

  public static void QuickSort(int[] arr, int left, int right)
    {
        if (left >= right){
          return;
        }

        int partition = Partition(arr, left, right);

        QuickSort(arr, left, partition - 1);
        QuickSort(arr, partition, right);
    }
}