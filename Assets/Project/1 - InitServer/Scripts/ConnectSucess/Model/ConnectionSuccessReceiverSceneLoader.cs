using Observers.Core;
using ScenesLoaderSystem;

public class ConnectionSuccessReceiverSceneLoader
{
    private ISceneLoader _sceneLoader;
    private SceneData _sceneDataToLoad;

    public ConnectionSuccessReceiverSceneLoader(ISubscriberWithData<bool> receiverWithData, 
                                              ISceneLoader sceneLoader, 
                                              SceneData sceneDataToLoad)
    {
        _sceneLoader = sceneLoader;
        _sceneDataToLoad = sceneDataToLoad;

        receiverWithData.OnReceiveData += RequestSucessLoadScene;
    }

    private void RequestSucessLoadScene(bool isConnectionSuccess)
    {
        if (isConnectionSuccess)
            _sceneLoader.LoadScene(_sceneDataToLoad);
        else
            throw new System.Exception("This event didn't work as a failed connection event");
    }
}
