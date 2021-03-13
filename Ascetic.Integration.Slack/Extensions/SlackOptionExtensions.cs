using Ascetic.Integration.Slack.Interfaces;
using Ascetic.Integration.Slack.Models;
using System.Collections.Generic;

namespace Ascetic.Integration.Slack.Extensions
{
    public static class SlackOptionExtensions
    {
        public static TBlock AddOption<TBlock>(this TBlock select, string value, string text, bool emoji = true)
            where TBlock : IHasOptions
        {
            if (select.Options == null)
            {
                select.Options = new List<SlackOption>();
            }
            select.Options.Add(new SlackOption { Text = new SlackPlainText { Text = text, Emoji = emoji }, Value = value });
            return select;
        }
    }
}
