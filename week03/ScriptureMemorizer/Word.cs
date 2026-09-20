
public class Word
{
    //Declaration of private fields to store the text of the word and its hidden state.
    private string _text;
    private bool _isHidden;
    // Constructor to start word with its text and set its hidden state to false.
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    // Method to get the display text of the word. If the word is hidden, it returns "_____", otherwise it returns the actual text of the word.
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "_____";
        }

        return _text;
    }
}