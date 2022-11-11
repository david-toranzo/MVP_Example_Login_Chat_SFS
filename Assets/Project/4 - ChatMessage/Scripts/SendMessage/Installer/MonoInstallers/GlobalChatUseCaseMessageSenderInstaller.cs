using Installers.Core;
using Services.Core;
using UnityEngine;

public class GlobalChatUseCaseMessageSenderInstaller : MonoInstaller<IGlobalChatUseCaseMessageSender>
{
    [SerializeField] private MonoInstaller<IService<ChatMessage>> _serviceSendGlobalMessage;

    protected override IGlobalChatUseCaseMessageSender GetData()
    {
        return new GlobalChatUseCaseMessageSender(_serviceSendGlobalMessage.Data);
    }
}
