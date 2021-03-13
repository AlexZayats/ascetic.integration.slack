using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public abstract class SlackBase
    {
        [JsonPropertyName("type")]
        public abstract string Type { get; }
    }
}
