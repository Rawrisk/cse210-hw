class Scripture
{
    private List<Verse> verses;

    public Scripture(string reference, string text)
    {
        verses = new List<Verse>();
        ParseReferenceAndText(reference, text);
    }

    private void ParseReferenceAndText(string reference, string text)
    {
        string[] verseReferences = reference.Split(',');
        string[] verseTexts = text.Split(';');

        for (int i = 0; i < verseReferences.Length; i++)
        {
            Verse verse = new Verse(verseReferences[i].Trim(), verseTexts[i].Trim());
            verses.Add(verse);
        }
    }

    public void Display()
    {
        foreach (Verse verse in verses)
        {
            verse.Display();
        }
    }

    public bool HasHiddenWords()
    {
        return verses.Any(v => v.HasHiddenWords());
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int verseIndex = random.Next(verses.Count);
        verses[verseIndex].HideRandomWord();
    }
}