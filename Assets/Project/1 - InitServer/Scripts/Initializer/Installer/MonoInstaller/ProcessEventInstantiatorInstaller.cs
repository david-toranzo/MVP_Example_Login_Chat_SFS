using Installers.Core;
using UnityEngine;

public class ProcessEventInstantiatorInstaller : MonoInstaller<ProcessEventInstantiator>
{
    [SerializeField] private GameObject _gameObjectProcessEvent;

    protected override ProcessEventInstantiator GetData()
    {
        return new ProcessEventInstantiator(_gameObjectProcessEvent);
    }
}
