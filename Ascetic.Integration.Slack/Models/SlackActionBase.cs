using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public abstract class SlackActionBase : SlackBase
    {
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
    }
}
