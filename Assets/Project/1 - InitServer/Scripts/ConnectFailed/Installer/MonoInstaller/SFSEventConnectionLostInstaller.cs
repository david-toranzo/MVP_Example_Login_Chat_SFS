using Installers.Core;
using Observers.Core;

public class SFSEventConnectionLostInstaller : MonoInstaller<ISubscriberWithData<string>>
{
    protected override ISubscriberWithData<string> GetData()
    {
        SFSEventConnectionLost sFSEventConnectionLost = new SFSEventConnectionLost();

        sFSEventConnectionLost.Subscribe();
        return sFSEventConnectionLost;
    }
}
