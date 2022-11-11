using Installers.Core;

public class ChainDefaultInstaller : MonoInstaller<IChain>
{
    protected override IChain GetData()
    {
        return new ChainDefault();
    }
}
