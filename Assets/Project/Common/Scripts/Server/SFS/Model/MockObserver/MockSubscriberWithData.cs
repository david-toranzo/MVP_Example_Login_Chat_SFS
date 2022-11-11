using Observers.Core;
using System;

public class MockSubscriberWithData<DataType> : ISubscriberWithData<DataType>
{
    public Action<DataType> OnReceiveData 
    { 
        get;
        set;
    }

    public void Dispose()
    {

    }

    public void Subscribe()
    {
        
    }
}
