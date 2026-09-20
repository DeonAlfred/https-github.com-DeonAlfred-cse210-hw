public class Reference
{   // Represents a scripture reference with book, chapter, and verse.
    private string _book;
    private int _verse;
    private int _chapter;
// constructor to initialize the reference with book, chapter, and verse.
    public Reference(string book, int verse, int chapter)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
// Short method to get the display text of the reference in the format "Book Chapter:Verse".
    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}