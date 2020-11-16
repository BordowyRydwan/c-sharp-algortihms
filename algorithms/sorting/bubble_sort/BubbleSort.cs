using System;

public static partial class Algorithms{
  public static void BubbleSort(int[] arr){

    for(int i = 0; i < arr.Length - 1; ++i){
      for(int j = 0; j < arr.Length - 1; ++j){

        if(arr[j] > arr[j + 1]){

          int tmp = arr[j];
          
          arr[j] = arr[j + 1];
          arr[j + 1] = tmp;
        }

      }
    }

  }
}