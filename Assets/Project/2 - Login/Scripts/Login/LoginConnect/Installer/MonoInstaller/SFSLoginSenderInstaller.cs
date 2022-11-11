using Installers.Core;
using Services.Core;

public class SFSLoginSenderInstaller : MonoInstaller<IService<string>>
{
    protected override IService<string> GetData()
    {
        return new SFSLoginSender();
    }
}
