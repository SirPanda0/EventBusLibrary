using EmailLibrary.Models;
using EventBus.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailLibrary.Events
{
   public class MailMessageIntegrationEvent : IntegrationEvent
    {
        public string SenderName { get; private set; }
        public string ReceiverName { get; private set; }
        public string FromAddress { get; private set; }
        public List<Attachmes> Attachmes { get; private set; }
        public string Html { get; private set; }
        public string Subject { get; private set; }
        public string Text { get; private set; }
        public string ToAddress { get; private set; }

        public MailMessageIntegrationEvent(string sendername, string receivername, string fromaddress, List<Attachmes> attachmes,
            string html, string subject, string text, string toAddress)
        {
            SenderName = sendername;
            ReceiverName = receivername;
            FromAddress = fromaddress;
            Attachmes = attachmes;
            Html = html;
            Subject = subject;
            Text = text;
            ToAddress = toAddress;
        }
    }
}
