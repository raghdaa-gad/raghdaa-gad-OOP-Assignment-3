namespace RefactoringLab;

public class EmailNotification :  INotificationChannel
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[email] {to}: {message}");
}
public class SmsNotification :  INotificationChannel
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[sms] {to}: {message}");
}
