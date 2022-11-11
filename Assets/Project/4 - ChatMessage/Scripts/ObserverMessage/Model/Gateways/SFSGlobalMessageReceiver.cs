using Observers.Core;
using Sfs2X.Core;
using Sfs2X.Entities;
using SmartFoxServer.Core;
using System;

public class SFSGlobalMessageReceiver : ISubscriberWithData<ChatMessage>
{
    public Action<ChatMessage> OnReceiveData { get; set; }

    public void Subscribe()
    {
        SFS.Instance.AddEventListener(SFSEvent.PUBLIC_MESSAGE, OnReceivePublicMessage);
    }

    public void Dispose()
    {
        SFS.Instance.RemoveEventListener(SFSEvent.PUBLIC_MESSAGE, OnReceivePublicMessage);
    }

    private void OnReceivePublicMessage(BaseEvent evt)
    {
        User sender = (User)evt.Params["sender"];
        string message = (string)evt.Params["message"];

        CreateAndSendNewChatMessage(message, sender.Name);
    }

    private void CreateAndSendNewChatMessage(string message, string name)
    {
        ChatMessage chatMessage = new ChatMessage(name, message);

        OnReceiveData.Invoke(chatMessage);
    }
}
