namespace Bb.Middleware.EntryFullLogger
{

    public interface IRequestResponseLogger
    {
        void Log(IRequestResponseLogModelCreator logCreator);
    }


}
