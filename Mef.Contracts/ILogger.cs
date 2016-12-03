namespace Mef.Contracts
{
    public interface ILogger
    {
        string LogType { get; }

        string LogMessage(string message);
    }
}
