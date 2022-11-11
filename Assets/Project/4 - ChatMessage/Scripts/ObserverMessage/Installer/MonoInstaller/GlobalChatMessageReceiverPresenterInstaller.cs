using Installers.Core;
using UnityEngine;

public class GlobalChatMessageReceiverPresenterInstaller : MonoInstaller<GlobalChatMessageReceiverPresenter>
{
    [SerializeField] private MonoInstaller<IGlobalChatMessageReceiver> _observerMessageUseCase;
    [SerializeField] private MonoInstaller<IItemChatMessagePresenter> _itemChatMessage;

    protected override GlobalChatMessageReceiverPresenter GetData()
    {
        return new GlobalChatMessageReceiverPresenter(_observerMessageUseCase.Data, _itemChatMessage.Data);
    }
}
