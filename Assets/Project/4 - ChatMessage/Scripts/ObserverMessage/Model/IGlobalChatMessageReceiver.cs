using System;

public interface IGlobalChatMessageReceiver
{
    Action<ChatMessage> OnReceiveChatMessage { get; set; }
}