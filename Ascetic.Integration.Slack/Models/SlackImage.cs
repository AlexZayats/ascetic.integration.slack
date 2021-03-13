using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public class SlackImage : SlackBase
    {
        public override string Type => "image";

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("alt_text")]
        public string AltText { get; set; }

        [JsonPropertyName("text")]
        public SlackPlainText Text { get; set; }
    }
}
