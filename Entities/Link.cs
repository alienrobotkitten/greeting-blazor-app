using BlazorApp.Entities;

namespace BlazorApp;

public class Link
{
    public string Title { get; set; }
    public string Symbol { get; set; }
    public View SetState { get; set; }


    public Link(string title, string symbol, View setState)
    {
        Title = title;
        SetState = setState;
        Symbol = symbol;
    }
}