public class LogManager
{
    private static LogManager Instance = new LogManager();
    private LogManager()
    {
    }

    public static LogManager GetInstance()
    {
        return Instance;
    }
    public void write(String message)
    {
        Console.WriteLine("Writing a message to the log: " + message);
    }
}
