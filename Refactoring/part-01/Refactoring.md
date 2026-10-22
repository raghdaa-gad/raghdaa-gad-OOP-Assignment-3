# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?

The class used a switch statement to identify each shipping carrier and calculate its cost. Adding a new carrier required modifying the existing class, which violated the Open/Closed Principle (OCP).

- What did you change?

Created an IShippingCarrier interface and separate classes for Aramex, FedEx, and DHL. Each carrier implements its own shipping cost calculation. Updated ShippingCostCalculator to depend on the interface instead of carrier names, allowing new carriers to be added without modifying the existing calculator.

---

### OrderProcessor

- What was the problem?

The OrderProcessor created its dependencies directly using new, making it tightly coupled to specific implementations. Changing the database repository or email sender required modifying the class, violating the Dependency Inversion Principle (DIP).

- What did you change?

Created the IOrderRepository and IEmailSender interfaces and made the concrete classes implement them. Updated OrderProcessor to receive its dependencies through constructor injection, allowing implementations to be changed without modifying the order-processing logic.
---

## Notifications

- What was the problem?

The notification classes relied on inheritance to combine different behaviors, such as Email, SMS, Urgent, and Scheduled notifications. This led to duplicated code and too many classes for different combinations.

- What did you change?

Used composition to separate the notification channel from the Urgent and Scheduled behaviors. Created INotificationChannel as a common interface and made UrgentNotification and ScheduledNotification wrap another notification channel and delegate sending to it. This allows behaviors to be combined without creating a separate class for every combination.
---

## Proof

- New carrier file(s): AramexCarrier.cs, FedExCarrier.cs,DhlCarrier.cs
- New notification channel file(s):INotificationChannel.cs,UrgentNotification.cs, ScheduledNotification.cs
- Existing classes left unchanged? No