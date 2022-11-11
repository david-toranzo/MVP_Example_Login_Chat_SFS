using Installers.Core;
using UnityEngine;

public class CurrentUserPlayerGetterInstaller : MonoInstaller<IGetCurrentUser>
{
    [SerializeField] private MonoInstaller<IGetCurrentUser> _getUserFromServer;

    protected override IGetCurrentUser GetData()
    {
        return new CurrentUserPlayerGetter(_getUserFromServer.Data);
    }
}
