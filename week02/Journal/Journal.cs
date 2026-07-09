using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }


    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }


    public void SaveToFile(string filename)
    {
        using (StreamWriter file = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                file.WriteLine(
                    entry._date + "|" +
                    entry._promptText + "|" +
                    entry._entryText
                );
            }
        }
    }


    public void LoadFromFile(string filename)
    {
        _entries.Clear();


        string[] lines = File.ReadAllLines(filename);


        foreach (string line in lines)
        {
            string[] parts = line.Split("|");


            Entry entry = new Entry();

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];


            _entries.Add(entry);
        }
    }
}

//Extra feature: this calss manages all journal entries in one place, it allows the program allows the program to save and load complete journal records from a file. 