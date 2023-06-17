using NLog;

namespace Core;

public class LogSession
{
    public static LogSession CurrentSession { get; private set; } = new LogSession();

    private readonly Logger logger;

    private LogSession()
    {
        logger = LogManager.GetCurrentClassLogger();
    }

    public void Info(string message)
    {
        logger.Info(message);
    }

    public void Debug(string message)
    {
        logger.Debug(message);
    }

    public void Error(string message)
    {
        logger.Error(message);
    }
}