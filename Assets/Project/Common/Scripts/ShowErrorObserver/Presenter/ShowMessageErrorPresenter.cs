
public class ShowMessageErrorPresenter 
{
    private IViewMessageErrorShowPlacer _showMessageError;
    private ISubscribeStringFailedRequest _subscribeFailed;

    public ShowMessageErrorPresenter(IViewMessageErrorShowPlacer showMessageError, ISubscribeStringFailedRequest subscribeFailed)
    {
        _showMessageError = showMessageError;
        _subscribeFailed = subscribeFailed;

        _subscribeFailed.OnReceiveData += ShowError;
    }

    private void ShowError(string message)
    {
        _showMessageError.SetInformationAboutRequestServer(message);
    }
}
