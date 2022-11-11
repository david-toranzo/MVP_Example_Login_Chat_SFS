using UnityEngine;

public class ItemChatMessagePlacer : IItemChatMessagePlacer
{
    private Transform _transformPlace;

    public ItemChatMessagePlacer(Transform transformPlace)
    {
        _transformPlace = transformPlace;
    }

    public void SetGameObjectPlace(GameObject gameObject)
    {
        gameObject.transform.parent = _transformPlace;

        gameObject.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
    }
}
