using Singleton;

var logger1 = SimpleLogger.Instance;
var logger2 = SimpleLogger.Instance;

logger1.Log("First log");
logger1.Log("Second log");
logger2.Log("Third log");
logger2.Log("Fourth log");
logger2.Log("Fifth log");

Console.WriteLine($"Loggers are equal? {logger1 == logger2}"); // True
Console.WriteLine($"Logger 1: {logger1.Logs.Count}"); // 5
Console.WriteLine($"Logger 2: {logger2.Logs.Count}"); // 5
