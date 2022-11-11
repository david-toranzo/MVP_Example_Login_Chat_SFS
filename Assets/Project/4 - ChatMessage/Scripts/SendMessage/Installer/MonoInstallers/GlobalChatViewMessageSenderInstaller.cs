using Installers.Core;
using UnityEngine;

public class GlobalChatViewMessageSenderInstaller : MonoInstaller<IGlobalChatViewMessageSender>
{
    [SerializeField] private GlobalChatMessageSenderView _globalChatViewMessageSender;

    protected override IGlobalChatViewMessageSender GetData()
    {
        return _globalChatViewMessageSender;
    }
}
