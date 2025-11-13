using System;

public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt} - {_response}");
    }

    public override string ToString()
    {
        return $"{_date} | {_prompt} | {_response}";
    }
}