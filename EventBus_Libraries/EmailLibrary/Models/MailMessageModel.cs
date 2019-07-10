using System;
using System.Collections.Generic;
using System.Text;

namespace EmailLibrary.Models
{
    public class MailMessageModel
    {
        public string SenderName { get; set; }
        public string FromAddress { get; set; }

        public string ReceiverName { get; set; }
        public string ToAddress { get; set; }

        public string Subject { get; set; }

        public string Text { get; set; }
        public string Html { get; set; }

        public List<Attachmes> Attachmes { get; set; }
    }
}
