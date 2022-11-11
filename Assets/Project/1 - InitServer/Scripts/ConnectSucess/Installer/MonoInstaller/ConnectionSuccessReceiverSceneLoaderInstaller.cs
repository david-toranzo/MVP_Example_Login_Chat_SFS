using Installers.Core;
using Observers.Core;
using UnityEngine;
using ServiceLocatorPattern;
using ScenesLoaderSystem;

public class ConnectionSuccessReceiverSceneLoaderInstaller : MonoInstaller<ConnectionSuccessReceiverSceneLoader>
{
    [Header("References")]
    [SerializeField] private MonoInstaller<ISubscriberWithData<bool>> _receiverSubscriberInstaller;

    [Header("Data")]
    [SerializeField] private SceneDataSO _sceneDataToLoad;

    protected override ConnectionSuccessReceiverSceneLoader GetData()
    {
        ISceneLoader sceneLoader = ServiceLocator.Instance.Get<ISceneLoader>();

        return new ConnectionSuccessReceiverSceneLoader(_receiverSubscriberInstaller.Data, sceneLoader, _sceneDataToLoad.SceneData);
    }
}
