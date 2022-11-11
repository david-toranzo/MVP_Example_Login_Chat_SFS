using Installers.Core;
using UnityEngine;

public class ItemChatMessagePlacerInstaller : MonoInstaller<IItemChatMessagePlacer>
{
    [SerializeField] private Transform _transformPlace;

    protected override IItemChatMessagePlacer GetData()
    {
        return new ItemChatMessagePlacer(_transformPlace);
    }
}
