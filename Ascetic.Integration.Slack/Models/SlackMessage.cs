using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public class SlackMessage
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("blocks")]
        public IList<object> Blocks { get; set; }

        [JsonPropertyName("attachments")]
        public IList<SlackAttachment> Attachments { get; set; }
    }
}
