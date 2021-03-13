using Ascetic.Integration.Slack.Interfaces;
using Ascetic.Integration.Slack.Models;

namespace Ascetic.Integration.Slack.Extensions
{
    public static class SlackPlaceholderExtensions
    {
        public static TBlock SetPlaceholder<TBlock>(this TBlock select, string text, bool emoji = true)
            where TBlock: IHasPlaceholder
        {
            select.Placeholder = new SlackPlainText { Text = text, Emoji = emoji };
            return select;
        }
    }
}
