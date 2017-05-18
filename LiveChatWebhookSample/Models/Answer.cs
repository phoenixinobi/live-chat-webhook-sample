
namespace LiveChatWebhookSample.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Answer
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("chosen")]
        public bool Chosen { get; set; }
    }
}