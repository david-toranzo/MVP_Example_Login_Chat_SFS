using Observers.Core;

public class MockSFSConnect : IServerConnector
{
    private ISubscriberWithData<string> _observerFailed;
    private ISubscriberWithData<string> _observerSucess;

    private bool _connectionWasRight;

    public MockSFSConnect(ISubscriberWithData<string> observerFailed, 
                          ISubscriberWithData<string> observerSucess, 
                          bool connectionWasRight)
    {
        _observerFailed = observerFailed;
        _observerSucess = observerSucess;
        _connectionWasRight = connectionWasRight;


    }

    public void ConnectToServer()
    {
        if(_connectionWasRight)
            _observerSucess.OnReceiveData?.Invoke("The connection was right");
        else
            _observerFailed.OnReceiveData?.Invoke("The connection was fail");
    }
}
