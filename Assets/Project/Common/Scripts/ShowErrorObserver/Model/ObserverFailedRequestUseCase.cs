using Observers.Core;
using System;

public class ObserverFailedRequestUseCase : ISubscribeStringFailedRequest
{
    public Action<string> OnReceiveData { get; set; }

    private ISubscriberWithData<string> _observerFailed;

    public ObserverFailedRequestUseCase(ISubscriberWithData<string> observerFailed)
    {
        _observerFailed = observerFailed;

        _observerFailed.OnReceiveData += ReceiveFailedRequest;
    }

    private void ReceiveFailedRequest(string message)
    {
        OnReceiveData?.Invoke(message);
    }
}
