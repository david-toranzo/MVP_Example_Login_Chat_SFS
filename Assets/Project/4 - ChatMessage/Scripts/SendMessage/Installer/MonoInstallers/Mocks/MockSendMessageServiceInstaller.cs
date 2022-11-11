using Installers.Core;
using Services.Core;

public class MockSendMessageServiceInstaller : MonoInstaller<IService<ChatMessage>>
{
    protected override IService<ChatMessage> GetData()
    {
        return new MockSendMessageService();
    }
}
