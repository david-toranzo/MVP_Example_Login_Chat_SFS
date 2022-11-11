using Installers.Core;
using Services.Core;

public class SFSMessageServiceSenderInstaller : MonoInstaller<IService<ChatMessage>>
{
    protected override IService<ChatMessage> GetData()
    {
        return new SFSMessageServiceSender();
    }
}
