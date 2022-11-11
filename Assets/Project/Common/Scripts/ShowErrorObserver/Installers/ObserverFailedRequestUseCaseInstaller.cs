using Installers.Core;
using Observers.Core;
using UnityEngine;

public class ObserverFailedRequestUseCaseInstaller : MonoInstaller<ISubscribeStringFailedRequest>
{
    [Header("References")]
    [SerializeField] private MonoInstaller<ISubscriberWithData<string>> _observerFailed;

    protected override ISubscribeStringFailedRequest GetData()
    {
        return new ObserverFailedRequestUseCase(_observerFailed.Data);
    }
}
