using Sfs2X.Util;
using SmartFoxServer.Core;

public class SFSConnector : IServerConnector
{
    private string _host = "127.0.0.1";
    private int _tcpPort = 9933;
    private string _zone = "";

    public SFSConnector(string host, int tcpPort, string zone)
    {
        _host = host;
        _tcpPort = tcpPort;
        _zone = zone;
    }

    public void ConnectToServer()
    {
        ConfigData cfg = new ConfigData();

        cfg.Host = _host;
        cfg.Port = _tcpPort;
        cfg.Zone = _zone;

        ConnectSFS(cfg);
    }

    public void ConnectSFS(ConfigData configData)
    {
        UnityEngine.Debug.Log("Connect : " + configData.Zone + " " + configData.Host);

        SFS.Instance.Connect(configData);
    }

}
