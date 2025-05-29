namespace BackLab3.Services;

public class ConsoleMessageService : IMessageService
{
    public void Send(string message)
    {
        Console.WriteLine($"[MSG] {message}");
    }
}
