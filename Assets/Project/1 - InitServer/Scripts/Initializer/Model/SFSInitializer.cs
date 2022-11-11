using Sfs2X;
using SmartFoxServer.Core;

public class SFSInitializer 
{
    public SFSInitializer()
    {
        InitializeSFS();
    }

    public void InitializeSFS()
    {
        SFS.Instance = new SmartFox();
    }
}
