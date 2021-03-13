using Ascetic.Integration.Slack.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Ascetic.Integration.Slack.Tests
{
    [TestClass]
    public class SlackWebhookClientBlockTests
    {
        [TestMethod]
        public async Task SlackWebhookClient_ContextTest()
        {
            var client = SlackClientHelper.CreateClient();
            var message = MessageBuilder
                .CreateMessage("TEST")
                    .AddContextBlock(x => x
                        .AddImage("https://s3-media3.fl.yelpcdn.com/bphoto/c7ed05m9lC2EmA3Aruue7A/o.jpg", "test image")
                        .AddPlainText(":smile: This is plain text test.")
                        .AddMarkdown(":smile: *This* is markdown test."));
            await client.PostMessageAsync(message);
        }

        [TestMethod]
        public async Task SlackWebhookClient_HeaderTest()
        {
            var client = SlackClientHelper.CreateClient();
            var message = MessageBuilder
                .CreateMessage("TEST")
                    .AddHeaderBlock(":smile: This is header test.");
            await client.PostMessageAsync(message);
        }

        [TestMethod]
        public async Task SlackWebhookClient_DividerTest()
        {
            var client = SlackClientHelper.CreateClient();
            var message = MessageBuilder
                .CreateMessage("TEST")
                    .AddDividerBlock();
            await client.PostMessageAsync(message);
        }

        [TestMethod]
        public async Task SlackWebhookClient_SectionPlainTextBlockTest()
        {
            var client = SlackClientHelper.CreateClient();
            var message = MessageBuilder
                .CreateMessage("TEST")
                    .AddSectionBlock(x => x
                        .SetPlainText("With emoji: :smile: this is plain text test."))
                    .AddSectionBlock(x => x
                        .SetPlainText("Without emoji: :smile: this is plain text test.", false));
            await client.PostMessageAsync(message);
        }

        [TestMethod]
        public async Task SlackWebhookClient_SectionMarkdownBlockTest()
        {
            var client = SlackClientHelper.CreateClient();
            var message = MessageBuilder
                .CreateMessage("TEST")
                    .AddSectionBlock(x => x
                        .SetMarkdown(":smile: *This* is markdown test."));
            await client.PostMessageAsync(message);
        }

        [TestMethod]
        public async Task SlackWebhookClient_SectionImageAccessoryTest()
        {
            var client = SlackClientHelper.CreateClient();
            var message = MessageBuilder
                .CreateMessage("TEST")
                    .AddSectionBlock(x => x
                        .SetMarkdown(":smile: *This* is markdown test.")
                        .SetImageAccessory("https://s3-media3.fl.yelpcdn.com/bphoto/c7ed05m9lC2EmA3Aruue7A/o.jpg", "test image"));
            await client.PostMessageAsync(message);
        }
    }
}