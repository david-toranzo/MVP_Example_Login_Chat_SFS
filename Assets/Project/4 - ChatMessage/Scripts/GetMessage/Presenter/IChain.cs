public interface IChain : IMessageGetter
{
    void SetNextChain(IChain chain);
}
