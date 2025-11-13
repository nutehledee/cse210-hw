using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public void HideRandomWords(int count) { }
    public string GetDisplayText() { return ""; }
    public bool IsCompletelyHidden() { return false; }
}