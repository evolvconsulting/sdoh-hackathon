namespace Portal.Provider.Services;

public class AppBarService
{
    public string CurrentPageName { get; set; }
    public bool BackButtonEnabled { get; set; }
    public string  NavigationRoute { get; set; }

    public void SetSettings(string currentPageName, bool backButtonEnabled = false, string? navigationRoute = null)
    {
        CurrentPageName = currentPageName;
        BackButtonEnabled = backButtonEnabled;
        NavigationRoute = navigationRoute;

    }
}
