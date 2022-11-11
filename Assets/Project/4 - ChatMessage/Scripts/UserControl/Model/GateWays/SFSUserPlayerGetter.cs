using SmartFoxServer.Core;

public class SFSUserPlayerGetter : IGetCurrentUser
{
    public string GetCurrentUser()
    {
        return SFS.Instance.MySelf.Name;
    }
}
