using Installers.Core;
using Observers.Core;

public class SFSGlobalMessageReceiverInstaller : MonoInstaller<ISubscriberWithData<ChatMessage>>
{
    protected override ISubscriberWithData<ChatMessage> GetData()
    {
        SFSGlobalMessageReceiver sFSGlobalMessageReceiver = new SFSGlobalMessageReceiver();

        sFSGlobalMessageReceiver.Subscribe();
        return sFSGlobalMessageReceiver;
    }
}
