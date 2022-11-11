using UnityEngine;
using ScenesLoaderSystem;
using ServiceLocatorPattern;

public class WaitTimeSceneLoader : MonoBehaviour
{
    [SerializeField] private SceneDataSO _sceneData;

    void Start()
    {
        ISceneLoader sceneLoader = ServiceLocator.Instance.Get<ISceneLoader>();

        sceneLoader.LoadScene(_sceneData.SceneData);
    }
}
