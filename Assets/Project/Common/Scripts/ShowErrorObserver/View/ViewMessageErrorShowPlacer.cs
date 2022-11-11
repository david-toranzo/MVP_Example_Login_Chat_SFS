using UnityEngine;
using UnityEngine.UI;

public class ViewMessageErrorShowPlacer : MonoBehaviour , IViewMessageErrorShowPlacer
{
    [SerializeField] private Text _textInfoRequest;

    public void SetInformationAboutRequestServer(string message)
    {
        _textInfoRequest.text = message;
    }
}
