using UnityEngine;
using TMPro;

public class ItemChatMessageInfoSetter : MonoBehaviour, IItemChatMessageInfoSetter
{
    [SerializeField] private TMP_Text _textMessage;

    public void SetMessageItem(string message)
    {
        _textMessage.text = message;
    }
}
