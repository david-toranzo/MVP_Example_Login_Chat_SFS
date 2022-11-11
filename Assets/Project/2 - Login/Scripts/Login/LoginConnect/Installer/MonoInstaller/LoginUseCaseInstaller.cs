using Installers.Core;
using Services.Core;
using UnityEngine;

public class LoginUseCaseInstaller : MonoInstaller<ILogin>
{
    [Header("References")]
    [SerializeField]
    private MonoInstaller<IService<string>> _loginServerData;

    protected override ILogin GetData()
    {
        return new LoginUseCase(_loginServerData.Data);
    }
}
