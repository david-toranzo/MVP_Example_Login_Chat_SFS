using Sfs2X;
using SmartFoxServer.Core;
using UnityEngine;

public class SFSEventsProcessor : MonoBehaviour
{
    private SmartFox _sfs;

    private void Awake()
    {
        _sfs = SFS.Instance;
    }

    private void Update()
    {
        if (_sfs != null)
            _sfs.ProcessEvents();
    }
}
