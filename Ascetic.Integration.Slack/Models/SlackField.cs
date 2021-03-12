using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public class SlackField
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("short")]
        public bool Short { get; set; }
    }
}
