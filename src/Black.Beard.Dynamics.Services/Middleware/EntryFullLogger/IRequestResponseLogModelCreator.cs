namespace Bb.Middleware.EntryFullLogger
{

    public interface IRequestResponseLogModelCreator
    {

        RequestResponseLogModel LogModel { get; }
        
        string LogString();

    }


}
