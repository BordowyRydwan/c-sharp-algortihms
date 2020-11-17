using System;

public static partial class Algorithms{
  public static void SelectionSort(int[] arr){

    for(int i = 0; i < arr.Length - 1; ++i){

      int minIndex = i;

      for(int j = i; j < arr.Length; ++j){
        if(arr[j] < arr[minIndex]){
          minIndex = j;
        }
      }

      int tmp = arr[minIndex];

      arr[minIndex] = arr[i];
      arr[i] = tmp;

    }

  }
}