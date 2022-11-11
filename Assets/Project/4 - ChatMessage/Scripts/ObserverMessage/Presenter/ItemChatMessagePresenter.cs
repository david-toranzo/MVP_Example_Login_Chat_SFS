using ObjectPooling;
using UnityEngine;

public class ItemChatMessagePresenter : IItemChatMessagePresenter
{
    private IObjectPool _objectPool;
    private IItemChatMessagePlacer _itemChatMessagePlacer;
    private IMessageGetter _getMessage;

    public ItemChatMessagePresenter(IObjectPool objectPool, IItemChatMessagePlacer itemChatMessagePlacer, IMessageGetter getMessage)
    {
        _objectPool = objectPool;
        _itemChatMessagePlacer = itemChatMessagePlacer;
        _getMessage = getMessage;
    }

    public void ReceiveNewMessage(ChatMessage chatMessage)
    {
        GameObject newObject = _objectPool.GetGameObject();

        _itemChatMessagePlacer.SetGameObjectPlace(newObject);
        SetMessageToObject(newObject, chatMessage);
    }

    private void SetMessageToObject(GameObject newPrefabChat, ChatMessage chatMessage)
    {
        IItemChatMessageInfoSetter itemChatMessageInfoSetter = newPrefabChat.GetComponent<IItemChatMessageInfoSetter>();
        string message = _getMessage.GetMessage(chatMessage);

        itemChatMessageInfoSetter.SetMessageItem(message);
    }
}
