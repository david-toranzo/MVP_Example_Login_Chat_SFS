using Installers.Core;
using UnityEngine;

public class ViewShowMessageErrorPlacerInstaller : MonoInstaller<IViewMessageErrorShowPlacer>
{
    [SerializeField] private ViewMessageErrorShowPlacer _loginViewShowMessage;

    protected override IViewMessageErrorShowPlacer GetData()
    {
        return _loginViewShowMessage;
    }
}
