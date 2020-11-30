using System;

public static partial class Algorithms{
    public static int MasterElement(int[] arr){
        
        int counter = 0;
        int masterIndex = 0;

        for(int i = 0; i < arr.Length; ++i){
            if(counter == 0){
                counter++;
                masterIndex = i;
            }
            else if(arr[i] == arr[masterIndex]){
                counter++;
            }
            else{
                counter--;
            }
        }

        return arr[masterIndex];

    }
}