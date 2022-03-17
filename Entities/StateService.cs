namespace BlazorApp.Entities;

public class StateService
{
    private string currentUser = "kajsa@ankeborg.com";
    public string CurrentUser
    {
        get => currentUser ?? string.Empty;
        set
        {
            currentUser = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    public void NotifyStateChanged() => OnChange?.Invoke();
}