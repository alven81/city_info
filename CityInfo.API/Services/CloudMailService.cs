﻿namespace CityInfo.API.Services
{
    public class CloudMailService: IMailService
    {
        private readonly string _mailTo = "alven81.ak@gmail.com";
        private readonly string _mailFrom = "noreply@gmail.com";

        public void Send(string subject, string message)
        {
            // send mail - output to console window
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " + $"with {nameof(CloudMailService)}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
