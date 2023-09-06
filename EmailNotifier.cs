class EmailNotifier
{
    public Action<Email> SendEmail;
    public EmailNotifier()
    {
        SendEmail = SendDefaultEmail;
    }
    private void SendDefaultEmail(Email email)
    {
        Console.WriteLine($"Sending email to: {email.To}");
        Console.WriteLine($"Subject: {email.Subject}");
        Console.WriteLine($"Body: {email.Body}");
        Console.WriteLine("Email sent successfully!");
    }
    public Predicate<string> IsEmailValid = (email) => email.Contains("@");
    public Func<DateTime> GetCurrentTime = () => DateTime.Now;
    public void SendCustomEmail(Email email, Action<Email> customSendMethod)
    {
        if (IsEmailValid(email.To))
        {
            Console.WriteLine($"Email address is valid for: {email.To}");
            Console.WriteLine($"Current time: {GetCurrentTime()}");
            customSendMethod(email);
        }
        else
        {
            Console.WriteLine("Invalid email address.");
        }
    }
}