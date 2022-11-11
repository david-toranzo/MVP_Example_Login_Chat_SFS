using Installers.Core;
using UnityEngine;

public class SFSConnectorInstaller : MonoInstaller<IServerConnector>
{
    [Header("Data")]
    [SerializeField] private string _host = "127.0.0.1";
    [SerializeField] private int _tcpPort = 9933;
    [SerializeField] private string _zone = "SFSExample";

    protected override IServerConnector GetData()
    {
        IServerConnector serverConnector = new SFSConnector(_host, _tcpPort, _zone);

        serverConnector.ConnectToServer();
        return serverConnector;
    }
}
