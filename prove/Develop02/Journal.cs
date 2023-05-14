using System;

class Journal {
    private List<Entry> entries;

    public Journal() {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry) {
        entries.Add(entry);
    }

    public void DisplayEntries() {
        foreach (Entry entry in entries) {
            Console.WriteLine($"{entry.Date}: {entry.Prompt}\n{entry.Response}\n");
        }
    }

    public void SaveToFile(string fileName) {
        using (StreamWriter writer = new StreamWriter(fileName)) {
            foreach (Entry entry in entries) {
                writer.WriteLine($"{entry.Prompt}|{entry.Response}|{entry.Date}");
            }
        }
    }

    public void LoadFromFile(string fileName) {
        entries.Clear();
        using (StreamReader reader = new StreamReader(fileName)) {
            while (!reader.EndOfStream) {
                string[] fields = reader.ReadLine().Split('|');
                Entry entry = new Entry(fields[0], fields[1], fields[2]);
                entries.Add(entry);
            }
        }
    }
}