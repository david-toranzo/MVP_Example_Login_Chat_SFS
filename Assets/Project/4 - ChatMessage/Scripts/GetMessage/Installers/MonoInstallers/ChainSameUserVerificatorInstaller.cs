using Installers.Core;
using UnityEngine;

public class ChainSameUserVerificatorInstaller : MonoInstaller<IChain>
{
    [SerializeField] private MonoInstaller<IGetCurrentUser> _getIsTheSameUser;

    protected override IChain GetData()
    {
        return new ChainSameUserVerificator(_getIsTheSameUser.Data);
    }
}
