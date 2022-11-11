using Sfs2X.Core;
public class SFSLoginFailedEventSubscriber : SFSObserverWithData<string>
{
    protected override string GetSFSEventType() => SFSEvent.LOGIN_ERROR;

    protected override void OnReceiveEventLogin(BaseEvent evt)
    {
        OnReceiveData?.Invoke((string)evt.Params["errorMessage"]);
    }
}
