using Installers.Core;
using Observers.Core;

public class SFSLoginSuccessEventSubscriberInstaller : MonoInstaller<ISubscriberWithData<string>>
{
    protected override ISubscriberWithData<string> GetData()
    {
        SFSLoginSuccessEventSubscriber sFSEventLoginSucess = new SFSLoginSuccessEventSubscriber();

        sFSEventLoginSucess.Subscribe();
        return sFSEventLoginSucess;
    }
}
