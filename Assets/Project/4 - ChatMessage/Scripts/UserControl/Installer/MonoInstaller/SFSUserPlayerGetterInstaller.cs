using Installers.Core;

public class SFSUserPlayerGetterInstaller : MonoInstaller<IGetCurrentUser>
{
    protected override IGetCurrentUser GetData()
    {
        return new SFSUserPlayerGetter();
    }
}
