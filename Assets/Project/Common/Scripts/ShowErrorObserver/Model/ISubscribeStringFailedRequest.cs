using System;

public interface ISubscribeStringFailedRequest
{
    Action<string> OnReceiveData { get; set; }
}