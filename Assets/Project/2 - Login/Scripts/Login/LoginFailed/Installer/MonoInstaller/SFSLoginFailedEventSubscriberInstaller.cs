using Installers.Core;
using Observers.Core;

public class SFSLoginFailedEventSubscriberInstaller : MonoInstaller<ISubscriberWithData<string>>
{
    protected override ISubscriberWithData<string> GetData()
    {
        SFSLoginFailedEventSubscriber sFSEventLoginFailed = new SFSLoginFailedEventSubscriber();

        sFSEventLoginFailed.Subscribe();
        return sFSEventLoginFailed;
    }
}
