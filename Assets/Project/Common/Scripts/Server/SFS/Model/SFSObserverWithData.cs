using Observers.Core;
using Sfs2X.Core;
using SmartFoxServer.Core;
using System;

public abstract class SFSObserverWithData<DataType> : ISubscriberWithData<DataType>
{
    public Action<DataType> OnReceiveData { get; set; }

    protected abstract string GetSFSEventType();

    protected abstract void OnReceiveEventLogin(BaseEvent evt);

    public void Subscribe()
    {
        SFS.Instance.AddEventListener(GetSFSEventType(), OnReceiveEventLogin);
        UnityEngine.Debug.Log("Subscribe : " + this);
    }

    public void Dispose()
    {
        SFS.Instance.RemoveAllEventListeners();
    }
}
