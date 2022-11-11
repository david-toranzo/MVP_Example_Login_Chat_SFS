using Installers.Core;
using Observers.Core;
using UnityEngine;
using ServiceLocatorPattern;
using ScenesLoaderSystem;

public class LoginSuccessReceiverSceneLoaderInstaller : MonoInstaller<LoginSuccessReceiverSceneLoader>
{
    [Header("References")]
    [SerializeField] private MonoInstaller<ISubscriberWithData<string>> _receiverSubscriberInstaller;

    [Header("Data")]
    [SerializeField] private SceneDataSO _sceneDataToLoad;

    protected override LoginSuccessReceiverSceneLoader GetData()
    {
        ISceneLoader sceneLoader = ServiceLocator.Instance.Get<ISceneLoader>();

        return new LoginSuccessReceiverSceneLoader(_receiverSubscriberInstaller.Data, sceneLoader, _sceneDataToLoad.SceneData);
    }
}
