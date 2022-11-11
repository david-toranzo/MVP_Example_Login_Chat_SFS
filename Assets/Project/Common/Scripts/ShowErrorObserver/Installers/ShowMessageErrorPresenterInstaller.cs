using Installers.Core;
using Observers.Core;
using UnityEngine;

public class ShowMessageErrorPresenterInstaller : MonoInstaller<ShowMessageErrorPresenter>
{
    [SerializeField] private MonoInstaller<IViewMessageErrorShowPlacer> _showMessageError;
    [SerializeField] private MonoInstaller<ISubscribeStringFailedRequest> _subscribeFailed;

    protected override ShowMessageErrorPresenter GetData()
    {
        return new ShowMessageErrorPresenter(_showMessageError.Data, _subscribeFailed.Data);
    }
}
