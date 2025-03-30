namespace Bb.Extensions.EntryFullLogger
{

    public interface IRequestResponseLogger
    {
        void Log(IRequestResponseLogModelCreator logCreator);
    }


}
