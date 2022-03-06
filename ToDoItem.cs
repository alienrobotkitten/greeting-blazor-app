﻿namespace BlazorApp;
public class ToDoItem
{
    public string? Title { get; set; }
    public bool IsDone { get; set; }

    public ToDoItem(string title)
    {
        Title = title;
        IsDone=false;
    }
}
