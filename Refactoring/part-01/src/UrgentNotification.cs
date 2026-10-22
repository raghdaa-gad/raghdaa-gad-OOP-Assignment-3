namespace RefactoringLab;

public class UrgentNotification : INotificationChannel
{
    public readonly INotificationChannel _channel;
    public UrgentNotification(INotificationChannel channel)
    {
        _channel=channel;
    }
    public void Send(string to, string message)
    {
        _channel.Send(to, $"[URGENT] {message}");
    }
}