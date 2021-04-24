using Ascetic.Integration.Slack.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
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
                    .SetColor(Color.Green))
                .AddAttachment(x => x
                    .SetAuthor("Warning Test")
                    .SetTitle("Test Title")
                    .SetText("Test Text")
                    .SetFooter("Test Footer")
                    .SetColor(Color.Yellow))
                .AddAttachment(x => x
                    .SetAuthor("Danger Test")
                    .SetTitle("Test Title")
                    .SetText("Test Text")
                    .SetFooter("Test Footer")
                    .SetColor(Color.Red));
            await client.PostMessageAsync(message);
        }

        [TestMethod]
        public async Task SlackWebhookClient_Sandbox()
        {
            var client = SlackClientHelper.CreateClient();
            var message = MessageBuilder
                .CreateMessage()
                .AddAttachment(x => x
                    .SetAuthor("Binance")
                    .SetText($":moneybag: Transfer from *Binance* to *Kraken* successfuly created.")
                    .AddField("Amount", $"0.4 BTC")
                    .SetFooter("Transfer Service"));
            await client.PostMessageAsync(message);
        }
    }
}
