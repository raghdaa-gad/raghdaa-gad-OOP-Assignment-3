namespace RefactoringLab;

public class OrderProcessor
{
    private readonly IOrderRepository _repository;
    private readonly IEmailSender _sender;
    public OrderProcessor(IOrderRepository repository,IEmailSender sender)
    {
        _repository=repository;
        _sender=sender;
    }
    public void Process(int orderId, string customerEmail)
    {
        
        
        _repository.Save(orderId, DateTime.Now);
      _sender.Send(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
    }
}

public class SqlOrderRepository : IOrderRepository
{
    public void Save(int orderId, DateTime processedAt) =>
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
}

public class SmtpEmailSender :IEmailSender
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
}
