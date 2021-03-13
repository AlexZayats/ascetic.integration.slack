using Ascetic.Integration.Slack.Models;
using System;
using System.Collections.Generic;

namespace Ascetic.Integration.Slack.Extensions
{
    public static class SlackSectionBlockExtensions
    {
        public static SlackMessage AddSectionBlock(this SlackMessage message, Func<SlackSection, SlackSection> sectionBuilder)
        {
            if (message.Blocks == null)
            {
                message.Blocks = new List<object>();
            }
            var section = sectionBuilder(new SlackSection());
            message.Blocks.Add(section);
            return message;
        }

        public static SlackSection SetPlainText(this SlackSection section, string text, bool emoji = true)
        {
            section.Text = new SlackPlainText { Text = text, Emoji = emoji };
            return section;
        }

        public static SlackSection SetMarkdown(this SlackSection section, string markdown)
        {
            section.Text = new SlackMarkdown { Text = markdown };
            return section;
        }

        public static SlackSection SetImageAccessory(this SlackSection section, string imageUrl, string altText = default)
        {
            section.Accessory = new SlackImage { ImageUrl = imageUrl, AltText = altText };
            return section;
        }

        public static SlackSection SetUsersSelectAccessory(this SlackSection section)
        {
            section.Accessory = new SlackUsersSelect();
            return section;
        }

        public static SlackSection SetStaticSelectAccessory(this SlackSection section, Func<SlackStaticSelect, SlackStaticSelect> selectBuilder)
        {
            section.Accessory = selectBuilder(new SlackStaticSelect());
            return section;
        }
    }
}
