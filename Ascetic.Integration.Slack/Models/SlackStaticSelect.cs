using Ascetic.Integration.Slack.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public class SlackStaticSelect : SlackActionBase, IHasPlaceholder, IHasOptions
    {
        public override string Type => "static_select";

        [JsonPropertyName("placeholder")]
        public SlackPlainText Placeholder { get; set; }

        [JsonPropertyName("options")]
        public IList<SlackOption> Options { get; set; }
    }
}
