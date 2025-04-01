namespace Bb.Interfaces
{
    public interface INamedFactory<TKey, TResult> : IFactory
    {

        TResult Create(TKey name);

    }

}
