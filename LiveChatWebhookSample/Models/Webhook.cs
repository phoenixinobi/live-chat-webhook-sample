
namespace LiveChatWebhookSample.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Webhook
    {
        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("license_id")]
        public string LicenseId { get; set; }

        [JsonProperty("chat")]
        public Chat Chat { get; set; }

        [JsonProperty("visitor")]
        public Visitor Visitor { get; set; }

        [JsonProperty("pre_chat_survey")]
        public PreChatSurvey PreChatSurvey { get; set; }

        [JsonProperty("ticket")]
        public Ticket Ticket { get; set; }
    }
}