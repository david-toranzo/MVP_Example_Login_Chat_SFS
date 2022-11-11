using ButtonActions;

public class LoginPresenter
{
    private ILoginView _loginView;
    private ILogin _loginUseCase;

    public LoginPresenter(ILogin loginPresenter, ILoginView loginView, IButtonPresenter buttonPresenter)
    {
        _loginUseCase = loginPresenter;
        _loginView = loginView;

        buttonPresenter.OnButtonTriggered += StartWithNewLogin;
    }

    private void StartWithNewLogin()
    {
        _loginUseCase.Login(_loginView.GetNameUser());
    }
}
