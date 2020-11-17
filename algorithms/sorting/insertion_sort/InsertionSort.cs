using System;

public static partial class Algorithms{
  public static void InsertionSort(int[] arr){

    for(int i = 0; i < arr.Length; ++i){
      int j = i;

      while(j > 0 && arr[j - 1] > arr[j]){
        int tmp = arr[j];

        arr[j] = arr[j - 1];
        arr[j - 1] = tmp;

        j--;
      }
    }

  }
}