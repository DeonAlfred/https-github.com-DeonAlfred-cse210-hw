

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        
        Entry entry1 = new Entry("Today I learned about classes in C#.");
        Entry entry2 = new Entry("I also practiced creating objects and methods.");

        myJournal.AddEntry(entry1);
        myJournal.AddEntry(entry2);

        Console.WriteLine("My Journal Entries:");
        myJournal.DisplayEntries();
    }

    public class Journal
    {
        private List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void DisplayEntries()
        {
            foreach (var entry in _entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
    }

    public class Entry
    {
        public string _text;

        public Entry(string text)
        {
            _text = text;
        }

        public override string ToString()
        {
            return _text;
        }
    }
    
}