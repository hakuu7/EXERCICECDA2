using System;

public class NotificationEmail : INotification
{
    public void Envoyer(string message)
    {
        Console.WriteLine($"EMAIL : {message}");
    }
} 