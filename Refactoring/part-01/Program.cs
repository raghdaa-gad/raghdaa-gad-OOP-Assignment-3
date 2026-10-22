using RefactoringLab;

var shipping = new ShippingCostCalculator();
Console.WriteLine($"Aramex 2kg → {shipping.Calculate(new AramexCarrier(),2)}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate(new FedExCarrier(),2)}");
Console.WriteLine();

IOrderRepository repository =new SqlOrderRepository();
IEmailSender sender=new SmtpEmailSender();
var processor = new OrderProcessor(repository,sender);
processor.Process(1001, "customer@example.com");
Console.WriteLine();


DateTime sendAt = DateTime.Now.AddHours(1);

INotificationChannel email = new EmailNotification();
INotificationChannel scheduled = new ScheduledNotification(email, sendAt);
INotificationChannel urgent = new UrgentNotification(scheduled);

urgent.Send("customer@example.com", "Hello");