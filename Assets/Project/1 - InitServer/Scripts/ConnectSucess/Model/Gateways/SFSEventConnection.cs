using Sfs2X.Core;

public class SFSEventConnection : SFSObserverWithData<bool>
{
    protected override string GetSFSEventType() => SFSEvent.CONNECTION;

    protected override void OnReceiveEventLogin(BaseEvent evt)
    {
        UnityEngine.Debug.Log((bool)evt.Params["success"]);

        OnReceiveData?.Invoke((bool) evt.Params["success"]);
    }
}

