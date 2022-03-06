namespace BlazorApp;

public class Link
{
    public string Title { get; set; }
    public string Route { get; set; }
    public string Symbol { get; set; }


    public Link(string title, string route, string symbol)
    {
        Title = title;
        Route = route;
        Symbol = symbol;
    }
}