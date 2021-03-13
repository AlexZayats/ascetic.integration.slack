using Ascetic.Integration.Slack.Models;
using System.Collections.Generic;

namespace Ascetic.Integration.Slack.Extensions
{
    public static class SlackImageBlockExtensions
    {
        public static SlackMessage AddImageBlock(this SlackMessage message, string imageUrl, string altText = default, string markdown = default, bool emoji = true)
        {
            if (message.Blocks == null)
            {
                message.Blocks = new List<object>();
            }
            var image = new SlackImage { ImageUrl = imageUrl, AltText = altText };
            if (markdown != default)
            {
                image.Text = new SlackPlainText { Text = markdown, Emoji = emoji };
            }
            message.Blocks.Add(image);
            return message;
        }
    }
}
