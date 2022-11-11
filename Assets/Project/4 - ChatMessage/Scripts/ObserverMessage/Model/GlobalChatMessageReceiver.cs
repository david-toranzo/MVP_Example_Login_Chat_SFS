using Observers.Core;
using System;

public class GlobalChatMessageReceiver : IGlobalChatMessageReceiver
{
    private ISubscriberWithData<ChatMessage> _subcribeChatMessage;

    public Action<ChatMessage> OnReceiveChatMessage { get; set; }

    public GlobalChatMessageReceiver(ISubscriberWithData<ChatMessage> subcribeChatMessage)
    {
        _subcribeChatMessage = subcribeChatMessage;

        _subcribeChatMessage.OnReceiveData += ReceiveNewMessage;
    }

    private void ReceiveNewMessage(ChatMessage chatMessage)
    {
        OnReceiveChatMessage?.Invoke(chatMessage);
    }
}
