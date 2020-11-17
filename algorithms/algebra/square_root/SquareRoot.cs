using System;

public static partial class Algorithms{
    public static double Sqrt(double n, double EPS = 10e-10){
        double a = n;
        double b = 1.0;

        while(Math.Abs(a - b) > EPS){
            a = (a + b) / 2;
            b = n / a;
        }

        return a;
    }
}