using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public class SlackOption
    {
        [JsonPropertyName("text")]
        public SlackPlainText Text { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
