using Installers.Core;
using UnityEngine;

public class ChainOfRenposabilityMessageGetterInstaller : MonoInstaller<IMessageGetter>
{
    [SerializeField] private MonoInstaller<IChain>[] _chainsInstallers;

    protected override IMessageGetter GetData()
    {
        IChain[] chains = new IChain[_chainsInstallers.Length];

        for (int i = 0; i < _chainsInstallers.Length; i++)
        {
            chains[i] = _chainsInstallers[i].Data;
        }

        return new ChainOfRenposabilityMessageGetter(chains);
    }
}
