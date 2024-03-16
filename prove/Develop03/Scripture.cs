public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference; 

        foreach (string elem in text.Split(' '))
        {
            Word elem_w = new Word(elem);
            _words.Add(elem_w);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int not_hidden_wordes = 0;

        foreach (Word elem in _words)
        {
            if (elem.IsHidden())
            {
                continue;
            }
            else
            {
                not_hidden_wordes++;
            }
        }

        if (numberToHide > not_hidden_wordes)
        {
            numberToHide = not_hidden_wordes;
        }

        Random rnd = new Random();

        int count = 0;

        while (count != numberToHide)
        {
            int rnd_num = rnd.Next(0, _words.Count);

            if (_words[rnd_num].IsHidden())
            {
                continue;
            }
            else
            {
                _words[rnd_num].Hide();
                count++;
            }
        }
    }

    public string GetDisplayText()
    {
        Console.Clear();

        string text = _reference.GetDisplayText();
        
        foreach (Word elem in _words)
        {
            text += $" {elem.GetDisplayText()}";
        }
        
        return text;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word elem in _words)
        {
            if (elem.IsHidden())
            {
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}