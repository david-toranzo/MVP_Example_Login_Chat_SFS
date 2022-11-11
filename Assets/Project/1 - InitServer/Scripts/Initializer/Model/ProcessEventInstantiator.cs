using UnityEngine;

public class ProcessEventInstantiator
{
    private GameObject _gameObjectProcessEvent;

    public ProcessEventInstantiator(GameObject gameObjectProcessEvent)
    {
        _gameObjectProcessEvent = gameObjectProcessEvent;

        InstantiateProcessEvent();
    }

    private void InstantiateProcessEvent()
    {
        GameObject.Instantiate(_gameObjectProcessEvent);
    }
}
