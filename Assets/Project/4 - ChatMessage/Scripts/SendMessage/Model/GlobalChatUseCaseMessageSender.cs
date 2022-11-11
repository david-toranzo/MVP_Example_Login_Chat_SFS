using Services.Core;

public class GlobalChatUseCaseMessageSender : IGlobalChatUseCaseMessageSender
{
    private IService<ChatMessage> _serviceSendGlobalMessage;

    public GlobalChatUseCaseMessageSender(IService<ChatMessage> serviceSendGlobalMessage)
    {
        _serviceSendGlobalMessage = serviceSendGlobalMessage;
    }

    public void SendChatMessage(string name, string message)
    {
        ChatMessage chatMessage = new ChatMessage(name, message);

        _serviceSendGlobalMessage.Send(chatMessage);

    }
}
