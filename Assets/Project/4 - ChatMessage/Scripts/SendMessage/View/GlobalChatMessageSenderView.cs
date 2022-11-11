using UnityEngine;
using UnityEngine.UI;

public class GlobalChatMessageSenderView : MonoBehaviour, IGlobalChatViewMessageSender
{
    [SerializeField] private InputField _inputMessage;
    [SerializeField] private InputField _inputNameMessage;

    public string GetMessage()
    {
        return _inputMessage.text;
    }

    public string GetNameMessage()
    {
        return _inputNameMessage.text;
    }

    public void ResetMessage()
    {
        _inputMessage.text = "";
        _inputNameMessage.text = "";
    }
}
