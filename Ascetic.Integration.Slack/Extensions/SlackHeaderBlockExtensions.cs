using Ascetic.Integration.Slack.Models;
using System.Collections.Generic;

namespace Ascetic.Integration.Slack.Extensions
{
    public static class SlackHeaderBlockExtensions
    {
        public static SlackMessage AddHeaderBlock(this SlackMessage message, string text, bool emoji = true)
        {
            if (message.Blocks == null)
            {
                message.Blocks = new List<object>();
            }
            message.Blocks.Add(new SlackHeader { Text = new SlackPlainText { Text = text, Emoji = emoji } });
            return message;
        }
    }
}
