using System;
using System.Collections.Generic;

public static partial class Algorithms{

    static void swap<T>(ref T a, ref T b) {
        T c = a;
        a = b;
        b = c;
    }

    public static void NetherlandsFlagProblem(ref char[] arr) {
        int left = 0;
        int right = arr.Length - 1;
        int mid = 0;

        while (mid <= right) {
            if (arr[mid] == 'R') {
                swap(ref arr[left++], ref arr[mid++]);
            } 
            else if (arr[mid] == 'B') {
                swap(ref arr[mid], ref arr[right--]);
            } 
            else {
                mid++;
            }
        }
    }

    //source: https://mattomatti.com/RES/a0062/plcode1.cs
}