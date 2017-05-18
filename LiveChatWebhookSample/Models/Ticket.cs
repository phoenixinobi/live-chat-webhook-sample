
namespace LiveChatWebhookSample.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Ticket
    {
        [JsonProperty("assignee")]
        public object Assignee { get; set; }

        [JsonProperty("events")]
        public object[] Events { get; set; }

        [JsonProperty("groups")]
        public object[] Groups { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("source")]
        public object Source { get; set; }
    }
}