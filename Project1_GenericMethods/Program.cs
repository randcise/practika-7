#nullable disable
using System;

class Program
{
    // Універсальний метод обміну
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        double x = 3.14, y = 8.25;
        Console.WriteLine($"До обміну: x={x}, y={y}");
        Swap(ref x, ref y);
        Console.WriteLine($"Після обміну: x={x}, y={y}");

        string s1 = "Hello", s2 = "World";
        Console.WriteLine($"\nДо обміну: {s1}, {s2}");
        Swap(ref s1, ref s2);
        Console.WriteLine($"Після обміну: {s1}, {s2}");
    }
}
