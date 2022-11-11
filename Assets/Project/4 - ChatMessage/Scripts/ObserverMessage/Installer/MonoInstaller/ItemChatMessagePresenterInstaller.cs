using Installers.Core;
using ObjectPooling;
using UnityEngine;

public class ItemChatMessagePresenterInstaller : MonoInstaller<IItemChatMessagePresenter>
{
    [Header("References presenter")]
    [SerializeField] private MonoInstaller<IObjectPool> _objectPool;
    [SerializeField] private MonoInstaller<IItemChatMessagePlacer> _itemChatMessagePlacer;

    [Header("Get Message")]
    [SerializeField] private MonoInstaller<IMessageGetter> _getMessageInstaller;

    protected override IItemChatMessagePresenter GetData()
    {
        return new ItemChatMessagePresenter(_objectPool.Data, _itemChatMessagePlacer.Data, _getMessageInstaller.Data);
    }
}
