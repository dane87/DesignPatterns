using Singleton;

namespace SimpleLoggerTests;

// SimpleLogger.Instance is shared between all tests.
// It is suggested to create singletons as normal classes and add them as singletons with an IoC container.

public class Instance
{
    [Test]
    public void ShouldAlwaysBeTheSame()
    {
        var logger1 = SimpleLogger.Instance;
        var logger2 = SimpleLogger.Instance;

        Assert.That(logger2, Is.SameAs(logger1));
    }
}

public class Log
{
    [Test]
    public void ShouldAddMessageToLogs()
    {
        var logger = SimpleLogger.Instance;
        var message = "This is a log message";
        var expectedLogsCount = logger.Logs.Count + 1;

        logger.Log(message);

        Assert.That(logger.Logs, Has.Count.EqualTo(expectedLogsCount));
    }

    [Test]
    public void ShouldShareLogsForMultipleLoggers()
    {
        var logger1 = SimpleLogger.Instance;
        var logger2 = SimpleLogger.Instance;

        logger1.Log("Logger 1 log");
        logger1.Log("Logger 1 log");
        logger2.Log("Logger 2 log");

        Assert.That(logger1.Logs, Has.Count.EqualTo(logger2.Logs.Count));
    }

    [Test]
    public void ShouldBeThreadSafe()
    {
        var logger = SimpleLogger.Instance;
        var expectedLogsCount = logger.Logs.Count + 999;

        Parallel.For(0, 999, _ => logger.Log(DateTime.Now.ToString()));

        Assert.That(logger.Logs, Has.Count.EqualTo(expectedLogsCount));
    }
}
