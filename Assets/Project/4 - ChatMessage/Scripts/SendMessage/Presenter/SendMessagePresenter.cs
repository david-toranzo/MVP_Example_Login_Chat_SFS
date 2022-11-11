using ButtonActions;

public class SendMessagePresenter 
{
    private IGlobalChatUseCaseMessageSender _useCaseChatMessage;
    private IGlobalChatViewMessageSender _chatViewMessageSender;
    private IButtonPresenter _buttonPresenter;

    public SendMessagePresenter(IGlobalChatUseCaseMessageSender useCaseChatMessage, 
                                IGlobalChatViewMessageSender chatViewMessageSender, 
                                IButtonPresenter buttonPresenter)
    {
        _useCaseChatMessage = useCaseChatMessage;
        _chatViewMessageSender = chatViewMessageSender;
        _buttonPresenter = buttonPresenter;

        _buttonPresenter.OnButtonTriggered += SendMessage;
    }

    private void SendMessage()
    {
        string message = _chatViewMessageSender.GetMessage();
        string name = _chatViewMessageSender.GetNameMessage();

        _useCaseChatMessage.SendChatMessage(name, message);

        _chatViewMessageSender.ResetMessage();
    }
}
