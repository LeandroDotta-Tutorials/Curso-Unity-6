public class Log
{
    private enum LogType { Info, Warning, Error }

    public void Info(string message)
    {
        Console.WriteLine($"[{LogType.Info}] {message}");
    }

    public void Warn(string message)
    {
        Console.WriteLine($"[{LogType.Warning}] {message}");
    }
    
    public void Error(string message)
    {
        Console.WriteLine($"[{LogType.Error}] {message}");
    }
}