using Ascetic.Integration.Slack.Models;
using System.Collections.Generic;

namespace Ascetic.Integration.Slack.Extensions
{
    public static class SlackDividerBlockExtensions
    {
        public static SlackMessage AddDividerBlock(this SlackMessage message)
        {
            if (message.Blocks == null)
            {
                message.Blocks = new List<object>();
            }
            message.Blocks.Add(new SlackDivider());
            return message;
        }
    }
}
