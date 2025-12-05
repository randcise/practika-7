#nullable disable
using System;

public class OneType<T> where T : IComparable<T>
{
    private T value;

    public OneType(T val)
    {
        value = val;
    }

    public T Smaller(T a, T b)
    {
        return a.CompareTo(b) < 0 ? a : b;
    }
}

class Program
{
    static void Main()
    {
        OneType<int> obj = new OneType<int>(10);
        Console.WriteLine("Менше з 7 і 3 = " + obj.Smaller(7, 3));

        OneType<double> obj2 = new OneType<double>(5.5);
        Console.WriteLine("Менше з 2.5 і 4.7 = " + obj2.Smaller(2.5, 4.7));
    }
}
