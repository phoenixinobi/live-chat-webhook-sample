
namespace LiveChatWebhookSample.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Chat
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("started_timestamp")]
        public string StartedTimestamp { get; set; }

        [JsonProperty("ended_timestamp")]
        public string EndedTimestamp { get; set; }

        [JsonProperty("messages")]
        public Message[] Messages { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }
}