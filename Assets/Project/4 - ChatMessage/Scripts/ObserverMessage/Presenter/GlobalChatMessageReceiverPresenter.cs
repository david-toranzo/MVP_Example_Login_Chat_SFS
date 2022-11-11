public class GlobalChatMessageReceiverPresenter 
{
    private IGlobalChatMessageReceiver _observerMessageUseCase;
    private IItemChatMessagePresenter _itemChatMessage;

    public GlobalChatMessageReceiverPresenter(IGlobalChatMessageReceiver observerMessageUseCase, 
                                              IItemChatMessagePresenter itemChatMessage)
    {
        _observerMessageUseCase = observerMessageUseCase;
        _itemChatMessage = itemChatMessage;

        _observerMessageUseCase.OnReceiveChatMessage += ReceiveNewChatMessage;
    }

    private void ReceiveNewChatMessage(ChatMessage chatMessage)
    {
        _itemChatMessage.ReceiveNewMessage(chatMessage);
        UnityEngine.Debug.Log(chatMessage.NameUser + " " + chatMessage.Message);
    }
}
