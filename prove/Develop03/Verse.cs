class Verse
{
    private string reference;
    private List<Word> words;

    public Verse(string reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Write(reference + " ");
        foreach (Word word in words)
        {
            word.Display();
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public bool HasHiddenWords()
    {
        return words.Any(w => !w.IsHidden);
    }

    public void HideRandomWord()
    {
        Random random = new Random( );
        List<Word> hiddenWords = words.Where(w => w.IsHidden).ToList();
        List<Word> visibleWords = words.Where(w => !w.IsHidden).ToList();

        if (visibleWords.Count > 0)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].IsHidden = true;
        }
    }
}
