using UnityEngine;

public class ObjectPassBetweenScenes : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
