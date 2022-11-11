using Installers.Core;
using Observers.Core;

public class SFSEventConnectionSuccessInstaller : MonoInstaller<ISubscriberWithData<bool>>
{
    protected override ISubscriberWithData<bool> GetData()
    {
        SFSEventConnection sFSEventConnection = new SFSEventConnection();

        sFSEventConnection.Subscribe();
        return sFSEventConnection;
    }
}
