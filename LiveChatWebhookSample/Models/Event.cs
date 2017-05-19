
namespace LiveChatWebhookSample.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Event
    {
        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}