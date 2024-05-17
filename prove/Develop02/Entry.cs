using System;

public class Entry
{
    public DateTime Date { get; set; }
    public string Question { get; set; }
    public string Text { get; set; }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Question: {Question}");
        Console.WriteLine($"Response: {Text}\n");
    }
}
