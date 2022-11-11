using Sfs2X.Core;
using Sfs2X.Entities;

public class SFSLoginSuccessEventSubscriber : SFSObserverWithData<string>
{
    protected override string GetSFSEventType() => SFSEvent.LOGIN;

    protected override void OnReceiveEventLogin(BaseEvent evt)
    {
        User user = (User)evt.Params["user"];

        OnReceiveData?.Invoke(user.Name);
    }
}
