using Ascetic.Integration.Slack.Models;
using System;
using System.Collections.Generic;

namespace Ascetic.Integration.Slack.Extensions
{
    public static class SlackContextBlockExtensions
    {
        public static SlackMessage AddContextBlock(this SlackMessage message, Func<SlackContext, SlackContext> contextBuilder)
        {
            if (message.Blocks == null)
            {
                message.Blocks = new List<object>();
            }
            var context = contextBuilder(new SlackContext());
            message.Blocks.Add(context);
            return message;
        }

        public static SlackContext AddPlainText(this SlackContext context, string text, bool emoji = true)
        {
            if (context.Elements == null)
            {
                context.Elements = new List<object>();
            }
            context.Elements.Add(new SlackPlainText { Text = text, Emoji = emoji });
            return context;
        }

        public static SlackContext AddMarkdown(this SlackContext context, string markdown)
        {
            if (context.Elements == null)
            {
                context.Elements = new List<object>();
            }
            context.Elements.Add(new SlackMarkdown { Text = markdown });
            return context;
        }

        public static SlackContext AddImage(this SlackContext context, string imageUrl, string altText = default)
        {
            if (context.Elements == null)
            {
                context.Elements = new List<object>();
            }
            context.Elements.Add(new SlackImage { ImageUrl = imageUrl, AltText = altText });
            return context;
        }
    }
}
