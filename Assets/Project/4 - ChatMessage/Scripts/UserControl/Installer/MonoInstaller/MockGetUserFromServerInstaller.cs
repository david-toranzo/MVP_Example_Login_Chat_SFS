using Installers.Core;

public class MockGetUserFromServerInstaller : MonoInstaller<IGetCurrentUser>
{
    protected override IGetCurrentUser GetData()
    {
        return new MockGetUserFromServer();
    }
}
