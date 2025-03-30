namespace Bb.Extensions.EntryFullLogger
{

    public interface IRequestResponseLogModelCreator
    {

        RequestResponseLogModel LogModel { get; }
        
        string LogString();

    }


}
