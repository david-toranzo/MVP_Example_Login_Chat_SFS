using Installers.Core;

public class SFSInitializerInstaller : MonoInstaller<SFSInitializer>
{
    protected override SFSInitializer GetData()
    {
        return new SFSInitializer();
    }
}
