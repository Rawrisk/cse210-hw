class Word
{
    public string Value;
    public bool IsHidden;

    public Word(string value)
    {
        Value = value;
        IsHidden = false;
    }

    public void Display()
    {
        if (IsHidden)
            Console.Write("*****");
        else
            Console.Write(Value);
    }
}