#nullable disable
using System;
using System.Collections;
using System.Collections.Generic;

// Клас Друкарське Видання
public class Publication
{
    public string Title { get; set; }
    public int Pages { get; set; }

    public Publication(string title, int pages)
    {
        Title = title;
        Pages = pages;
    }

    public override string ToString() => $"{Title} ({Pages} сторінок)";
}

// Узагальнений список
public class GenericList<T> : IEnumerable<T>
{
    private List<T> list = new List<T>();

    public void Add(T item) => list.Add(item);

    public IEnumerator<T> GetEnumerator() => list.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

class Program
{
    static void Main()
    {
        GenericList<Publication> publications = new GenericList<Publication>();

        publications.Add(new Publication("Forbes", 80));
        publications.Add(new Publication("National Geographic", 120));
        publications.Add(new Publication("Science Weekly", 90));

        Console.WriteLine("Список друкарських видань:");
        foreach (var pub in publications)
            Console.WriteLine(pub);
    }
}
