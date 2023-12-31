﻿using MimeKit;

namespace Vezeeta.Sevices.Models
{
    public class Message
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public Message(IEnumerable<string> to, string subject, string content)
        {
            To = new List<MailboxAddress>();
            To.AddRange(to.Select(e => new MailboxAddress("Emai Confirmation", e)));
            Subject = subject;
            Content = content;
        }
    }
}
