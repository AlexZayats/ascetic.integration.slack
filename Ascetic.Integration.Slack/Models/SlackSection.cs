using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public class SlackSection : SlackBase
    {
        public override string Type => "section";

        [JsonPropertyName("text")]
        public object Text { get; set; }

        [JsonPropertyName("accessory")]
        public object Accessory { get; set; }
    }
}
