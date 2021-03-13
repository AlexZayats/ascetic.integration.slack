using Ascetic.Integration.Slack.Models;

namespace Ascetic.Integration.Slack
{
    public static class MessageBuilder
    {
        public static SlackMessage CreateMessage(string text = default)
        {
            return new SlackMessage
            {
                Text = text
            };
        }
    }
}
