using System;

public static partial class Algorithms{
    public static int LinearSearch(int[] arr, int element){

        for(int i = 0; i < arr.Length; ++i){
            if(arr[i] == element){
                return i;
            }
        }

        return -1;
        
    }
}