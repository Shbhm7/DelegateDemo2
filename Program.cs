class Program
{
  static void Main()
   {
        EmailNotifier notifier = new EmailNotifier();
        Email email1 = new Email
        {
            To = "user@example.com",
            Subject = "Hello",
            Body = "This is a test email."
        };
        Email email2 = new Email
        {
            To = "invalid-email",
            Subject = "Greetings",
            Body = "This is an invalid email."
        };
        Console.WriteLine("Sending Default Email:");
        notifier.SendEmail(email1);
        Console.WriteLine("\nSending Custom Email:");
        notifier.SendCustomEmail(email1, (email) =>
        {
            Console.WriteLine($"Custom email sending logic for: {email.To}");
            Console.WriteLine($"Email sent to {email.To} with subject '{email.Subject}' and body: {email.Body}");
        });
        Console.WriteLine("\nSending Email with Invalid Address:");
        notifier.SendCustomEmail(email2, (email) =>
        {

            Console.WriteLine($"Custom email sending logic for: {email.To}");
       });
}
}
