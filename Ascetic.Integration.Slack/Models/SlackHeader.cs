using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public class SlackHeader : SlackBase
    {
        public override string Type => "header";

        [JsonPropertyName("text")]
        public SlackPlainText Text { get; set; }
    }
}
