using System;

public static partial class Algorithms{
  public static int BinarySearchIterative(int[] arr, int x){
      int left = 0; 
      int right = arr.Length - 1; 
        while (left <= right) { 
            int mid = left + (right - left) / 2; 
  
            if (arr[mid] == x){
              return mid; 
            } 
              
            if (arr[mid] < x){
              left = mid + 1;
            } 

            else{
              right = mid - 1; 
            }
                
        } 
  
        return -1; 
  }

  public static int BinarySearchRecursive(int[] arr, int left, int right, int x) 
  { 
      if (right >= left) { 
          int mid = left + (right - left) / 2; 

          if (arr[mid] == x){
            return mid; 
          } 
              
          if (arr[mid] > x) {
            return BinarySearchRecursive(arr, left, mid - 1, x); 
          }
            
          return BinarySearchRecursive(arr, mid + 1, right, x); 
      } 
 
      return -1; 
  }
}