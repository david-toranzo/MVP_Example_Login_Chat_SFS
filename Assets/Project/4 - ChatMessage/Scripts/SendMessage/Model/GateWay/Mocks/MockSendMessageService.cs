using Mocks.Networking;

public class MockSendMessageService : MockService<ChatMessage, ChatMessage>
{
    protected override ChatMessage GetReturnedData()
    {
        return _data;
    }
}
