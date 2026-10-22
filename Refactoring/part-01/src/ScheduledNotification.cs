namespace RefactoringLab;

public class ScheduledNotification : INotificationChannel
{
     private readonly INotificationChannel _channel;
    private readonly DateTime _sendAt;

    public ScheduledNotification(INotificationChannel channel, DateTime sendAt)
    {
        _channel = channel;
        _sendAt = sendAt;
    }

    public void Send(string to, string message)
    {
    Console.Write($"[scheduled {_sendAt:g}]");
    _channel.Send(to, message);
    }
}