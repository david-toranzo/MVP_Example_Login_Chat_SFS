using ButtonActions;
using Installers.Core;
using UnityEngine;

public class LoginPresenterInstaller : MonoInstaller<LoginPresenter>
{
    [Header("Presenters")]
    [SerializeField] private MonoInstaller<IButtonPresenter> _buttonPresenter;

    [Header("References")]
    [SerializeField] private MonoInstaller<ILogin> _loginUseCase;
    [SerializeField] private MonoInstaller<ILoginView> _viewLogin;

    protected override LoginPresenter GetData()
    {
        return new LoginPresenter(_loginUseCase.Data, _viewLogin.Data, _buttonPresenter.Data);
    }
}
