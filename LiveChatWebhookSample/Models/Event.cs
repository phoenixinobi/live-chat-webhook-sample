
namespace LiveChatWebhookSample.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Event
    {
        public Author Author { get; set; }

        public string Date { get; set; }

        public bool IsPrivate { get; set; }

        public string Message { get; set; }

        public Source Source { get; set; }

        public string Type { get; set; }
    }
}