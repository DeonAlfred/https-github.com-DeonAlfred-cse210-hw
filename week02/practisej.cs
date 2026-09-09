using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
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
    
}