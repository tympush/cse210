public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();



    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }



    public void HideRandomWords(int numberToHide)
    {
        int unhiddenWordCounter = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                unhiddenWordCounter += 1;
            }
        }

        if (unhiddenWordCounter > numberToHide)
        {
            while (numberToHide > 0)
            {
                int hideIndex = new Random().Next(0, _words.Count);

                if (!_words[hideIndex].IsHidden())
                {
                    _words[hideIndex].Hide();
                    numberToHide -= 1;
                }
            }
        }

        else
        {
            foreach (Word word in _words)
            {
                word.Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string displayList = "";

        foreach (Word word in _words)
        {
            displayList += word.GetDisplayText();
        }

        return displayList;
    }

    public bool IsCompletelyHidden()
    {
        bool listHidden = true;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                listHidden = false;
            }
        }
        return listHidden;
    }

}