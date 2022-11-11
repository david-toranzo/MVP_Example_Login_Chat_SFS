using Installers.Core;
using Observers.Core;
using UnityEngine;

public class MockSFSConnectInstaller : MonoInstaller<IServerConnector>
{
    [Header("References")]
    [SerializeField] private MonoInstaller<ISubscriberWithData<string>> _observerFailed;
    [SerializeField] private MonoInstaller<ISubscriberWithData<string>> _observerSucess;

    [Header("Data")]
    [SerializeField] private bool _connectionWasRight;

    protected override IServerConnector GetData()
    {
        IServerConnector serverConnector = new MockSFSConnect(_observerFailed.Data, _observerSucess.Data, _connectionWasRight);

        serverConnector.ConnectToServer();
        return serverConnector;
    }
}
