using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public class SlackMessage
    {
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("attachments")]
        public IEnumerable<SlackAttachment> Attachments { get; set; }
    }
}
