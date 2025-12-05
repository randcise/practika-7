#nullable disable
using System;

class Program
{
    // max
    public static T Max<T>(T[] arr) where T : IComparable<T>
    {
        T max = arr[0];
        foreach (var x in arr)
            if (x.CompareTo(max) > 0) max = x;
        return max;
    }

    // min
    public static T Min<T>(T[] arr) where T : IComparable<T>
    {
        T min = arr[0];
        foreach (var x in arr)
            if (x.CompareTo(min) < 0) min = x;
        return min;
    }

    static void Main()
    {
        int[] a = { 5, 3, 8, 2, 9 };
        double[] b = { 3.1, 7.4, 1.2, 9.9 };

        Console.WriteLine($"int max = {Max(a)}, int min = {Min(a)}");
        Console.WriteLine($"double max = {Max(b)}, double min = {Min(b)}");
    }
}
