using Sfs2X.Core;

public class SFSEventConnectionLost : SFSObserverWithData<string>
{
    protected override string GetSFSEventType() => SFSEvent.CONNECTION_LOST;

    protected override void OnReceiveEventLogin(BaseEvent evt)
    {
        UnityEngine.Debug.Log((string)evt.Params["reason"]);

        OnReceiveData?.Invoke((string)evt.Params["reason"]);
    }
}

