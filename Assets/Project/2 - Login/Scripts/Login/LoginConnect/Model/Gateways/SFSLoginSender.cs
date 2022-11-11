using Services.Core;
using SmartFoxServer.Core;

public class SFSLoginSender : IService<string>
{
    public void Send(string dataType)
    {
        SFS.Instance.Send(new Sfs2X.Requests.LoginRequest(dataType));
    }
}
