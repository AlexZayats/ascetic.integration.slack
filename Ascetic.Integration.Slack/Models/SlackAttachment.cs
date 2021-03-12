using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ascetic.Integration.Slack.Models
{
    public class SlackAttachment
    {
        [JsonPropertyName("mrkdwn_in")]
        public string[] MarkdownIn { get; set; } = new[] { "text" };

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("pretext")]
        public string Pretext { get; set; }

        [JsonPropertyName("author_name")]
        public string AuthorName { get; set; }

        [JsonPropertyName("author_link")]
        public string AuthorLink { get; set; }

        [JsonPropertyName("author_icon")]
        public string AuthorIcon { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("title_link")]
        public string TitleLink { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("footer")]
        public string Footer { get; set; }

        [JsonPropertyName("footer_icon")]
        public string FooterIcon { get; set; }

        [JsonPropertyName("fields")]
        public IList<SlackField> Fields { get; set; }
    }
}
