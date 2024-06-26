namespace Singleton;

// sealed keyword prevents inheritance
public sealed class SimpleLogger
{
    private readonly List<string> _logs = [];

    private static readonly object _lock = new();

    // private constructor prevents instantiation
    private SimpleLogger()
    {
    }

    public static SimpleLogger Instance { get; } = new SimpleLogger();

    public IReadOnlyList<string> Logs
    {
        get
        {
            // only allow 1 thread at a time to read _logs
            lock (_lock)
            {
                return _logs.AsReadOnly();
            }
        }
    }

    public void Log(string message)
    {
        // only allow 1 thread at a time to add a Log
        lock (_lock)
        {
            _logs.Add($"{DateTime.Now}: {message}");
        }
    }
}
