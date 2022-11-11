public class CurrentUserPlayerGetter : IGetCurrentUser
{
    private IGetCurrentUser _getCurrentUserServer;

    public CurrentUserPlayerGetter(IGetCurrentUser getCurrentUserServer)
    {
        _getCurrentUserServer = getCurrentUserServer;
    }

    public string GetCurrentUser()
    {
        return _getCurrentUserServer.GetCurrentUser();
    }
}
