using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public string OwnerName { get; set; }
    public List<Entry> Entries { get; set; } = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
        Console.WriteLine("Journal Updated");
    }

    public void Display()
    {
        Console.WriteLine($"Name: {OwnerName}");
        Console.WriteLine("Entries: ");
        foreach (var entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(OwnerName);
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Question}|{entry.Text}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            OwnerName = reader.ReadLine();
            string line;
            Entries.Clear();
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                Entry entry = new Entry
                {
                    Date = DateTime.Parse(parts[0]),
                    Question = parts[1],
                    Text = parts[2]
                };
                Entries.Add(entry);
            }
        }
    }
}
