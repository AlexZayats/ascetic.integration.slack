using Ascetic.Integration.Slack.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Ascetic.Integration.Slack.Tests
{
    [TestClass]
    public class SlackWebhookClientAttachmentTests
    {
        [TestMethod]
        public async Task SlackWebhookClient_AttachmentTest()
        {
            var client = SlackClientHelper.CreateClient();
            var message = MessageBuilder
                .CreateMessage()
                .AddAttachment(x => x
                    .SetAuthor("Success Test")
                    .SetTitle("Test Title")
                    .SetText("Test Text")
                    .SetFooter("Test Footer")
                    .SetSuccessStatus())
                .AddAttachment(x => x
                    .SetAuthor("Warning Test")
                    .SetTitle("Test Title")
                    .SetText("Test Text")
                    .SetFooter("Test Footer")
                    .SetWarningStatus())
                .AddAttachment(x => x
                    .SetAuthor("Danger Test")
                    .SetTitle("Test Title")
                    .SetText("Test Text")
                    .SetFooter("Test Footer")
                    .SetDangerStatus());
            await client.PostMessageAsync(message);
        }
    }
}
