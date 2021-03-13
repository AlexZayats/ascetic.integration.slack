using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public class SlackPlainText : SlackBase
    {
        public override string Type => "plain_text";

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("emoji")]
        public bool Emoji { get; set; }
    }
}
