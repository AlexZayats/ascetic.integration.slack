using Ascetic.Integration.Slack.Interfaces;
using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public class SlackUsersSelect : SlackActionBase, IHasPlaceholder
    {
        public override string Type => "users_select";

        [JsonPropertyName("placeholder")]
        public SlackPlainText Placeholder { get; set; }
    }
}
