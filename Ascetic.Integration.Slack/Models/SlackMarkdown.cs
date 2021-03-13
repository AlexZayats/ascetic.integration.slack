using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public class SlackMarkdown : SlackBase
    {
        public override string Type => "mrkdwn";

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
