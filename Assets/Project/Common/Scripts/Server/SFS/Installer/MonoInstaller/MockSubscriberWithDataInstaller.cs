using Installers.Core;
using Observers.Core;

public class MockSubscriberWithDataInstaller : MonoInstaller<ISubscriberWithData<bool>>
{
    protected override ISubscriberWithData<bool> GetData()
    {
        return new MockSubscriberWithData<bool>();
    }
}
