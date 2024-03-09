using System.Runtime.InteropServices;
using System.IO; 

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void CreateEntry()
    {
        Entry entry1 = new Entry();

        Console.WriteLine(entry1._prompt);
        entry1._text = Console.ReadLine();
        
        _entries.Add(entry1);
    }

    public void DisplayAll()
    {
        foreach (Entry elem in _entries)
        {
            elem.Display();
        }
    }

    public void Save()
    {
        Console.WriteLine("What is the filename?");
        string filename = $"{Console.ReadLine()}.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry elem in _entries)
            {
                outputFile.WriteLine($"{elem._date}|{elem._prompt}|{elem._text}");
            }
        }
    }

    public void Load()
    {
        _entries.Clear();

        Console.WriteLine("What is the filename?");
        string filename = $"{Console.ReadLine()}.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry1 = new Entry();
            entry1._date = parts[0];
            entry1._prompt = parts[1];
            entry1._text = parts[2];

            _entries.Add(entry1);
        }
    }
}