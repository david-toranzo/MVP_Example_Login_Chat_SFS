using Services.Core;
using Sfs2X.Requests;
using SmartFoxServer.Core;

public class SFSMessageServiceSender : IService<ChatMessage>
{
    public void Send(ChatMessage data)
    {
        SFS.Instance.Send(new PublicMessageRequest(data.Message));
    }
}
