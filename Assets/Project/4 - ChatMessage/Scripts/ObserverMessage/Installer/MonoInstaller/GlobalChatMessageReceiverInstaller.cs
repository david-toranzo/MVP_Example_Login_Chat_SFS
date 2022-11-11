using Installers.Core;
using Observers.Core;
using UnityEngine;

public class GlobalChatMessageReceiverInstaller : MonoInstaller<IGlobalChatMessageReceiver>
{
    [SerializeField] private MonoInstaller<ISubscriberWithData<ChatMessage>> _observerChatMessage;

    protected override IGlobalChatMessageReceiver GetData()
    {
        return new GlobalChatMessageReceiver(_observerChatMessage.Data);
    }
}
