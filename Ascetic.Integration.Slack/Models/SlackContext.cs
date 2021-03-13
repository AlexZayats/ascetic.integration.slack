using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public class SlackContext : SlackBase
    {
        public override string Type => "context";

        [JsonPropertyName("elements")]
        public IList<object> Elements { get; set; }
    }
}
